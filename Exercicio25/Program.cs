namespace Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            string na = Console.ReadLine();
            int v = Convert.ToInt32(na);
            int n1 = v; 
            Console.WriteLine("0x" + na +" é igual a "+n1 * 0);
            Console.WriteLine("1x" + na +" é igual a "+n1 * 1);
            Console.WriteLine("2x" + na +" é igual a "+n1 * 2);
            Console.WriteLine("3x" + na +" é igual a "+n1 * 3);
            Console.WriteLine("4x" + na +" é igual a "+n1 * 4);
            Console.WriteLine("5x" + na +" é igual a "+n1 * 5);
            Console.WriteLine("6x" + na +" é igual a "+n1 * 6);
            Console.WriteLine("7x" + na +" é igual a "+n1 * 7);
            Console.WriteLine("8x" + na +" é igual a "+n1 * 8);
            Console.WriteLine("9x" + na +" é igual a "+n1 * 9);
            Console.WriteLine("10x" + na + " é igual a " + n1 * 10);
            Console.ReadLine();




        }
    }
}
