using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
        public List<Weapon> weaponInventory = new List<Weapon>();

        //Stats
        public double hpCurrent { get; set; }
        public double hpMax { get; set; }
        public double lvl { get; set; }
        public double exp { get; set; }
        public double money { get; set; }
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
            ResetStats();
            name = "Guest";
        }
        public void Rest()
        {
            double minRest = 0;
            double maxRest = hpMax / 2;

            int minConv = Convert.ToInt32(minRest);
            int maxConv = Convert.ToInt32(maxRest);


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
            lvl = 1;
            exp = 0;
            money = 100;
            attack = 3;
            defense = 0;
            magic = 0;
            magicDefense = 0;
        }
        public void ResetStats()
        {
            attack = 3;
            defense = 0;
            magic = 0;
            magicDefense = 0;
            AddArmorStats();
            AddWeaponStats();
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
            Console.WriteLine("[{0}]", name);
            Console.WriteLine("HP: {0}/{1}",hpCurrent,hpMax);
            Console.WriteLine("LVL: {0}",lvl);
            Console.WriteLine("EXP: {0}", exp);
            Console.WriteLine("\nPhysical Attack: {0}", attack);
            Console.WriteLine("Magical Attack: {0}", magic);
            Console.WriteLine("Physical Defense: {0}", defense);
            Console.WriteLine("Magical Defense: {0}", magicDefense);
        }
        private void AddArmorStats()
        {
            defense += helmet.defense;
            defense += amulet.defense;
            defense += chestplate.defense;
            defense += chestplate.defense;
            defense += ringOne.defense;
            defense += ringTwo.defense;
            defense += leggings.defense;
            defense += boots.defense;

            magic += amulet.magic;
            magic += ringOne.magic;
            magic += ringTwo.magic;

            magicDefense += amulet.magicDefense;
            magicDefense += ringOne.magicDefense;
            magicDefense += ringTwo.magicDefense;
        }
        private void AddWeaponStats()
        {
            magic += weapon.magicAttack;
            attack += weapon.attack;
            defense += weapon.defense;
            magicDefense += weapon.magicDefense;
        }
    }
}
