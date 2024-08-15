

using BackFinak.Models;
using BackFinak.Services.ServicesInterface;
using Microsoft.AspNetCore.Mvc;

namespace api.solution.doublev.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventLogController : ControllerBase
    {
        private readonly IEventLogService _eventLogService;

        public EventLogController(IEventLogService eventLogService)
        {
            _eventLogService = eventLogService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventLog>>> GetEventsAsync()
        {
            var events = await _eventLogService.GetEventsAsync();
            return Ok(events);
        }
        
        [HttpPost]
        public async Task<ActionResult<string>> CreateEventLog(EventLogCreate eventLogCreate)
        {
            var events = await _eventLogService.CreateEventLog(eventLogCreate);
            return Ok(events);
        }
        
    }
}
