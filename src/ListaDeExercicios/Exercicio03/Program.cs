namespace Exercicio03
{
    //Calcular o consumo de combustível por quilômetro.

    //Exemplo de entrada: Quilometragem inicial = 100 km, Quilometragem final = 200 km, Consumo de combustível = 20 litros
    //Fórmula: Consumo por km = Consumo de combustível / (Quilometragem final - Quilometragem inicial)
    //Exemplo de saída: O consumo de combustível por quilômetro é de 0.1 litros/km.

    class Program
    {
        static void Main()
        {
            while (true)
            {
                double ConsumoPorKM, ConsumoDeCombustivel, QuilometragemFinal, QuilometragemInicial;

                Console.WriteLine("Digite a Quilometragem inicial:");
                QuilometragemInicial = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a Quilometragem final (deve ser maior que a quilometragem inicial):");
                QuilometragemFinal = Convert.ToDouble(Console.ReadLine());

                if (QuilometragemFinal < QuilometragemInicial)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("a Quilometragem final deve ser maior que a inicial!");
                    Console.ResetColor();
                    continue;

                }
                                                 

                Console.WriteLine("Digite o consumo de combustivel:");
                ConsumoDeCombustivel = Convert.ToDouble(Console.ReadLine());

                ConsumoPorKM = ConsumoDeCombustivel / (QuilometragemFinal - QuilometragemInicial);

                Console.WriteLine($"O consumo de combustível por quilômetro é de {ConsumoPorKM} litros");

                Console.ForegroundColor = ConsoleColor.Yellow;
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