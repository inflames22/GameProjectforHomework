using System;
using GameProject.Entity;

namespace GameProject.Abstract
{
    public abstract class BaseGameSaleManager:IGameSaleService
    {

        public virtual void Sale(Customer customer, Game game,Campaing campaing)
        {
            Console.WriteLine(game.Name+" has been Sold to "+customer.Name);
            Console.WriteLine("You can take advantage of "+campaing.Name+" now");
        }
    }
}