using LootBox.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LootBox.Models
{
    public class LootBoxes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();
    }
}
