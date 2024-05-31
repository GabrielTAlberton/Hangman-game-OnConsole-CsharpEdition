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
        private int QuantidadeVidasRestantes { get; set; }

        public string Palpite { get; set; }

         public Functions()
         {
            ListaFrutas = new List<string> {"Abacaxi", "Abacate", "Açai", "Ameixa", "Banana", "Caju", "Carambola", "Caqui", 
            "Cereja", "Coco",  "Goiaba", "Grapo", "Jabuticaba", "Kiwi", "Laranja", "Limao", "Maca", "Mamao", "Manga", 
            "Maracuja", "Melancia",  "Melao", "Morango", "Pera", "Pessego", "Pitanga", "Tangerina", "Uva", "Jaca", "Figo", 
            "Amora", "Mirtilo", "Framboesa", "Pêssego", "Roma", "Papaia", "Acerola", "Ameixa", "Pitaya", "Cereja", 
            "Graviola", "Tamarindo", "Tamara", "Nespera", "Jambo", "Lichia"};
            ObterPalavraSecreta();
            MontarDisplaySecreto();
            QuantidadeVidasRestantes = 6;

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
            else
            {
                PalpiteErrado();
            }
        }   

        public void PalpiteCorreto()
        {
            char palpiteCharHolder = Convert.ToChar(Palpite);
            for (int indexador = 0; indexador < PalavraSecreta.Length; indexador++)
            {
                char letraPalavraSecreta = PalavraSecreta[indexador];

                if (palpiteCharHolder == letraPalavraSecreta)
                {
                    DisplayOcultoLista[indexador*2] = Palpite;
                }
            }
        }

        public void PalpiteErrado()
        {
            Console.WriteLine($"Errado! A palavra não possui a letra: {Palpite}");
            QuantidadeVidasRestantes--;
        }


        public void ObterPalpite()
        {
            Console.WriteLine($"Voce possui {QuantidadeVidasRestantes} tentativas restantes.");
            Console.WriteLine("Tente advinhar. Digite uma letra: ");
            Palpite = Console.ReadLine().ToLower();
        }

        public bool ChecarFimDeJogo()
        {
            if (!DisplayOcultoLista.Contains("_"))
            {
                Console.WriteLine($"Parabéns! Voce descobriu a palavra secreta: {PalavraSecreta}!");
                return true;
            }

            if (QuantidadeVidasRestantes == 0)
            {
                Console.WriteLine($"Que pena! Voce nao conseguiu descobrir a palavra secreta a tempo: {PalavraSecreta}.");
                return true;
            }

            return false;

        }
    }
}