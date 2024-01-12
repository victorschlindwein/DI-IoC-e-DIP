using DependencyStore;
using DependencyStore.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddSingleton<Configuration>();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddSqlConnection(connectionString);
builder.Services.AddRepositories();
builder.Services.AddServices();

var app = builder.Build();

app.MapControllers();

app.Run();