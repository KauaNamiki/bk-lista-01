namespace Exercicio03_Estruturas_de_Decisão
//Calcular o Índice de Massa Corporal (IMC) e determinar a condição de peso de um adulto.

//Exemplo de entrada: Peso = 70 kg, Altura = 1.75 m
//Fórmula: IMC = Peso / (Altura^2)
//Exemplo de saída: IMC = 22.86 (Peso normal).

{
    internal class Program
    {
        static void Main()
        {
            bool running = true;
            while (running)
            {
                double Peso, Alt, IMC;

                Console.WriteLine("Digite o peso:");
                Peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a Altura:");
                Alt = Convert.ToDouble(Console.ReadLine());

                IMC = Peso / (Alt * Alt);
                

                string condiçao = IMC < 18.5 ? "abaixo do peso" : IMC < 25 ? "peso normal" : "acima do peso";

                Console.WriteLine($"IMC = {IMC} ({condiçao}). ");

            }              
        }
    }  
}
