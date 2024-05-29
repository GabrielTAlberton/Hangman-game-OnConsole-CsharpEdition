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
            ObterPalavraSecreta();
            MontarDisplaySecreto();
         }

         public void ObterPalavraSecreta()
         {
            Random randomizador = new Random();
            PalavraSecreta = ListaFrutas[randomizador.Next(0, ListaFrutas.Count)].ToLower();
            Console.WriteLine($"palavra secreta = {PalavraSecreta}");
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
            Console.WriteLine($"displayocultostring = {DisplayOcultoString}");
         }    

        public void ChecarPalpite()
        {
            if (PalavraSecreta.Contains(Palpite))
            {

                PalpiteCorreto();
                DisplayOcultoString = string.Join("", DisplayOcultoLista);
                Console.WriteLine(DisplayOcultoString);

            }
        }   

        public void PalpiteCorreto()
        {
            char palpiteCharHolder = Convert.ToChar(Palpite);
            for (int indexador = 0; indexador < PalavraSecreta.Length; indexador++)
            {
                char letraPalavraSecreta = PalavraSecreta[indexador];

                if (DisplayOcultoLista[indexador] == " ")
                {
                    continue;
                    // TO-DO: criar lista sem os espacos em branco para executar esse metodo, manter a com espaco em branco para display somente
                }

                if (palpiteCharHolder == letraPalavraSecreta)
                {
                    DisplayOcultoLista[indexador+1] = Palpite;
                }
            }
        }

        public void ObterPalpite()
        {
            Console.WriteLine("Tente advinharDigite uma letra: ");
            Palpite = Console.ReadLine().ToLower();
        }
    }
}