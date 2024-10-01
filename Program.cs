using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Software de validação de senha
        Console.Write("Digite uma senha: ");
        string senha = Console.ReadLine();
        
        Console.Write("\nConfirme a senha: ");
        string confirmaSenha = Console.ReadLine();
        
        // Validação das senhas
        bool senhaValida = ValidarSenha(senha);
        bool confirmaSenhaValida = ValidarSenha(confirmaSenha);
        
        // Testa se as senhas são válidas
        if (senhaValida)
        {
            Console.WriteLine("Senha Valida!");
        }
        else
        {
            Console.WriteLine("Senha Invalida!");
        }

        // Testa se a confirmação de senha é válida
        if (confirmaSenhaValida)
        {
            Console.WriteLine("Confirmacao de Senha Valida!");
        }
        else
        {
            Console.WriteLine("Confirmacao de Senha Invalida!");
        }

        // Verifica se as senhas conferem
        if (senha == confirmaSenha)
        {
            Console.WriteLine("Senhas conferem!");
        }
        else
        {
            Console.WriteLine("Senhas nao conferem!");
        }
    }

    private static bool ValidarSenha(string senha)
    {
        // Faz a validação da senha
        bool tamanhoValido = senha.Length >= 8;
        bool contemNumero = senha.Any(char.IsDigit);
        bool contemMaiuscula = senha.Any(char.IsUpper);
        
        return tamanhoValido && contemNumero && contemMaiuscula;
    }
}
