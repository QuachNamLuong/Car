using CaroOnline.API.Enums;

namespace CaroOnline.API.Entities;

public class Game
{
    public Guid Id { get; set; }
    public Guid Player1Id { get; set; }
    public Guid Player2Id { get; set; }
    public User Player1 { get; set; }
    public User Player2 { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public GameStatus Status { get; set; }
    
    public ICollection<GameMove> GameMoves { get; set; }
}