namespace ListaDeExercicios01
{
    internal class Exercicio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura, o comprimento e a largura do retangulo, respectivamente");
            string Al= Console.ReadLine();  
            string Co = Console.ReadLine();
            string La = Console.ReadLine();
            decimal Ald= Convert.ToDecimal(Al);
            decimal Cod= Convert.ToDecimal(Co);
            decimal Lad = Convert.ToDecimal(La);
            decimal resultado = Lad * Cod * Ald;
            Console.WriteLine("O volume do retangulo é igual a: " + resultado);
            Console.ReadLine();
           
        }
    }
}
