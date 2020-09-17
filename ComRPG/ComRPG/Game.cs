using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ComRPG.Items;
using ComRPG.Items.Armors;
using ComRPG.Items.Weapons;


namespace ComRPG
{
    class Game
    {
        Player player = new Player();
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
            player.Initialize();
        }
        private void Run() // Loop when running
        {

        }
        private void SwitchMenu()
        { 
        
        }
    }
}
