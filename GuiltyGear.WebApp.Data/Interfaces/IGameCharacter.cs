namespace GuiltyGear.WebApp.Data;

public interface IGameCharacter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? JpName { get; set; }
}