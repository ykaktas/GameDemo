﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
     interface ICustomerService
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);

    }
}
