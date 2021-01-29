using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class ValidationService : IValidationService
    {
        public bool Validation(Customer customer)
        {

            if (customer.FirstName=="Kutay"&& customer.LastName=="Aktaş"&&customer.UserName=="Kutayxxx")
            {
                return true;
          

            }
            else
            {
                return false;
            }

        }
    }
}
