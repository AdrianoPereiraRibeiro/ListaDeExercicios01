namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário inicial do funcionário:");
            string salario1=(Console.ReadLine());
             decimal salario1i = Convert.ToDecimal(salario1);
            decimal salario15 = (salario1i * 115)/100;
            decimal salario15to8 = (salario15 * 80) / 100;
             Console.WriteLine("O salário era de R$"+salario1+ ",após o aumento de 15% é de R$"+salario15+",porem com o desconto do imposto é de R$"+salario15to8);
            Console.ReadLine(); 







        }
    }
}
