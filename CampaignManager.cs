using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Discount(Campaign campaign, Game game)
        {
            game.Price = game.Price - campaign.Percentage;
            Console.WriteLine("Oyunun İndirimli Fiyatı" + game.Price);
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
