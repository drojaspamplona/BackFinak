using BackFinak.Models;

namespace BackFinak.Services.ServicesInterface;

public interface IEventLogService
{
    Task<IEnumerable<EventLog>> GetEventsAsync();
    Task<string> CreateEventLog(EventLogCreate eventLogCreate);
}