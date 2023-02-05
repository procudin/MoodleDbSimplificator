using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoodleDbSimplificator.MoodleDb.V39;

namespace MoodleDbSimplificator.Services;

public interface IMoodle39ExportService
{
    Task Export(CancellationToken cancellationToken = default);
}

public class Moodle39ExportService : IMoodle39ExportService
{
    private readonly Moodle39DbContext _moodleDb;
    private readonly ILogger<Moodle39ExportService> _logger;

    public Moodle39ExportService(Moodle39DbContext moodleDb, ILogger<Moodle39ExportService> logger)
    {
        _moodleDb = moodleDb;
        _logger   = logger;
    }

    public async Task Export(CancellationToken cancellationToken)
    {
        var totalUsersCount = await _moodleDb.MdlUsers.CountAsync(cancellationToken: cancellationToken);
        _logger.LogInformation("Total users {}", totalUsersCount);
    }
}