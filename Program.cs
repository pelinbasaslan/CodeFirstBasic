using CodeFirstBasic.Context;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("defaultConnection");


builder.Services.AddDbContext<PatikaFirstDbContext>(options => options.UseNpgsql(connectionString));
var app = builder.Build();


app.Run();
