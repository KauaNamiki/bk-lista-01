namespace Exercicio01_Estruturas_de_Repetição
    //Gerar e escrever os números ímpares entre 100 e 200.

//Exemplo de saída: 101, 103, 105, ..., 199.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
  
                for (int i = 101; i <= 199; i += 2)
                {
                    Console.Write(i);
            
                    if (i < 199)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
 }

