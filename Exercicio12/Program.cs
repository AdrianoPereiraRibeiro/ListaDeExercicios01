namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o comprimento do terreno em metros:");
            string c = Console.ReadLine();
            Console.WriteLine("Digite a largura do terreno em metro:");
            string l=Console.ReadLine();
            int ci=Convert.ToInt32(c);
            int li= Convert.ToInt32(l);
            int resultado = ci*li;
            Console.WriteLine("O terreno tem " + resultado + " metros quadrados.");
            Console.ReadLine();



        }
    }
}
