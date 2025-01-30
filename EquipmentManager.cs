using System.Collections.Generic;

namespace porjekt
{
    public class EquipmentManager
    {
        public List<Equipment> Helmets { get; } = new List<Equipment>();
        public List<Equipment> Chestplates { get; } = new List<Equipment>();
        public List<Equipment> Pants { get; } = new List<Equipment>();
        public List<Equipment> Boots { get; } = new List<Equipment>();
        public List<Equipment> Weapons { get; } = new List<Equipment>();

        public EquipmentManager()
        {
            // Příklad vybavení
            Helmets.Add(new Equipment("Iron Helmet", "Images/ironHelmet.png", 2, 0, 4));
            Helmets.Add(new Equipment("Diamond Helmet", "Images/diaHelma.png", 4, 0, 3));
            Helmets.Add(new Equipment("nic", "", 0, 0, 0));

            Chestplates.Add(new Equipment("Iron Chestplate", "Images/ironChest.png", 5, 0, 3));
            Chestplates.Add(new Equipment("Diamond Chestplate", "Images/diaChest.png", 8, 0, 1));
            Chestplates.Add(new Equipment("nic", "", 0, 0, 0));

            Pants.Add(new Equipment("Iron Pants", "Images/ironNohy.png", 3, 0, 4));
            Pants.Add(new Equipment("Diamond Pants", "Images/diaNohy.png", 5, 0, 2));
            Pants.Add(new Equipment("nic", "", 0, 0, 0));

            Boots.Add(new Equipment("Iron Boots", "Images/ironBoty.png", 2, 0, 4));
            Boots.Add(new Equipment("Diamond Boots", "Images/diaBoty.png", 3, 0, 3));
            Boots.Add(new Equipment("nic", "", 0, 0, 0));

            Weapons.Add(new Equipment("Zweihander", "Images/zweihander.png", 0, 18, 0));
            Weapons.Add(new Equipment("AK-47", "Images/ak.png", 0, 12, 0));
            Weapons.Add(new Equipment("AK-47", "Images/sydney.png", 0, 99, 0));
            Weapons.Add(new Equipment("AK-47", "Images/blades.png", 0, 23, 0));
            Weapons.Add(new Equipment("AK-47", "Images/leviathan.png", 0, 22, 0));
            Weapons.Add(new Equipment("nic", "", 0, 0, 0));
        }
    }
}
