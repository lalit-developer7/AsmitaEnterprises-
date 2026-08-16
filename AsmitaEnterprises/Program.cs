using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AsmitaEnterprises.Components;
using AsmitaEnterprises.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Client-side singleton services for SPA state management & static data access
builder.Services.AddSingleton<LanguageService>();
builder.Services.AddSingleton<WhatsAppService>();
builder.Services.AddSingleton<ProductService>();
builder.Services.AddSingleton<ReviewService>();
builder.Services.AddSingleton<SiteContentService>();

await builder.Build().RunAsync();
