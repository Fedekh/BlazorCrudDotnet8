using BlazorCrudDotnet8.Entities;

namespace BlazorCrudDotnet8.Services
{
    public interface IGameService
    {
        public Task<List<Game>> GetAllGames();
    }
}
