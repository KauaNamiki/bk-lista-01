namespace Exercicio01;
/*
      * 1. Calcular o volume de uma caixa retangular.
         - Exemplo de entrada: Altura = 5, Largura = 3, Comprimento = 2
         - Fórmula: Volume = Altura * Largura * Comprimento
         - Exemplo de saída: O volume da caixa é 30 unidades cúbicas.*/


class Program
{
    static void Main()
    {
        while (true)
        {
            double altura, largura, comprimento, volume;

            Console.WriteLine("Digite a altura da caixa:");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa:");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o comprimento da caixa:");
            comprimento = Convert.ToDouble(Console.ReadLine());

            volume = altura * largura * comprimento;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"O volume da caixa é {volume} unidades cubicas");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("0 = sair");
            Console.WriteLine("1 = Continuar");

            if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 0 || opcao > 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Opção inválida, por favor selecione uma opção válida! \n ");
                continue;
            }
            if (opcao == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed ;
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
