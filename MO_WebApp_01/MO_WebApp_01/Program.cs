using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MO_WebApp_01;
using MO_WebApp_01.Data;
using MO_WebApp_01.Data.Interfaces;
using MO_WebApp_01.Data.mocks;
using MO_WebApp_01.Data.Repository;

var builder = WebApplication.CreateBuilder(args);


//Register AppDBContent class
builder.Services.AddDbContext<AppDBContent>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<ICars, CarsRepository>();

builder.Services.AddTransient<ICarsCategory, CategoriesRepository>();
builder.Services.AddMvc();


var app = builder.Build();


app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
});

using (var scope = app.Services.CreateScope())
{
    AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
    DBObjects.Initial(content);
}


app.MapGet("/", () => "Hello World!");
app.Run();
