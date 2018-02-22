using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace CConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            IProgram program = new WindowProgram();
            program.Start();
 
        }
    }
}
