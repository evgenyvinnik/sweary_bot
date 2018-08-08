using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace SwearyBot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Swears = JsonConvert.DeserializeObject<List<Swear>>(File.ReadAllText("assets\\swears.json"));

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();


        public static List<Swear> Swears { get; set; }
    }
}
