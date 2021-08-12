using GameProject.Entity;

namespace GameProject.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Customer customer,Game game,Campaing campaing);
    }
}