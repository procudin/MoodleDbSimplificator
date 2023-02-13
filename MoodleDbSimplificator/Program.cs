using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MoodleDbSimplificator.ExportDb;
using MoodleDbSimplificator.MoodleDb.V39;
using MoodleDbSimplificator.Services;

namespace MoodleDbSimplificator;

public class Program
{
    private static IHost _host = null!;
    private static ILogger _logger = null!;

    public static async Task<int> Main(string[] args)
    {
        _host = CreateHostBuilder(args).Build();
        _logger = _host.Services.GetRequiredService<ILoggerFactory>().CreateLogger<Program>();

        try
        {
            await Export();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, null);
            await Console.Error.WriteLineAsync(ex.ToString());
            Thread.Sleep(1000);
            return -1;
        }
        return 0;
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddDbContext<Moodle39DbContext>(options =>
                    options.UseMySql(
                        connectionString: hostContext.Configuration.GetConnectionString("Moodle39"), 
                        serverVersion: new MariaDbServerVersion(new Version(10, 4, 8))));
                
                services.AddDbContext<ExportDbContext>(options =>
                    options.UseMySql(
                        connectionString: hostContext.Configuration.GetConnectionString("Target"), 
                        serverVersion: new MariaDbServerVersion(new Version(10, 4, 8))));

                services.AddScoped<IMoodle39ExportService, Moodle39ExportService>();
            });

    private static async Task Export()
    {
        var service = _host.Services.GetRequiredService<IMoodle39ExportService>();
        await service.Export();
    }
}