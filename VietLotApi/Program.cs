using Microsoft.EntityFrameworkCore;
using VietLotApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Database context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Auto migrate Database on startup (For Docker) with retry logic
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    var retries = 10;
    while (retries > 0)
    {
        try 
        {
            Console.WriteLine("Attempting Database Migration...");
            dbContext.Database.Migrate();
            Console.WriteLine("Database Migration Successful!");
            break;
        } 
        catch(Exception ex) 
        {
            Console.WriteLine("Migration Error: " + ex.Message + ". Retrying in 5 seconds...");
            System.Threading.Thread.Sleep(5000);
            retries--;
        }
    }
}

// Configure the HTTP request pipeline.
// Luôn hiện Swagger kể cả môi trường Production để test dễ dàng
app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseAuthorization();
app.MapControllers();

app.Run();