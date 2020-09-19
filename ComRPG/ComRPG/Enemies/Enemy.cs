using ComRPG.Items.Armors;
using ComRPG.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;


namespace ComRPG.Enemies
{
    class Enemy
    {
        public string name { get; set; }
        public string description { get; set; }
        public double hp { get; set; }
        public double hpMax { get; set; }
        public double attack { get; set; }
        public double defense { get; set; }
        public List<Weapon> weaponDrops = new List<Weapon>();
        public List<Helmet> helmetDrops = new List<Helmet>();
        public List<Amulet> amuletDrops = new List<Amulet>();
        public List<Chestplate> chestplateDrops = new List<Chestplate>();
        public List<Gloves> gloveDrops = new List<Gloves>();
        public List<Ring> ringDrops = new List<Ring>();
        public List<Leggings> leggingDrops = new List<Leggings>();
        public List<Boots> bootsDrops = new List<Boots>();
    }
}
