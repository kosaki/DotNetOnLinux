using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace EFSQLite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                        .UseKestrel()
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseDefaultHostingConfiguration(args)
                        .UseIIS()
                        .UseStartup<Startup>().UseUrls("http://*:5000")
                        .Build();

            host.Run();
        }
    }
}
