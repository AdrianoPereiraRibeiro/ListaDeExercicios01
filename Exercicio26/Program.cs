namespace Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, n;

           
            Console.WriteLine("Digite o número: ");
            num = Convert.ToInt32(Console.ReadLine());

            n = num; 

            while (num > 0)
            {
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                }
                Console.WriteLine("Fatorial desse número é igual a {1}\n", num, n);
                num--;
         Console.ReadLine();
           //Esse tive que pesquisar no stackoverflow :) 
            }
        }
            }
}
