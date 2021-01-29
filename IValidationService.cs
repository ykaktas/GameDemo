using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public interface IValidationService
    {
        bool Validation(Customer customer);
    }
}
