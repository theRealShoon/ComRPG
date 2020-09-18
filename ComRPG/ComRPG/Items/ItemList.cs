using System;
using System.Collections.Generic;
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
            newHelmet.description = ""
            newHelmet.defense = 0;
            helmetList.Add(newHelmet);
            // Taffy Set
            newHelmet = new Helmet();
            newHelmet.name = "Taffy's tin foil helmet";
            newHelmet.defense = 0;
            helmetList.Add(newHelmet);
            // Ender Set
            newHelmet = new Helmet();
            newHelmet.name = "Enders Hood";
            newHelmet.defense = 15;
            helmetList.Add(newHelmet);
        }
        private void CreateAmulets()
        {
            Amulet newAmulet = new Amulet();
            newAmulet.name = "Nothing";
            amuletList.Add(newAmulet);
            //
            newAmulet = new Amulet();
            newAmulet.name = "Taffy's tin can on a string";
            newAmulet.defense = 5;
            newAmulet.magic = 100;
            amuletList.Add(newAmulet);
            //
            newAmulet = new Amulet();
            newAmulet.name = "Ender's Pearls";
            newAmulet.defense = 5;
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
            newRing.defense = 35;
            newRing.description = "Might as well remove your hand";
            newRing.magic = 0;
            ringList.Add(newRing);
            //
            newRing = new Ring();
            newRing.name = "Ender's ring";
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
            newChestplate.description = "A fine linen cloth crafted by the hands of a fated eastern man";
            newChestplate.defense = 15;
            chestplateList.Add(newChestplate);
        }
        private void CreateGloves()
        {
            Gloves newGloves = new Gloves();
            newGloves.name = "Nothing";
            newGloves.defense = 0;
            gloveList.Add(newGloves);
        }
        private void CreateLeggings()
        {
            Leggings newLeggings = new Leggings();
            newLeggings.name = "Nothing";
            newLeggings.defense = 0;
            leggingList.Add(newLeggings);
        }
        private void CreateBoots()
        {
            Boots newBoots = new Boots();
            newBoots.name = "Nothing";
            newBoots.defense = 0;
            bootsList.Add(newBoots);
        }
        private void CreateWeapons()
        {
            Weapon newWeapon = new Weapon
            {
                name = "Nothing",
                weaponType = Convert.ToInt32(WeaponTypes.Nothing)
            };
            weaponList.Add(newWeapon);
        }
    }
}
