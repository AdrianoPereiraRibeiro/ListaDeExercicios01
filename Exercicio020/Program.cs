namespace Exercicio020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
           string n1= Console.ReadLine();
            decimal n11= Convert.ToDecimal(n1);
            if( n11 %2 == 0 ) {
                Console.WriteLine("Esse número é par.");
            }
            else if( n11 %2 != 0 ) { 
            Console.WriteLine("Esse número é impar.");
            }
            Console.ReadLine();

        }
    }
}
