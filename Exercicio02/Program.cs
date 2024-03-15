namespace ListaDeExercicios01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o a temperatura em Fahrenheit:");
            string tmp = Console.ReadLine();
            int temp = Convert.ToInt32(tmp);
            int resultado1 = temp - 32;
            int resultado2 = resultado1 * 5 / 9;
            Console.WriteLine("O resultado é " + resultado2 + " celsius:");
            Console.ReadLine();
        }
    }
}
