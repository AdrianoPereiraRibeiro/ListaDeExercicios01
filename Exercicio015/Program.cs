namespace Exercicio015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em celsius:");
            string c = Console.ReadLine();
            int c1 = Convert.ToInt32(c);
            int resultado = (((9) * c1) / 5) + 32;
            Console.WriteLine("Essa temperatura em Fahrenheit é igual a " + resultado);
            Console.ReadLine();
            
        }
    }
}
