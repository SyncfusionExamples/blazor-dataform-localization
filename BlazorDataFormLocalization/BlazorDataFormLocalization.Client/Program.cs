using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using BlazorDataFormLocalization.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));
builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();
