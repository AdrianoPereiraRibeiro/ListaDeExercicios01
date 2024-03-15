namespace Exercicio022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A:");
            string a = Console.ReadLine();
            Console.WriteLine("Digite o valor de B:");
            string b = Console.ReadLine();
            int ai = Convert.ToInt32(a);
            int bi = Convert.ToInt32(b);
            int c = ai+ bi;
            Console.WriteLine("A variavel C é igual a " + c);
            Console.ReadLine();


        }
    }
}
