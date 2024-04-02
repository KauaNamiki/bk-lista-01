namespace Exercicio06
//Calcular a área de um terreno retangular.

//exemplo de entrada: Comprimento do terreno = 10 metros, Largura do terreno = 5 metros
//Fórmula: Área = Comprimento * Largura
//Exemplo de saída: A área do terreno é 50 metros quadrados.
{
    class Program
    {
        static void Main()
        {
            bool running = true;
            while (running)
            {

                double Comprimento, Largura, Area;

                Console.WriteLine("Digite quantos metros de comprimento tem o seu terreno:");
                Comprimento = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a largura do seu terreno:");
                Largura = Convert.ToDouble(Console.ReadLine());

                Area = Comprimento * Largura;

                Console.WriteLine($"A área do seu terreno pe de {Area} metros quadrados");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("0 = sair");
                Console.WriteLine("1 = Continuar");
                Console.ResetColor();
                if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 0 || opcao > 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opção inválida, por favor selecione uma opção válida! \n ");
                    continue;
                }
                if (opcao == 0)
                {
                    Console.ResetColor();
                    Console.WriteLine("Saindo");
                    return;
                }
                if (opcao == 1)
                {
                    continue;


                }
            }
        }

    }
}
