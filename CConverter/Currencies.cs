using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConverter
{
    class Currencies:ICurrencies
    {
        //public string Name { get; set; }
        public Dictionary<string, double> Data { get; set; }

        public Currencies()
        {
            this.Data = new Dictionary<string, double>();
        }


    }
}
