using System;
using System.Collections.Generic;
using System.Text;
using ComRPG.Items;
using ComRPG.Items.Armors;
using ComRPG.Items.Weapons;

namespace ComRPG
{
    class Player
    {
        public string name { get; set; } // Stores the name for the player

        //Armor
        public Helmet helmet { get; set; }
        Amulet amulet { get; set; }
        Chestplate chestplate { get; set; }
        Gloves gloves { get; set; }
        Ring ringOne { get; set; }
        Ring ringTwo { get; set; }
        Leggings leggings { get; set; }
        Boots boots { get; set; }

        //Weapon
        public Weapon weapon { get; set; }

        //Stats
        public double hpCurrent { get; set; }
        public double hpMax { get; set; }
        //Methods
        public void Initialize(ItemList itemDatalogue)
        {
            InitializeArmors(itemDatalogue);
            InitializeWeapons(itemDatalogue);
            InitializeStats();
        }
        private void InitializeArmors(ItemList itemDatalogue)
        {
            helmet = itemDatalogue.helmetList[0];
            amulet = itemDatalogue.amuletList[0];
            chestplate = itemDatalogue.chestplateList[0];
            gloves = null;
            ringOne = null;
            ringTwo = null;
            leggings = null;
            boots = null;
        }
        private void InitializeWeapons(ItemList itemDatalogue)
        {
            weapon = itemDatalogue.weaponList[0];
        }
        private void InitializeStats()
        {
            hpCurrent = 50;
            hpMax = 50;
        }
    }
}
