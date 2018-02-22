using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConverter
{
    interface ICurrencyLoader
    {
        void LoadFromFile(string firstname, string secondname);
        double GetConverter();
        string[] _data { get; set; }
    }
}
