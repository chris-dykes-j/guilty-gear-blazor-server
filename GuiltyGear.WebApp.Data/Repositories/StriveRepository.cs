using GuiltyGear.WebApp.Context;
using GuiltyGear.WebApp.Data;
using Microsoft.EntityFrameworkCore;

namespace GuiltyGear.WebApp.Repositories;

public class StriveRepository : IGameRepository
{
    private readonly GuiltyGearDatabase _context;

    public StriveRepository(GuiltyGearDatabase context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    
    public async Task<IEnumerable<StriveCharacter>> GetAllCharacters()
    {
        return await _context.StriveCharacters
            .OrderBy(x => x.Name)
            .ToListAsync();
    }

    public async Task<IGameCharacter?> GetCharacterData(int characterId)
    {
        return await _context.StriveCharacters
            .Where(x => x.Id == characterId)
            .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<ICharacterMove>> GetCharacterMoveList(int characterId)
    {
        return await _context.StriveMoves
            .Where(x => x.CharacterId == characterId)
            .ToListAsync();
    }

    public async Task<ICharacterMove?> GetCharacterMoveData(int moveId)
    {
        return await _context.StriveMoves
            .Where(x => x.Id == moveId)
            .FirstOrDefaultAsync();
    }

    public async Task<IGatlingData?> GetMoveGatlingData(int moveId)
    {
        return await _context.StriveMoveGatlingData
            .Where(x => x.MoveId == moveId)
            .FirstOrDefaultAsync();
    }
}