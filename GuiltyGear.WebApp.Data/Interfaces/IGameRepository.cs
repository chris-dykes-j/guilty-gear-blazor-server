namespace GuiltyGear.WebApp.Data;

public interface IGameRepository
{
    public Task<IEnumerable<StriveCharacter>> GetAllCharacters();
    public Task<IGameCharacter?> GetCharacterData(int characterId);
    public Task<IEnumerable<ICharacterMove>> GetCharacterMoveList(int characterId);
    public Task<ICharacterMove?> GetCharacterMoveData(int moveId);
    public Task<IGatlingData?> GetMoveGatlingData(int moveId);
}