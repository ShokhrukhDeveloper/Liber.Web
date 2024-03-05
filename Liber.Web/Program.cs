using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Liber.Web;
using Liber.Web.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri("http://localhost:5104")});
//builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri("http://185.217.131.244")});
builder.Services.AddScoped<ICategoryService,CategoryService>();
builder.Services.AddScoped<ISubCategoryService,SubCategoryService>();
builder.Services.AddBlazorBootstrap();
await builder.Build().RunAsync();