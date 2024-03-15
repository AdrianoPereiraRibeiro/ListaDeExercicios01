namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota 1:");
            string n1=Console.ReadLine();
            Console.WriteLine("Digite o peso da nota 1:");
            string p1=Console.ReadLine();
            Console.WriteLine("Digite a nota 2:");
            string n2 = Console.ReadLine();
            Console.WriteLine("Digite o peso da nota 2:");
            string p2 = Console.ReadLine();
            decimal n1i= Convert.ToDecimal(n1);
            decimal p1i = Convert.ToDecimal(p1);
            decimal n2i= Convert.ToDecimal(n2);
            decimal p2i= Convert.ToDecimal(p2);
            decimal resultado = ((p1i * n1i) + (p2i * n2i)) / (p1i + p2i);
            Console.WriteLine("A media ficou "+ resultado);
            Console.ReadLine();




        }
    }
}
