using System;
using System.Collections.Generic;
using System.Text;

namespace ComRPG.Items.Weapons
{
    class Weapon
    {
        int WeaponType { get; set; }
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
    }
}
