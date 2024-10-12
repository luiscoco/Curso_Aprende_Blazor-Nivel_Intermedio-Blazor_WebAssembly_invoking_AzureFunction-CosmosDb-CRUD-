using BlazorWebAssemblyForInvokingAzureFunctionCosmosDBCRUD;
using BlazorWebAssemblyForInvokingAzureFunctionCosmosDBCRUD.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://mycosmosdbcrudazurefunction.azurewebsites.net/") });
builder.Services.AddScoped<CosmosDbService>(); 

await builder.Build().RunAsync();
