using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConverter
{
    class Currency:ICurrency
    {
        public Dictionary<string, double> Data { get; set; }

        public Currency()
        {
            this.Data = new Dictionary<string, double>();
        }

    }
}
