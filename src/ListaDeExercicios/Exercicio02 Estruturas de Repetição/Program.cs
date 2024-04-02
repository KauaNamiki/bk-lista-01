namespace Exercicio02_Estruturas_de_Repetição
{
    internal class Program
    {
        static void Main(string[] args)

        {
            bool running = true;
            while (running)
            {
                Console.Write("Digite um número inteiro positivo: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("O número deve ser positivo.");
                    return;
                }

                long fatorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    fatorial *= i;
                }


                Console.WriteLine($"{numero}! = {fatorial}");
            }
        }
    }
}
