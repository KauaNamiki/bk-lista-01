namespace Exercicio04_Estruturas_de_Repetição
//Substituir múltiplos de 3 pela palavra "Fizz" e múltiplos de 5 pela palavra "Buzz" na contagem de 1 a 100.

//Exemplo de saída: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, ...
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 100; i++)
            {
                string output = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" :
                                (i % 3 == 0) ? "Fizz" :
                                (i % 5 == 0) ? "Buzz" :
                                i.ToString();

                Console.Write(output);

    
                if (i < 100)
                {
                    Console.Write(", ");
                }
            }
            
        }
    }
}
