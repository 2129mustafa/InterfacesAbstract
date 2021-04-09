using InterfaceAbstract.Abstract;
using InterfaceAbstract.Adapters;
using InterfaceAbstract.Concrete;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StabucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2002, 6, 25),
                FirstName = "Mustafa",
                LastName = "YENAL",
                NationalityId = "11056791460"
            });

            Console.ReadLine();


        }
    }
}
