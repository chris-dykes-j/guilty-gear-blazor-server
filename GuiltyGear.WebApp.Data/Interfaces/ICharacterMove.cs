namespace GuiltyGear.WebApp.Data;

public interface ICharacterMove
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public string? MoveName { get; set; }
    public string Input { get; set; }
}