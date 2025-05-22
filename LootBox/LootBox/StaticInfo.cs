using LootBox.models;
using LootBox.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootBox
{
    public static class StaticInfo
    {

        public static List<Cathegory> Cathegorys { get; set; } = new List<Cathegory>()
        {
            new Cathegory()
            {
                Id = 1,
                Name = "ЭВМ",
            }
        };

        public static List<Item> Items { get; set; } = new List<Item>()
        {
            new Item()
            {
                Name = "Офисный ПК",
                Description = "Слабый",
                Id = 1,
                Cathegory = "ЭВМ",
                Rare = "Обычный"
            }
        };

        public static List<Rare> Rarity { get; set; } = new List<Rare>()
        {
            new Rare()
            {
                Name = "Обычный",
                Rate = 50,
                Color = "#525c6b",
                Id = 1,

            }
        };

        public static List<LootBoxes> LootBoxes { get; set; } = new List<LootBoxes>()
        {
            new LootBoxes()
            {
                Name = "Бокс с ЭВМ",
                Id= 1,
                Description = "Небольшой бокс",
                Amount = 1,
                Items = new ObservableCollection<Item> { Items[0] }
            }
        };
    }
}
