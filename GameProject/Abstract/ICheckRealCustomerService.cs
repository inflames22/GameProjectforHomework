using GameProject.Entity;

namespace GameProject.Abstract
{
    public interface ICheckRealCustomerService
    {
        bool IfRealCustomer(Customer customer);
    }
}