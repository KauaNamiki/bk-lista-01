namespace Exercicio02_Estruturas_de_decisão
//Ordenar três valores inteiros e diferentes em ordem decrescente.

//Exemplo de entrada: 5, 10, 3
//Exemplo de saída: Os números em ordem decrescente são 10, 5, 3.
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                int A, B, C;
                Console.WriteLine("Digite o primeiro valor:");
                A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor:");
                B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o terceiro valor:");
                C = Convert.ToInt32(Console.ReadLine());

                if (A < B)
                {
                    int temp = A;

                    A = B;
                    B = temp;
                }

                if (A < C)
                {
                    int temp = A;
                    A = C;
                    C = temp;
                }

                if (B < C)
                {
                    int temp = B;
                    B = C;
                    C = temp;
                }

                Console.WriteLine($"Os números em ordem decrescente são {A}, {B}, {C}.");


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






