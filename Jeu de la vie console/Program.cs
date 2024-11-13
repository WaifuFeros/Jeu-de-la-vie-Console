using System;

namespace Jeu_de_la_vie
{
    static class Program
    {
        static void Main()
        {
            Game game = new Game(4, 10);
            game.RunGameConsole();
        }
    }
}