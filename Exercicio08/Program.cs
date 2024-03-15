namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o raio da lata:");
            string r = Console.ReadLine();
            Console.WriteLine("Informe a altura da lata:");
            string a = Console.ReadLine();
            int r1= Convert.ToInt32(r);
            int a1= Convert.ToInt32(a);
            int resultado = 3 * r1 * r1 * a1;
            Console.WriteLine("O volume da lata é aproximadamente "+ resultado);
            Console.ReadLine(); //ja tinha feito antes de apagarem hahaha.

        }
    }
}
