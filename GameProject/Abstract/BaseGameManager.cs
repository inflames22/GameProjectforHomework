using System;
using GameProject.Entity;

namespace GameProject.Abstract
{
    public abstract class BaseGameManager: IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game Has Been Added to DataBase"+"("+game.Name+")");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game Has Been Deleted from DataBase"+"("+game.Name+")");

        }

        public void Update(Game game)
        {
            Console.WriteLine("Game Has Been Updated"+"("+game.Name+")");

        }

        public void About(Game game)
        {
            Console.WriteLine("Name : "+game.Name);
            Console.WriteLine("Price : "+game.Price);
            Console.WriteLine("Id : "+game.Id);
            
        }
    }
}