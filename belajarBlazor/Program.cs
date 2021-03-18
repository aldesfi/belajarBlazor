using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace belajarBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            var operasiSembunyikanYangMana = "operasi1";

            if (operasiSembunyikanYangMana == "operasi2")
            {
                //Sembunyikan 1 id
                builder.RootComponents.Add<Depan>("#operasi1");
            }
            else
            {
                //Sembunyikan 2 id
                 builder.RootComponents.Add<Depan>("#operasi2");
                 builder.RootComponents.Add<Depan>("#operasi1");
            }
           

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
