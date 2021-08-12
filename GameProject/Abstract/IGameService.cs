using GameProject.Entity;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void About(Game game);
    }
}