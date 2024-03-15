namespace Exercicio001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do comprimento do retangulo:");
            string Com = Console.ReadLine();
            Console.WriteLine("Digite o valor da largura do retangulo:");
            string Lar = Console.ReadLine();
            Console.WriteLine("Digite o valor da altura do retangulo:");
            string Alt = Console.ReadLine(); 
            decimal    AltD= Convert.ToDecimal(Alt);
            decimal        LarD= Convert.ToDecimal(Lar);
            decimal        ComD= Convert.ToDecimal(Com);
            decimal resultado = AltD * LarD * ComD;
            Console.WriteLine("O volume do retangulo é igual a "+resultado);
            Console.ReadLine(); 
        
        
        
        }
    }
}
