using System.ComponentModel.Design;

namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso:");
            string peso = Console.ReadLine();
            Console.WriteLine("Digite sua altura:");
            string altura= Console.ReadLine();
            double pesoi=Convert.ToDouble(peso);
            double alturai=Convert.ToDouble(altura);
            double resultado = pesoi / Math.Pow(alturai, 2);
            Console.WriteLine("Seu imc é igual a "+resultado);
            if (resultado < 18.5) 
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if (resultado > 18.5 && resultado<25 ) 
            {
                Console.WriteLine("Você está com o peso ideal.");
            }
            else if (resultado > 25 && resultado < 30) 
            {
                Console.WriteLine("Você esta acima do peso.");
            }
            else if (resultado > 30) 
            {
                Console.WriteLine("Você está obeso.");
            }
           
            Console.ReadLine();
           
        
        }
    }
}
