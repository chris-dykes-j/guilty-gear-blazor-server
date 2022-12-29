namespace GuiltyGear.WebApp.Data;

public interface IGameRepository
{
    public IEnumerable<IGameCharacter> GetAllCharacters();
    public IGameCharacter GetCharacterDataByName(int characterId);
    public IEnumerable<ICharacterMove> GetCharacterMoveList(int characterId);
    public ICharacterMove GetCharacterMoveData(int moveId);
    public IGatlingData GetMoveGatlingData(int moveId);
}