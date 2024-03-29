namespace Exercicio02
/*
        * Converter a temperatura de graus Fahrenheit para graus Celsius
        */
{
    class Program

    {
        static void Main()
        {
            while (true)
            {
                double Fahrenheit, Celsius;

                Console.WriteLine("Digite a temperatura em graus Fahrenheit:");
                Fahrenheit = Convert.ToDouble(Console.ReadLine());

                Celsius = (Fahrenheit - 32) * 5 / 9;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"A temperatura em graus Celsius é {Celsius} graus");
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("0 = sair");
                Console.WriteLine("1 = Continuar");
                Console.ResetColor();
                if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 0 ||  opcao > 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opção inválida, por favor selecione uma opção válida! \n ");
                    continue;
                }
                if (opcao == 0)
                {
                    Console.WriteLine("Saindo");
                    break;
                }
                if (opcao == 1)
                {
                    continue;
                }

            }
        }
    }
}