using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Tiago Aguiar";
            var birth = new DateTime(1991, 8, 3);
            
            Console.WriteLine($"Seu nome é {name} e seu aniversário é em {birth:MM/dd/yyyy}, no mês de {birth:MMMM}.");
            
            // Console Output:
            // Seu nome é Tiago e seu aniversário é em 03/08/1991, no mês de Agosto.
        }
    }
}
