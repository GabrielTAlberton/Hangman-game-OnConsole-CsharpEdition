using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman_game_OnConsole_CsharpEdition.Models
{
    public class Functions
    {
        public void Guess()
        {
            Console.WriteLine("Digite uma letra: \n");
            string guess = Console.ReadLine();
            guess.ToLower();
        }
    }
}