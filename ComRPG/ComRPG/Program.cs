using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ComRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
        }
    }
}
