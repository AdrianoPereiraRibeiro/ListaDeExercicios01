namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de Pãozinhos vendidos.");
            string pz=Console.ReadLine();
            Console.WriteLine("Digite a quantidade de Broas vendidas:");
            string br = Console.ReadLine();

            decimal pz1= Convert.ToDecimal(pz);
            decimal br1= Convert.ToDecimal(br);
            decimal arrecadacaop = (pz1 * 12)/100;
            decimal arrecadacaob = (br1 * 15)/10;
            decimal deposito=   (arrecadacaop+arrecadacaob)*1/10;
            decimal arrecadacaotot = arrecadacaop + arrecadacaob;
            Console.WriteLine("O total arrecadado foi de R$" +arrecadacaotot+ " e o total que deve ser depositado é igual a R$"+deposito);
            Console.ReadLine();





        }
    }
}
