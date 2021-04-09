using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract.Concrete
{
    public class StabucksCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StabucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer) //mernis doğrulamsı yapılacak
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
                Console.WriteLine("İşlem başarılı") ;
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız!!!");
            }
            
        }

        private void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
