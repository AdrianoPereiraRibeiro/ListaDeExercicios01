namespace Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para definir o limite da sequência de Fibonacci: ");
            int limite = int.Parse(Console.ReadLine());
            int primeiro = 0, segundo = 1, proximo = 0;

            Console.WriteLine("Sequência de Fibonacci até " + limite + ":");
            while (proximo <= limite)
            {
                Console.Write(proximo + " ");
                primeiro = segundo;
                segundo = proximo;
                proximo = primeiro + segundo;
                
            
            }
        Console.ReadLine(); //Fiz com ajuda de IA
        }
    }
}
