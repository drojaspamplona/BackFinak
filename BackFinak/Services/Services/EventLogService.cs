using System.Diagnostics;
using BackFinak.Data;
using BackFinak.Models;
using BackFinak.Services.ServicesInterface;
using Microsoft.EntityFrameworkCore;
using EventLog = BackFinak.Models.EventLog;

namespace BackFinak.Services;

public class EventLogService : IEventLogService
{
    private readonly DbContextApplication _context;
    
    public EventLogService(DbContextApplication context)
    {
        _context = context;
    }

    public async Task<IEnumerable<EventLog>> GetEventsAsync()
    {
        return await _context.EventLogs.ToListAsync();
    }
    
    public async Task<string> CreateEventLog(EventLogCreate  eventLogCreate)
    {
        Guid newGuid = Guid.NewGuid();
        DateTime defaultDateTime = DateTime.Now;
        var log = new EventLog
        {
            IdEventLog = newGuid.ToString(),
            EventDate = defaultDateTime,
            DescriptionEvent = eventLogCreate.DescriptionEvent,
            IdEventType = eventLogCreate.IdEventType,
        };

        _context.EventLogs.Add(log);
        await _context.SaveChangesAsync();

        return newGuid.ToString(); 
    }
}