using Microsoft.AspNetCore.Identity;

namespace CaroOnline.API.Entities;

public class User : IdentityUser
{
    public ICollection<Game> GamesAsPalyer1 { get; set; }
    public ICollection<Game> GamesAsPalyer2 { get; set; }
}