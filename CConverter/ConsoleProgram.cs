using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConverter
{
    class ConsoleProgram:IProgram
    {
        IErrorLogger el;
        ConsoleProgram()
        {
            this.el = new ConsoleErrorLogger();
        }
        public void Start()
        {
            Converter c = new Converter();
            string firstcurrency;
            string secondcurrency;
            double variable=0;
            firstcurrency = Console.ReadLine();
            secondcurrency = Console.ReadLine();
            try
            {
                variable = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                el.ShowMessage(e.Message);
            }
            c.convert(firstcurrency, secondcurrency, variable);
        }
    }
}
