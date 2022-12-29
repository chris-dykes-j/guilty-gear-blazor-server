using GuiltyGear.WebApp.Data;
using Microsoft.EntityFrameworkCore;

namespace GuiltyGear.WebApp.Context;

public class GuiltyGearDatabase : DbContext
{
    public GuiltyGearDatabase(DbContextOptions<GuiltyGearDatabase> options) : base(options) { }
    public DbSet<StriveCharacter> StriveCharacters { get; set; } = null!;
    public DbSet<StriveCharacterMove> StriveMoves { get; set; } = null!;
    public DbSet<StriveGatlingData> StriveMoveGatlingData { get; set; } = null!;
}