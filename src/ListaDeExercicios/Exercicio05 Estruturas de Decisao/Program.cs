namespace Exercicio05_Estruturas_de_Decisao
//Realizar uma operação com base em dois valores inteiros A e B.

//Exemplo de entrada: A = 3, B = 3
//Exemplo de saída: A + B = 6.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Write("Digite o valor de A: ");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o valor de B: ");
                int B = Convert.ToInt32(Console.ReadLine());

                int resultado = A + B;

                Console.WriteLine($"A + B = {resultado}");
            }
        }
    }
}
      
    
