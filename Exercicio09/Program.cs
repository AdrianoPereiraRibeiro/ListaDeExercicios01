namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
          


            Console.WriteLine("Digite o valor das nota 1:");
            string n1= Console.ReadLine();

            Console.WriteLine("Digite o valor das nota 2:");
            string n2= Console.ReadLine();

            Console.WriteLine("Digite o valor das nota 3:");
            string n3= Console.ReadLine();
            Console.WriteLine("Digite o valor das nota 4:");
            string n4 = Console.ReadLine();
            decimal n1i = Convert.ToDecimal(n1);
            decimal n2i = Convert.ToDecimal(n2);
            decimal n3i = Convert.ToDecimal(n3);
            decimal n4i = Convert.ToDecimal(n4);
            decimal r1 = 1 / n1i;
            decimal r2 = 1 / n2i;
            decimal r3 = 1 / n3i;
            decimal r4 = 1 / n4i;
            decimal rf1 = r1 + r2 + r3 + r4;
            decimal rf2 = 4 / rf1;
            Console.WriteLine("A média harmônica é igual a " + rf2);
            Console.ReadLine();
        }
    }
}
