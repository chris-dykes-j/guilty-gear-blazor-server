namespace GuiltyGear.WebApp.Data;

public class StriveCharacter : IGameCharacter
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? JpName { get; set; }
    
    public string? Defense { get; set; }
    public string? Guts { get; set; }
    public string? PreJump { get; set; }
    public string? Weight { get; set; }
    public string? BackDash { get; set; }
    public string? ForwardDash { get; set; }
    public string? UniqueMovement { get; set; }
    public string? RiscMultiplier { get; set; }
    public string? TensionGain { get; set; }
}