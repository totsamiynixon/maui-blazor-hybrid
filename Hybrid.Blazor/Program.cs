using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Hybrid.Core;
using Hybrid.Core.Data;
using Hybrid.Core.Services;
using Hybrid.Blazor.Services;

namespace Hybrid.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddSingleton<IDialogService, DialogService>();

            await builder.Build().RunAsync();
        }
    }
}
