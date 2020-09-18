﻿using System;
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
        #region Globals
        Player player = new Player();
        ItemList itemDatalogue = new ItemList();

        #endregion

        #region Run Processes

        public void Start() // Starts the game process
        {
            InitializeGameData();
            while (true)
            {
                Run();
            }
        }
        private void Run() // Loop when running
        {
            SwitchMenu();
        }
        public void End()
        {
            Environment.Exit(0);
        }
        #endregion

        #region Initializations
        private void InitializeGameData() // Sets all the variables 
        {
            itemDatalogue.Initialize();
        }
        private void InitializePlayerData()
        {
            player.Initialize(itemDatalogue);
        }
        #endregion

        #region Menus
        private void SwitchMenu()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("[1] Start\n[2] Load\n[3] Settings\n[Q] Exit");
                var input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        InitializePlayerData();
                        IngameMainScreen();
                        break;
                    case ConsoleKey.Q:
                        End();
                        break;
                }
                Console.Clear();
            }

        }

        private void IngameMainScreen()
        {
            Console.Clear();
            bool isBackingOut = false;
            while (true)
            {
                Console.WriteLine("[1] Adventure\n[2] Profile\n[3] Town\n[4] Settings\n[Q] Exit");
                var input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.Q:
                        isBackingOut = true;
                        break;
                }

                if (isBackingOut == true)
                {
                    SaveGameData();
                    break;
                }
                Console.Clear();
            }
        }

        private void ProfileMenu()
        {
            Console.Clear();
            bool isBackingOut = false;
        }
        #endregion

        #region Private Practices
        private void SaveGameData()
        { 
        
        }
        #endregion
    }
}
