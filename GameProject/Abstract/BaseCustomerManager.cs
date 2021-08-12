using System;
using GameProject.Entity;

namespace GameProject.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Gamer's Account is Save!!!" + "(" + customer.Name + ")");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Gamer's Account is Update!!!"+"("+customer.Name+")");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Gamer's Account is Delete!!!"+"("+customer.Name+")");
        }
    }
}