namespace Exercicio03_Estruturas_de_repetição
   // Imprimir a sequência de Fibonacci até um número informado.

//Exemplo de entrada: Número = 50
//Exemplo de saída: Sequência de Fibonacci até 50: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.
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


                int a = 0;
                int b = 1;


                Console.Write("Sequência de Fibonacci até " + numero + ": " + a);


                while (b <= numero)
                {
                    Console.Write(", " + b);
                    int temp = a;
                    a = b;
                    b = temp + b;
                }

                Console.WriteLine();
            }
        }
    }
}
