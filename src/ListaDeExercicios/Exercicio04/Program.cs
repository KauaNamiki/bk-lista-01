namespace Exercicio04
{
    //Calcular o salário total de um vendedor.

    //Exemplo de entrada: Salário base = R$ 1500, Total de vendas = R$ 5000, Comissão(5% sobre as vendas)
    //Fórmula: Salário total = Salário base + (Total de vendas * Comissão)
    //Exemplo de saída: O salário total do vendedor é R$ 1750.
    class Program
    {
        static void Main()
        {
            while (true)
            {
                double SalárioBase, TotalDeVendas, Comissão, SalárioTotal;

                Console.WriteLine("Digite o valor do salário base:");
                SalárioBase = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o total de vendas:");
                TotalDeVendas = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a comissão do vendedor em decimal (por exemplo, 0,05 para 5%):");
                Comissão = Convert.ToDouble(Console.ReadLine());

                SalárioTotal = SalárioBase + (TotalDeVendas * Comissão);

                Console.WriteLine($"O salário total do vendedor é R$ {SalárioTotal}");

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