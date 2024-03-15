using System.ComponentModel.Design;

namespace Exercicio027
{
    internal class Program
    {
        static void Main(string[] args) //No caso eu só consegui fazer aparecer o fizz e o buzz em cima dos numeros correspondentes, mas não consegui apagar .
        {
            for (int i = 1;  i <= 100; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0  ) 
                {
                    Console.WriteLine("Buzz");
                }
                else if(i % 3 == 0 ) {
                    
                    Console.WriteLine("Fizz");
                }
                 Console.WriteLine(i);
             
           
            }
        Console.ReadLine();
        }
    }
}
