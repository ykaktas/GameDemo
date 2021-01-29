using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class CustomerManager : ICustomerService
    {
        IValidationService _validation;

        public CustomerManager(IValidationService validation)
        {
            _validation = validation;
        }

        public void Add(Customer customer)
        {
            if (_validation.Validation(customer))
            {
                Console.WriteLine(customer.FirstName + "  Eklendi");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız.");
            }
            
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "  silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "güncellendi");
        }
    }
}
