using System.Runtime.Serialization;

namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A:");
            string a = Console.ReadLine();
            Console.WriteLine("Digite o valor de B:");
            string b = Console.ReadLine();
            Console.WriteLine("Digite o valor de C:");
            string c = Console.ReadLine();
            int ai=Convert.ToInt32(a);
            int bi=Convert.ToInt32(b);
            int ci= Convert.ToInt32(c);
            int soma = ai + bi;
            if(soma<ci)
            {
                Console.WriteLine("C é maior que o valor de A+B.");

            }
            Console.WriteLine("O valor da soma de A+B é "+soma);
            
            Console.ReadLine();
       
        
        
        }
    }
}
