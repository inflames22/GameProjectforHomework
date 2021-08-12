using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concreate
{
    public class CheckRealCustomerManager:ICheckRealCustomerService
    {
        public  bool IfRealCustomer(Customer customer)
        {
            return true;
        }
    }
}