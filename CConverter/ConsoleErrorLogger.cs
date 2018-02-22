using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConverter
{
    class ConsoleErrorLogger:IErrorLogger
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
