using Microsoft.EntityFrameworkCore;
using WebApplication1Project.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IEmployeeRepository, SQLEmployeeRepository>();

builder.Services.AddDbContext<Appdbcontext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDBConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowSpecificOrigins",
                      builder =>
                      {
                          builder.WithOrigins("http://1migration27.0.0.1:5500")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                      });
})
;
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseCors("MyAllowSpecificOrigins");

app.MapControllers();

app.Run();
       
    