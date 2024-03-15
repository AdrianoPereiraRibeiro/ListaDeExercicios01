namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quilometragem inicial:");
            string km1 = Console.ReadLine();
            Console.WriteLine("Informe a quilometragem final:");
            string km2= Console.ReadLine();
            Console.WriteLine("Informe o consumo de combustivel:");
            string cb= Console.ReadLine();
            int km1i=Convert.ToInt32(km1);
            int km2i=Convert.ToInt32(km2);  
            int cbi=Convert.ToInt32(cb);
            int conta1= km2i-km1i;
            int conta2= conta1/cbi;
            Console.WriteLine("O carro fez "+conta2+" KM/L ");
            Console.ReadLine(); 
        }
    }
}
