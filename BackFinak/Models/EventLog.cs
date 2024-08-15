namespace BackFinak.Models;

public class EventLog
{
    public string IdEventLog { get; set; }
    public DateTime EventDate { get; set; }
    public string DescriptionEvent { get; set; } = null!;
    public int IdEventType { get; set; }
}

public class EventLogCreate
{
    public string DescriptionEvent { get; set; } = null!;
    public int IdEventType { get; set; }
}