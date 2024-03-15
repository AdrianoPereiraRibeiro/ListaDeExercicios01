namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o raio da esfera:");
            string r =Console.ReadLine();
            int ri= Convert.ToInt32(r);
            int resultado= (4*3*(ri*ri*ri))/3;
            Console.WriteLine("O volume dessa esfera é igual a "+resultado+ " PS: Valor de PI aproximado para 3.");
        Console.ReadLine(); 
        
        }
    }
}
