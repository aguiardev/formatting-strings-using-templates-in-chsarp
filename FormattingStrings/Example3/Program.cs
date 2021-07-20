using System;
using System.Collections.Generic;
using System.Linq;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Tiago Aguiar";
            var birth = new DateTime(1991, 8, 3);
            var s = new MyString(name, birth);
            
            Console.WriteLine(s);
        }

        public class MyString
        {
            private const string Template = @"Seu nome é {name} e seu aniversário é em {birth}, no mês de {month}.";
            private readonly Dictionary<string, string> _parameters = new();
            
            public MyString(string name, DateTime birth)
            {
                // validate parameters before assignment
                
                _parameters.Add(@"{name}", name);
                _parameters.Add(@"{birth}", $"{birth:MM/dd/yyyy}");
                _parameters.Add(@"{month}", $"{birth:MMMM}");
            }
            
            public override string ToString()
            {
                return _parameters.Aggregate(Template, (s, kv) => s.Replace(kv.Key, kv.Value));
            }
        }
    }
}
