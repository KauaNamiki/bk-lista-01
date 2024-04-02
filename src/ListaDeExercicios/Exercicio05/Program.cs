namespace Exercicio05
{
    //Calcular a média ponderada de duas provas realizadas por um aluno.

    // Exemplo de entrada: Nota da primeira prova = 7, Peso da primeira prova = 0.4, Nota da segunda prova = 8, Peso da segunda prova = 0.6
    //Fórmula: Média ponderada = (Nota da primeira prova* Peso da primeira prova) + (Nota da segunda prova* Peso da segunda prova)
    //Exemplo de saída: A média ponderada do aluno é 7.6.
    class Program
    {
        static void Main()
        {
            bool running = true;
            while (running)
            {
                double Nota1, PesoNota1, Nota2, PesoNota2, MédiaPonderada;

                Console.WriteLine("Digite a nota da primeira prova:");
                Nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o peso da primeira prova:");
                PesoNota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a nota da segunda prova:");
                Nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o peso da segunda prova:");
                PesoNota2 = Convert.ToDouble(Console.ReadLine());
                MédiaPonderada = (Nota1 * PesoNota1) + (Nota2 * PesoNota2);

                Console.WriteLine($"A média ponderada do aluno é {MédiaPonderada}. ");

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





