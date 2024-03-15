namespace Exercicio023
{
    internal class Program
    {
        static void Main(string[] args)
        { //Léo me exolicou essa.
            int valor = 0;
            int valor2= 0;
            int total= 0;
            while(valor>=0 && valor < 500) {

                valor2 = valor2 + 3;
                if(valor2 %2!= 0) {
                    valor = valor2;
                Console.WriteLine(valor);
                }
            
            total = valor + total;
            
            
            }
            Console.WriteLine($"A soma é "+(total));
            Console.ReadLine();
            
            
            
            }



         





        }
    }

