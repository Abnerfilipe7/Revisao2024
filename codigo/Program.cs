using System.IO;
	{
        using (StreamWriter escrever = new StreamWriter("bkp.TXT"))
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Bem-vindo ao gerador de senha!");
        Console.WriteLine("Insira a quantidade de dígitos da senha:");

        if (int.TryParse(Console.ReadLine(), out int q_digito) && q_digito > 0)
        {
            Console.WriteLine("Apenas números? (S/N)");
            string resposta = Console.ReadLine()?.Trim().ToUpper();

            switch (resposta)
            {
                case "S":
                    Console.WriteLine($"Senha gerada: {GerarSenha(q_digito, somenteNumeros: true)}");
                    break;
                case "N":
                    Console.WriteLine($"Senha gerada: {GerarSenha(q_digito, somenteNumeros: false)}");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, responda com 'S' ou 'N'.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("ERRO: Por favor, insira um número válido maior que zero.");
        }
    }

    static string GerarSenha(int comprimento, bool somenteNumeros)
    {
        string caracteres = somenteNumeros ? "0123456789" : "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#$!*";
        Random random = new Random();
        char[] senha = new char[comprimento];

        for (int i = 0; i < comprimento; i++)
        {
            senha[i] = caracteres[random.Next(caracteres.Length)];
        }
             
    		
        
        return new string(senha);
        
       
    }


