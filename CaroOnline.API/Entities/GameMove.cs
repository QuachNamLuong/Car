namespace CaroOnline.API.Entities;

public class GameMove
{
    public Guid Id { get; set; }
    
    public Guid GameId { get; set; }
    public Game Game { get; set; }
    
    public Guid PlayerId { get; set; }
    public User Player { get; set; }
    
    public int X { get; set; }
    public int Y { get; set; }
    public DateTime Timestamp { get; set; }
}