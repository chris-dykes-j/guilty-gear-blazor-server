namespace GuiltyGear.WebApp.Data;

public class StriveGatlingData : IGatlingData
{
    public int Id { get; set; }
    public int MoveId { get; set; }
    public string MoveName { get; set; } = null!;
}