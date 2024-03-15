namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A:");
            string a=Console.ReadLine();
            Console.WriteLine("Digite o valor de B:");
            string b=Console.ReadLine();
            int ai = Convert.ToInt32(a);
            int bi = Convert.ToInt32(b);
            if (ai == bi)
            {
                int resultado = ai + bi;
                    Console.WriteLine ("A soma dos números iguais é "+resultado);
           }
            else if (bi != ai) {
            int resultado = bi * ai;
                Console.WriteLine("O produto dos números é " + resultado);
            }
            Console.ReadLine();





        }
    }
}
