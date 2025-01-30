using System.Collections.Generic;

namespace porjekt
{
    public class Character
    {
        public Equipment CurrentHelmet { get; private set; }
        public Equipment CurrentChestplate { get; private set; }
        public Equipment CurrentPants { get; private set; }
        public Equipment CurrentBoots { get; private set; }
        public Equipment CurrentWeapon { get; private set; }

        public int TotalDefense =>
            (CurrentHelmet?.Defense ?? 0) +
            (CurrentChestplate?.Defense ?? 0) +
            (CurrentPants?.Defense ?? 0) +
            (CurrentBoots?.Defense ?? 0);

        public int TotalAttack => CurrentWeapon?.Attack ?? 0;

        public int TotalSpeed =>
            10 - ((CurrentHelmet?.Speed ?? 0) +
                  (CurrentChestplate?.Speed ?? 0) +
                  (CurrentPants?.Speed ?? 0) +
                  (CurrentBoots?.Speed ?? 0));

        public void EquipHelmet(Equipment helmet) => CurrentHelmet = helmet;
        public void EquipChestplate(Equipment chestplate) => CurrentChestplate = chestplate;
        public void EquipPants(Equipment pants) => CurrentPants = pants;
        public void EquipBoots(Equipment boots) => CurrentBoots = boots;
        public void EquipWeapon(Equipment weapon) => CurrentWeapon = weapon;
    }
}
