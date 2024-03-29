namespace Exercicio01_Estruturas_de_decisao
    //Verificar se a soma de A + B é menor que C.

//Exemplo de entrada: A = 5, B = 3, C = 10
//Exemplo de saída: A + B é menor que C.
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                double A, B, C;
                Console.WriteLine("Digite o valor de A");
                A = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor de B");
                B = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor de C");
                C = Convert.ToDouble(Console.ReadLine());

               if (A + B < C)
                {
                    Console.WriteLine("A soma dos valores é menor que C.");
                }
                else
                {
                    Console.WriteLine("A soma dos valores não é menor que C");
                }

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
