var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var env=builder.Environment;
builder.Configuration.SetBasePath(env.ContentRootPath)//bunun ne oldu�una da bak. //Api'�n path'ini almak i�in kullan�l�yor.
    .AddJsonFile("appsettings.json",optional : false)
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json",optional:true); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
