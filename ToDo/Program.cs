using ClassLibrary1.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ToDO.DAL;
using ToDO.DAL.Interfaces;
using ToDO.DAL.Repos;
using ToDoService.Implement;
using ToDoService.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IBaseRepos<TaskEntity>, TaskRepos>();

builder.Services.AddScoped<ITaskService, TaskService>();

var connectionString = builder.Configuration.GetConnectionString("PostgreSql");
builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerGen(
    c => c.SwaggerDoc(
        "v1", new OpenApiInfo
        {
            Title = "HW"
        }
    ));
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

var app = builder.Build();



if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}


app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Task}/{action=Index}/{id?}");

app.Run();