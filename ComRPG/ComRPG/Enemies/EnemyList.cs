using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ComRPG.Items.Armors;
using ComRPG.Items.Weapons;
using ComRPG.Items;

namespace ComRPG.Enemies
{
    class EnemyList
    {
        public List<Enemy> enemyList = new List<Enemy>();
        public void Initialize(ItemList itemDatalogue)
        {
            CreateEnemies();
        }
        private void CreateEnemies()
        {
            Enemy enemy = new Enemy();
            enemy.name = "Homeless Person";
            enemy.description = "A man that lost his home";
            enemy.lvl = 1;
            enemy.hp = 25;
            enemy.hpMax = 25;
        }
    }
}
