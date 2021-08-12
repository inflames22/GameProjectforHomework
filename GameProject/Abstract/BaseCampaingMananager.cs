using System;
using GameProject.Entity;

namespace GameProject.Abstract
{
    public class BaseCampaingMananager:ICampaingService
    {
        public void Save(Campaing campaing)
        {
            Console.WriteLine("Campaing Has Been Added to DataBase"+"("+campaing.Name+")");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Campaing has been Deleted from DataBase"+"("+campaing.Name+")");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Campaing has been Updated"+"("+campaing.Name+")");
        }

        public void Start(Campaing campaing)
        {
            Console.WriteLine("Campaing has been Started"+"("+campaing.Name+")");
        }

        public void Finish(Campaing campaing)
        {
            Console.WriteLine("Campaing has been Finished"+"("+campaing.Name+")");
        }

        public void About(Campaing campaing)
        {
            Console.WriteLine("Name :" + campaing.Name);
            Console.WriteLine("Id :" + campaing.Id);
            Console.WriteLine("Percentage :"+campaing.Percentage);
            Console.WriteLine("Date Of Start :"+campaing.DateOfStart);
            Console.WriteLine("Date Of Finish :"+campaing.DateOfFinish);
            
        }
    }
}