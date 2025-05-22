using LootBox.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootBox.Models
{
    public static class LootBoxService
    {
        private static Random rng = new Random();

        public static Item OpenLootBox(LootBoxes lootBox)
        {
            if (lootBox == null || lootBox.Items == null || lootBox.Items.Count == 0)
                return null;

            int index = rng.Next(lootBox.Items.Count);
            return lootBox.Items[index];
        }
    }
}
