
using Dependency_Injection_Demo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddLifetimeServices();

/*
builder.Services.AddSingleton<IDemoService, DemoService>();
// See the difference between scoped and transiet in the next set of services.
builder.Services.AddScoped<IDemoService, DemoService>();
*/

// builder.Services.AddScoped<IScopedService, ScopedService>();
// builder.Services.AddTransient<ITransientService, TransientService>();
// builder.Services.AddSingleton<ISingletonService, SingletonService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
