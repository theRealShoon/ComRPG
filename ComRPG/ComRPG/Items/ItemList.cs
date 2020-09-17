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
            Helmet newHelmet = new Helmet();
            newHelmet.name = "Nothing";
            helmetList.Add(newHelmet);
        }
        private void CreateAmulets()
        {
            Amulet newAmulet = new Amulet();
            newAmulet.name = "Nothing";
            amuletList.Add(newAmulet);
        }
        private void CreateRings()
        {
            Ring newRing = new Ring();
            newRing.name = "Nothing";
            ringList.Add(newRing);
        }
        private void CreateChestplates()
        {
            Chestplate newChestplate = new Chestplate();
            newChestplate.name = "Nothing";
            chestplateList.Add(newChestplate);
        }
        private void CreateGloves()
        {
            Gloves newGloves = new Gloves();
            newGloves.name = "Nothing";
            gloveList.Add(newGloves);
        }
        private void CreateLeggings()
        {
            Leggings newLeggings = new Leggings();
            newLeggings.name = "Nothing";
            leggingList.Add(newLeggings);
        }
        private void CreateBoots()
        {
            Boots newBoots = new Boots();
            newBoots.name = "Nothing";
            bootsList.Add(newBoots);
        }
        private void CreateWeapons()
        {
            Weapon newWeapon = new Weapon();
            newWeapon.name = "Nothing";
            newWeapon.weaponType = Convert.ToInt32(WeaponTypes.Nothing);
            weaponList.Add(newWeapon);
        }
    }
}
