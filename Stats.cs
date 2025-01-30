using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porjekt
{
    public class Stats
    {
        public int Defense { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }

        public Stats()
        {
            Defense = 0;
            Attack = 0;
            Speed = 0;
        }

        public void UpdateStats(int helmet, int chestplate, int pants, int boots, int weapon)
        {
            Defense = (helmet + 1) * 2 + (chestplate + 1) * 3 + (pants + 1) * 1 + (boots + 1) * 2;
            Attack = (weapon + 1) * 5;
            Speed = 10 - (helmet + chestplate + pants + boots);
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public Stats ItemStats { get; set; }

        public Item(string name, string imagePath, Stats stats)
        {
            Name = name;
            ImagePath = imagePath;
            ItemStats = stats;
        }
    }
}
