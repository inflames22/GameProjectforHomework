using System;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concreate
{
    public class EaGamesCustomerManager:BaseCustomerManager
    {
        private ICheckRealCustomerService _checkRealCustomerService;
       

        public EaGamesCustomerManager(ICheckRealCustomerService checkRealCustomerService)
        {
            _checkRealCustomerService = checkRealCustomerService;
            
        }

        public override void Save(Customer customer)
        {
            if (_checkRealCustomerService.IfRealCustomer(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid Customer");
            }
        }
        
        
       
    }
}