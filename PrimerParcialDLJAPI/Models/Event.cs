namespace PrimerParcialDLJAPI.Models;

public class Event
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public DateTime StartAt { get; set; }
    public DateTime? EndAt { get; set; }
    public bool IsOnline { get; set; }
    public string? Notes { get; set; }
}