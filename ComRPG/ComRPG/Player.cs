using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
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
        public Amulet amulet { get; set; }
        public Chestplate chestplate { get; set; }
        public Gloves gloves { get; set; }
        public Ring ringOne { get; set; }
        public Ring ringTwo { get; set; }
        public Leggings leggings { get; set; }
        public Boots boots { get; set; }

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
            name = "Guest";
        }
        private void InitializeArmors(ItemList itemDatalogue)
        {
            helmet = itemDatalogue.helmetList[0];
            amulet = itemDatalogue.amuletList[0];
            chestplate = itemDatalogue.chestplateList[0];
            gloves = itemDatalogue.gloveList[0];
            ringOne = itemDatalogue.ringList[0];
            ringTwo = itemDatalogue.ringList[0];
            leggings = itemDatalogue.leggingList[0];
            boots = itemDatalogue.bootsList[0];
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
        public void ShowArmor()
        {
            Console.WriteLine("Helmet: {0}",helmet.name);
            Console.WriteLine("Amulet: {0}", amulet.name);
            Console.WriteLine("Chestplate: {0}", chestplate.name);
            Console.WriteLine("Gloves: {0}", gloves.name);
            Console.WriteLine("Ring One: {0}", ringOne.name);
            Console.WriteLine("Ring Two: {0}", ringTwo.name);
            Console.WriteLine("Leggings: {0}", leggings.name);
            Console.WriteLine("Boots: {0}", boots.name);
        }
    }
}
