using Serilog;
using Serilog.Events;

namespace Ipms.Core
{
    public class Program
    {
        public static void Main(string[] arguments)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .WriteTo.File($"Logs//Ipms-log-{DateTime.Now.Date}.log")
                .CreateLogger();

            try
            {
                Log.Information("Application Starting up");
                CreateHostBuilder(arguments).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application start-up failed");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] arguments)
        {
            return Host.CreateDefaultBuilder(arguments)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                    webBuilder.UseStartup<Startup>());
        }
    }
}