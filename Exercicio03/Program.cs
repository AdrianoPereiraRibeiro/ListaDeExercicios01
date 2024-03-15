namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio do cilindro:");
            string R=Console.ReadLine();
            Console.WriteLine("Digite o valor da altura do cilindro:");
            string A= Console.ReadLine();
            decimal a = Convert.ToDecimal(A);
            decimal r = Convert.ToDecimal(R);
            
            decimal resultado = 3 * r*r * a;
            Console.WriteLine("O volume do cilindro é igual a "+resultado+ ". PS:Valor de  pi foi aproximado para 3.");
            Console.ReadLine();

        }
    }
}
