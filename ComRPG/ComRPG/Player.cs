using System;
using System.Collections.Generic;
using System.Text;
using ComRPG.Items.Armors;
using ComRPG.Items.Weapons;

namespace ComRPG
{
    class Player
    {
        public string name { get; set; } // Stores the name for the player

        //Armor
        Helmet helmet { get; set; }
        Amulet amulet { get; set; }
        Chestplate chestplate { get; set; }
        Gloves gloves { get; set; }
        Ring ringOne { get; set; }
        Ring ringTwo { get; set; }
        Leggings leggings { get; set; }
        Boots boots { get; set; }

        //Weapon
        Weapon weapon { get; set; }

        //Stats
        public double hpCurrent { get; set; }
        public double hpMax { get; set; }
        //Methods
        public void Initialize()
        {
            InitializeArmors();
            InitializeWeapons();
            InitializeStats();
        }
        private void InitializeArmors()
        {
            helmet = null;
            amulet = null;
            chestplate = null;
            gloves = null;
            ringOne = null;
            ringTwo = null;
            leggings = null;
            boots = null;
        }
        private void InitializeWeapons()
        {
            weapon = null;
        }
        private void InitializeStats()
        {
            hpCurrent = 50;
            hpMax = 50;
        }
    }
}
