using BlazorCrudDotnet8.Data;
using BlazorCrudDotnet8.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorCrudDotnet8.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetAllGames()
        {
            List<Game> listGames = await _context.Games.ToListAsync();
            return listGames;
        }
    }
}
