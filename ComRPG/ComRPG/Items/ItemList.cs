using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ComRPG.Items.Armors;
using ComRPG.Items.Weapons;

namespace ComRPG.Items
{
    class ItemList
    {
        //Armors
        public List<Helmet> helmetList = new List<Helmet>();
        public List<Amulet> amuletList = new List<Amulet>();
        public List<Ring> ringList = new List<Ring>();
        public List<Chestplate> chestplateList = new List<Chestplate>();
        public List<Gloves> gloveList = new List<Gloves>();
        public List<Leggings> leggingList = new List<Leggings>();
        public List<Boots> bootsList = new List<Boots>();

        //Weapons
        public List<Weapon> weaponList = new List<Weapon>();

        public void Initialize()
        {
            CreateHelmets();
            CreateAmulets();
            CreateRings();
            CreateChestplates();
            CreateGloves();
            CreateLeggings();
            CreateBoots();
            CreateWeapons();
        }
        private void CreateHelmets()
        {
            //
            Helmet newHelmet = new Helmet();
            newHelmet.name = "Nothing";
            newHelmet.description = "Why are you looking at the stats for an item named nothing";
            newHelmet.defense = 0;
            helmetList.Add(newHelmet);
            // Taffy Set
            newHelmet = new Helmet();
            newHelmet.name = "Taffy's tin foil helmet";
            newHelmet.description = "Mans is crazy; Don't catch it";
            newHelmet.defense = 0;
            helmetList.Add(newHelmet);
            // Ender Set
            newHelmet = new Helmet();
            newHelmet.name = "Enders Hood";
            newHelmet.description = "A hood that gives you the apperance of your long lost father";
            newHelmet.defense = 15;
            helmetList.Add(newHelmet);
        }
        private void CreateAmulets()
        {
            Amulet newAmulet = new Amulet();
            newAmulet.name = "Nothing";
            newAmulet.description = "You've been crazy thinking that your neck was an amulet";
            amuletList.Add(newAmulet);
            //
            newAmulet = new Amulet();
            newAmulet.name = "Taffy's tin can on a string";
            newAmulet.description = "You'd be surprised with the power a tin can holds";
            newAmulet.defense = 5;
            newAmulet.magic = 100;
            amuletList.Add(newAmulet);
            //
            newAmulet = new Amulet();
            newAmulet.name = "Ender's Pearls";
            newAmulet.defense = 5;
            newAmulet.description = "Haha funny minecraft reference";
            newAmulet.magic = 25;
            amuletList.Add(newAmulet);

        }
        private void CreateRings()
        {
            Ring newRing = new Ring();
            newRing.name = "Nothing";
            newRing.description = "Why are you looking at the stats for an item named nothing";
            newRing.defense = 0;
            newRing.magic = 0;
            ringList.Add(newRing);
            //
            newRing = new Ring();
            newRing.name = "Taffy's Extra Sticky ring";
            newRing.description = "Might as well remove your hand";
            newRing.defense = 35;
            newRing.magic = 0;
            ringList.Add(newRing);
            //
            newRing = new Ring();
            newRing.name = "Ender's ring";
            newRing.description = "Ender got this at a thrift store and named it after himself";
            newRing.defense = 20;
            newRing.magic = 10;
            ringList.Add(newRing);
        }
        private void CreateChestplates()
        {
            Chestplate newChestplate = new Chestplate();
            newChestplate.name = "Nothing";
            newChestplate.description = "You got no shirt mate";
            newChestplate.defense = 0;
            chestplateList.Add(newChestplate);
            //
            newChestplate = new Chestplate();
            newChestplate.name = "Ender's Cloak";
            newChestplate.description = "Easily can poke holes through";
            newChestplate.defense = 3;
            chestplateList.Add(newChestplate);
            //
            newChestplate = new Chestplate();
            newChestplate.name = "Taffy's star chestplate";
            newChestplate.description = "A fine linen cloth crafted by the hands of a bound eastern man";
            newChestplate.defense = 15;
            chestplateList.Add(newChestplate);
        }
        private void CreateGloves()
        {
            Gloves newGloves = new Gloves();
            newGloves.name = "Nothing";
            newGloves.description = "Look at you, naked hands";
            newGloves.defense = 0;
            gloveList.Add(newGloves);
            //
            newGloves = new Gloves();
            newGloves.name = "Mood Glove";
            newGloves.description = "A glove that changes colors depending on your mood";
            newGloves.defense = 5;
            gloveList.Add(newGloves);
            //
        }
        private void CreateLeggings()
        {
            Leggings newLeggings = new Leggings();
            newLeggings.name = "Nothing";
            newLeggings.description = ":flushed:";
            newLeggings.defense = 0;
            leggingList.Add(newLeggings);
            //
            newLeggings = new Leggings();
            newLeggings.name = "Taffy's Husky Jeans";
            newLeggings.description = "Big pants for a big boy";
            newLeggings.defense = 40;
            leggingList.Add(newLeggings);
            //
            newLeggings = new Leggings();
            newLeggings.name = "Bean bag pants";
            newLeggings.description = "Pants and a bean bag at the same time!  Now try getting out these";
            newLeggings.defense = -3;
            leggingList.Add(newLeggings);
        }
        private void CreateBoots()
        {
            Boots newBoots = new Boots();
            newBoots.name = "Nothing";
            newBoots.defense = 0;
            bootsList.Add(newBoots);
            //
            newBoots = new Boots();
            newBoots.name = "Enders Timbs";
            newBoots.description = "Surprisingly silent";
            newBoots.defense = 35;
            bootsList.Add(newBoots);
            //
            newBoots = new Boots();
            newBoots.name = "Chancleta";
            newBoots.description = "The mightiest protection in the world; A quién le estás diciendo shut up to?";
            newBoots.defense = 75;
            bootsList.Add(newBoots);
            //
        }
        private void CreateWeapons()
        {
            Weapon newWeapon = new Weapon
            {
                name = "Nothing",
                weaponType = Convert.ToInt32(WeaponTypes.Nothing),
                description = "Your weak fists",
                attack = 5,
                defense = 0,
            };
            weaponList.Add(newWeapon);
            newWeapon = new Weapon
            {
                name = "A toaster oven",
                weaponType = Convert.ToInt32(WeaponTypes.HouseholdSupplies),
                description = "Your mother's new toaster oven",
                attack = 35,
                defense = 10,
            };
            weaponList.Add(newWeapon);
        }
    }
}
