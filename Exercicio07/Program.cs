namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Salario base:");
            string salario = Console.ReadLine();
            Console.WriteLine("Digite o valor total de vendas:");
            string total = Console.ReadLine();
            Console.WriteLine("Digite a porcentagem da comissão:");
            string com =Console.ReadLine();
            decimal salarioi=Convert.ToDecimal(salario);
            decimal totali=Convert.ToDecimal(total);
            decimal comi=Convert.ToDecimal(com);
            decimal resultado = (totali * (comi / 100)) + salarioi;
            Console.WriteLine("Ele recebeu ao todo R$"+resultado);
            Console.ReadLine();
        }
    }
}
