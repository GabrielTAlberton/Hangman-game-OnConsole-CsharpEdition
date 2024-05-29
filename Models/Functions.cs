using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman_game_OnConsole_CsharpEdition.Models
{
    public class Functions
    {
        private List<string> ListaFrutas  { get; }
        private List<string> DisplayOcultoPalavraSecreta { get; set; }
        private string PalavraSecreta { get; set;}
        private int QuantidadeVidasRestantes { get; }

         public Functions()
         {
            ListaFrutas = new List<string> {"Abacaxi", "Abacate", "Açaí", "Ameixa", "Banana", "Caju", "Carambola", "Caqui", 
            "Cereja", "Coco",  "Goiaba", "Grapo", "Jabuticaba", "Kiwi", "Laranja", "Limão", "Maçã", "Mamão", "Manga", 
            "Maracujá", "Melancia",  "Melão", "Morango", "Pera", "Pêssego", "Pitanga", "Tangerina", "Uva", "Jaca", "Figo", 
            "Amora", "Mirtilo", "Framboesa", "Pêssego", "Romã", "Papaia", "Acerola", "Ameixa", "Pêssego", "Pitaya", "Cereja", 
            "Graviola", "Tamarindo", "Tâmara", "Nêspera", "Jambo", "Lichia"};
         }

         public void ObterPalavraSecreta()
         {
            Random randomizador = new Random();
            int indiceAleatorio = randomizador.Next(0, ListaFrutas.Count);
            PalavraSecreta = ListaFrutas[indiceAleatorio];
            Console.WriteLine(PalavraSecreta);
            
            
         }
         

        public void ChecarPalpite()
        {
            
        }   

        public void ObterPalpite()
        {
            Console.WriteLine("Tente advinharDigite uma letra: \n");
            string palpite = Console.ReadLine().ToLower();
        }
    }
}