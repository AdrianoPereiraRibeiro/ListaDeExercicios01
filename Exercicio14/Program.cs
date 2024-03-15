using System.Diagnostics;

namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome= Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            string idade = Console.ReadLine();
            int idadi= Convert .ToInt32(idade);
            int dias = idadi * 365;
            Console.WriteLine("Olá " + nome + ", você viveu " + dias + " dias.");
            Console.ReadLine();
        
        
        
        
        }
    }
}
