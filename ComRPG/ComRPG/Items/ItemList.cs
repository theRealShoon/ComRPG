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
        
        }
        private void CreateRings()
        { 
        
        }
        private void CreateChestplates()
        { 
        
        }
        private void CreateGloves()
        { 
        
        }
        private void CreateLeggings()
        { 
        
        }
        private void CreateBoots()
        { 
        
        }
        private void CreateWeapons()
        { 
            
        }
    }
}
