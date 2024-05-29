using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman_game_OnConsole_CsharpEdition.Models
{
    public class Functions
    {
        private List<string> ListaFrutas  { get; }
        private List<string> DisplayOcultoLista { get; set; }
        private string PalavraSecreta { get; set;}
        private string DisplayOcultoString { get; set;}
        private int QuantidadeVidasRestantes { get; }

        public string Palpite { get; set; }

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
            PalavraSecreta = ListaFrutas[randomizador.Next(0, ListaFrutas.Count)];
         }

         public void MontarDisplaySecreto()
         {
            DisplayOcultoLista = new List<string>();
            foreach (char letra in PalavraSecreta)
            {
                DisplayOcultoLista.Add("_");
                DisplayOcultoLista.Add(" ");
            }

            DisplayOcultoString = string.Join("", DisplayOcultoLista);
         }    

        public void ChecarPalpite()
        {
            if (PalavraSecreta.Contains(Palpite))
            {
                
            }
        }   

        public string ObterPalpite()
        {
            Console.WriteLine("Tente advinharDigite uma letra: \n");
            return Palpite = Console.ReadLine().ToLower();
        }
    }
}