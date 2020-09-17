using System;
using System.Collections.Generic;
using System.Text;

namespace ComRPG.Items.Weapons
{
    class Weapon
    {
        public int weaponType { get; set; }
        public string name { get; set; }
    }
    public enum WeaponTypes
    {
        Sword,
        SwordAndShield,
        ShortBow,
        LongBow,
        Pistol,
        MarksmanRifles,
        HouseholdSupplies,
        Nothing,
    }
}
