using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter c = new Converter();
            var liczba=c.convert("Waluta3", "Waluta2", 4);
            Console.WriteLine(liczba);
            Console.ReadKey();
        }
    }
}
