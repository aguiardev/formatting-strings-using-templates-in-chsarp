using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string template = "Seu nome é {0} e seu aniversário é em {1:MM/dd/yyyy}, no mês de {1:MMMM}.";
            var name = "Tiago Aguiar";
            var birth = new DateTime(1991, 8, 3);
            
            Console.WriteLine(string.Format(template, name, birth));
            // Console Output:
            // Seu nome é Tiago e seu aniversário é em 03/08/1991, no mês de Agosto.
            
            Console.WriteLine(template, name, birth);
            // Console Output:
            // Seu nome é Tiago e seu aniversário é em 03/08/1991, no mês de Agosto.
        }
    }
}
