using LootBox.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootBox.Models
{
    public class LootBoxHelp
    {
        public static class LootBoxHelper
        {
            private static Random rand = new Random();

            public static Rare GetRandomRarity()
            {
                int totalRate = StaticInfo.Rarity.Sum(r => r.Rate);
                double roll = rand.NextDouble() * totalRate;

                double cumulative = 0;
                foreach (var rarity in StaticInfo.Rarity)
                {
                    cumulative += rarity.Rate;
                    if (roll <= cumulative)
                    {
                        return rarity;
                    }
                }
                return null;
            }

            public static Item GetRandomItemByRarity(List<Item> items, int rarityId)
            {
                var filteredItems = items.Where(i => i.RareId == rarityId).ToList();
                if (filteredItems.Count == 0)
                    return null;

                int index = rand.Next(filteredItems.Count);
                return filteredItems[index];
            }
        }
    }
}
