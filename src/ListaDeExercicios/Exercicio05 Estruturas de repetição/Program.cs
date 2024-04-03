namespace Exercicio05_Estruturas_de_repetição
//Exibir a tabuada de multiplicação do 1 ao 10.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {

                for (int multiplicando = 1; multiplicando <= 10; multiplicando++)
                {
           
                    Console.WriteLine($"{multiplicador} x {multiplicando} = {multiplicador * multiplicando}");
                }


                Console.WriteLine();
            }
    }
}}
