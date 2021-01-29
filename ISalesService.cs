using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface ISalesService : ICampaignService
    {
        void Sell(Customer customer);
    }
}
