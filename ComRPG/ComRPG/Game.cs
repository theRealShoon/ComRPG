using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ComRPG.Items;
using ComRPG.Items.Armors;
using ComRPG.Items.Weapons;


namespace ComRPG
{
    class Game
    {
        Player player = new Player();
        ItemList itemDatalogue = new ItemList();
        public void Start() // Starts the game process
        {
            Initialize();
            while (true)
            {
                Run();
            }
        }
        private void Initialize() // Sets all the variables 
        {
            itemDatalogue.Initialize();
            player.Initialize(itemDatalogue);
        }
        private void Run() // Loop when running
        {
            SwitchMenu();
        }
        private void SwitchMenu()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("[Q] Exit");
                var input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.Q:
                        End();
                        break;
                }
                Console.Clear();
            }
            
        }
        public void End()
        {
            Environment.Exit(0);
        }
    }
}
