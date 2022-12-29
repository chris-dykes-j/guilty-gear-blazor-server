namespace GuiltyGear.WebApp.Data;

public class StriveCharacterMove : ICharacterMove
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public string? MoveName { get; set; }
    public string Input { get; set; } = null!;
    
    public string? Damage { get; set; }
    public string? Guard { get; set; }
    public string? Startup { get; set; }
    public string? Active { get; set; }
    public string? Recovery { get; set; }
    public string? Block { get; set; }
    public string? Invulnerability { get; set; }
}