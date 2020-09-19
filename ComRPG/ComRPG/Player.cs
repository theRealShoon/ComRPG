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

        //Inventories
        public List<Helmet> helmetInventory = new List<Helmet>();
        public List<Amulet> amuletInventory = new List<Amulet>();
        public List<Chestplate> chestplateInventory = new List<Chestplate>();
        public List<Gloves> glovesInventory = new List<Gloves>();
        public List<Ring> ringInventory = new List<Ring>();
        public List<Leggings> leggingsInventory = new List<Leggings>();
        public List<Boots> bootsInventory = new List<Boots>();

        //Stats
        public double hpCurrent { get; set; }
        public double hpMax { get; set; }
        public double lvl { get; set; }
        public double exp { get; set; }
        public double attack { get; set; }
        public double defense { get; set; }
        public double magic { get; set; }
        public double magicDefense { get; set; }
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
        public void ShowStats()
        { 
        
        }
    }
}
