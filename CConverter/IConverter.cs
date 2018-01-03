using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConverter
{
    interface IConverter
    {
        double convert(string firstname, string secondname, double amount);
    }
}
