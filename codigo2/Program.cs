using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("GERADOR DE SENHA");
        Console.WriteLine("Qual a quantidade de dígitos que você deseja?");

        if (int.TryParse(Console.ReadLine(), out int quantidade_d )&& quantidade_d > 0)
        {
            Console.WriteLine("Incluir números S/N?");
            string numero = Console.ReadLine()?.ToUpper();

            while (numero != "S" && numero != "N")
            {
                Console.WriteLine("ERRO! Escolha S ou N.");
                Console.WriteLine("Incluir números S/N?");
                numero = Console.ReadLine()?.ToUpper();
            }
            if (numero == "S")
            {
                Console.WriteLine("Você escolheu incluir números.");
            }
            if (numero == "N")
            {
                Console.WriteLine("Você escolheu não incluir números.");
            }

           
            Console.WriteLine("Incluir símbolos S/N?");
            string simbolo = Console.ReadLine()?.ToUpper();
            while (simbolo != "S" && simbolo != "N")
            {
                Console.WriteLine("ERRO! Escolha S ou N.");
                Console.WriteLine("Incluir símbolos S/N?");
                simbolo = Console.ReadLine()?.ToUpper();
            }
            if (simbolo == "S")
            {
                Console.WriteLine("Você escolheu incluir símbolos.");
            }
            if (simbolo == "N")
            {
                Console.WriteLine("Você escolheu não incluir símbolos.");
            }

            
            Console.WriteLine("Incluir letras maiúsculas S/N?");
            string Letras_ma = Console.ReadLine()?.ToUpper();
            while (Letras_ma != "S" && Letras_ma != "N")
            {
                Console.WriteLine("ERRO! Escolha S ou N.");
                Console.WriteLine("Incluir letras maiúsculas S/N?");
                Letras_ma = Console.ReadLine()?.ToUpper();
            }
            if (Letras_ma == "S")
            {
                Console.WriteLine("Você escolheu incluir letras maiúsculas.");
            }
            if (Letras_ma == "N")
            {
                Console.WriteLine("Você escolheu não incluir letras maiúsculas.");
            }

            
            Console.WriteLine("Incluir letras minúsculas S/N?");
            string Letras_mi = Console.ReadLine()?.ToUpper();
            while (Letras_mi != "S" && Letras_mi != "N")
            {
                Console.WriteLine("ERRO! Escolha S ou N.");
                Console.WriteLine("Incluir letras minúsculas S/N?");
                Letras_mi = Console.ReadLine()?.ToUpper();
            }
            if (Letras_mi == "S")
            {
                Console.WriteLine("Você escolheu incluir letras minúsculas.");
            }
            if (Letras_mi == "N")
            {
                Console.WriteLine("Você escolheu não incluir letras minúsculas.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida! Por favor, insira um número para a quantidade de dígitos.");
        }
    }
}
