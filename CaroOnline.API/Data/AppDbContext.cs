using CaroOnline.API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CaroOnline.API.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<User>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>(user =>
        {
            user.HasMany<Game>(u => u.GamesAsPalyer1)
                .WithOne(g => g.Player1);
            user.HasMany<Game>(u => u.GamesAsPalyer2)
                .WithOne(g => g.Player2);
        });

        builder.Entity<Game>(game =>
        {
            game.HasMany<GameMove>(g => g.GameMoves)
                .WithOne(g => g.Game);
        });
    }
}