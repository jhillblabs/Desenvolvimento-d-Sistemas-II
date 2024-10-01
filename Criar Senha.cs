using System;

public class CriarNumeroAleatorio
{
    static void Main()
    {
        // Cria uma instância da classe Random
        Random random = new Random();

        // Gera um número aleatório entre 0 (inclusive) e 10 (inclusivo)
        int numeroAleatorio = random.Next(0, 11);
    
        Console.WriteLine("Numero Aleatorio Gerado: " + numeroAleatorio);
        
        int tentativas = 3;
        bool acerto = false;
        
        for (int i = 0; i < tentativas; i++)
        {
            Console.Write("Digite seu palpite: ");
            string entrada = Console.ReadLine(); 

            // Verifica se a entrada é um número válido
            if (int.TryParse(entrada, out int palpite))
            {
                if (palpite == numeroAleatorio)
                {
                    Console.WriteLine("Parabens! Voce acertou o numero gerado.");
                    acerto = true; // atualiza o valor da "variavel" certo para true, onde significa que está correto!
                    break; // O Break sai do loop caso o palpite estiver certo.
                }
                else
                {
                    Console.WriteLine("Palpite incorreto. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Entrada invalida. Por favor, digite um numero.");
            }
        }
        
        if (!acerto)
        {
            Console.WriteLine($"Voce nao conseguiu adivinhar o numero. O numero correto era: {numeroAleatorio}");
        }
    }
}
