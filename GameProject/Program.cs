using System;
using GameProject.Abstract;
using GameProject.Concreate;
using GameProject.Entity;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Pero";
            customer1.Id = 4298;
            customer1.NationalId = "2049390493";
            customer1.DateOfBirth = new DateTime(1928, 4, 6);

            Game game1 = new Game();
            game1.Name = "GTA V";
            game1.Price = "60";
            game1.Id = 2323;

            Campaing campaing1 = new Campaing();
            campaing1.Name = "Summer--sale";
            campaing1.Id = 3435;
            campaing1.Percentage = 12.5;
            campaing1.DateOfStart = new DateTime(2021, 8, 14);
            campaing1.DateOfFinish = new DateTime(2021, 9, 14);
            
            BaseCustomerManager customerManager = new EaGamesCustomerManager(new CheckRealCustomerManager());
            customerManager.Save(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);
            

            BaseGameManager gameManager = new EaGamesGameManager();
            gameManager.About(game1);


            BaseCampaingMananager campaingMananager = new BaseCampaingMananager();
            campaingMananager.Save(campaing1);
            campaingMananager.Update(campaing1);
            campaingMananager.Delete(campaing1);
            campaingMananager.Start(campaing1);
            campaingMananager.Finish(campaing1);
            campaingMananager.About(campaing1);

            BaseGameSaleManager baseGameSaleManager = new EaGamesGameSaleManager();
            baseGameSaleManager.Sale(customer1,game1,campaing1);

        }

    }
}