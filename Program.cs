using System;

namespace GameProjectDemo

{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer {FirstName="Kutay",LastName="Aktaş",UserName="Kutayxxx",Games = "Doom 3"};
            //CustomerManager customerManager = new CustomerManager(new ValidationService());
            //customerManager.Add(customer);
            //customerManager.Delete(customer);
            //SalesManager Sales = new SalesManager();
            //Sales.Sell(customer);
            Game game = new Game { Price = 5000 };
            Campaign campaign1 = new Campaign { Percentage = 2593 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Discount(campaign1, game);

            
        }
    }
}
