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
        List<Helmet> helmetList = new List<Helmet>();
        List<Amulet> amuletList = new List<Amulet>();
        List<Ring> ringList = new List<Ring>();
        List<Chestplate> chestplateList = new List<Chestplate>();
        List<Gloves> gloveList = new List<Gloves>();
        List<Leggings> leggingList = new List<Leggings>();
        List<Boots> bootsList = new List<Boots>();

        //Weapons
        List<Weapon> weaponList = new List<Weapon>();

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
