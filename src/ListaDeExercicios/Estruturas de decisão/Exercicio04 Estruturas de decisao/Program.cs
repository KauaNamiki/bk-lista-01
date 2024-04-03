namespace Exercicio04_Estruturas_de_decisao
 //   Identificar se um número é par ou ímpar.

//Exemplo de entrada: Número = 7
//Exemplo de saída: O número é ímpar.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                double Num1;

                Console.WriteLine("Digite o numero:");
                Num1 = Convert.ToDouble(Console.ReadLine());

                string result = Num1 % 2 == 0 ? "O numero é par" : "O numero é impar";

                Console.WriteLine(result);
                

            }


        }
    }
}
