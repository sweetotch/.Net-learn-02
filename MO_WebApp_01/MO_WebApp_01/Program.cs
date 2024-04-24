using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MO_WebApp_01;
using MO_WebApp_01.Data.Interfaces;
using MO_WebApp_01.Data.mocks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddTransient<ICars, MockCars>();
builder.Services.AddTransient<ICarsCategory, MockCategory>();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
//app.UseMvcWithDefaultRoute();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
});

app.MapGet("/", () => "Hello World!");



app.Run();


