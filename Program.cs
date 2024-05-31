using Hangman_game_OnConsole_CsharpEdition.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Functions FuncoesJogo = new Functions();
        
        while (true)
        {
            if (FuncoesJogo.ChecarFimDeJogo())
            {
                break;
            }

            FuncoesJogo.ObterPalpite();
            FuncoesJogo.ChecarPalpite();
            



        }

        
    }
}