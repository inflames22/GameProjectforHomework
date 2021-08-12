
using GameProject.Entity;

namespace GameProject.Abstract
{
  public  interface ICustomerService
    {
        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}