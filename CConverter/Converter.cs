using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConverter
{
    class Converter : IConverter
    {
        public List<Currency> Currencies{get; set;}
        public ICurrencyLoader Cloader{get;set;}
        

        public Converter() 
        { 
            this.Currencies = new List<Currency>();
            this.Cloader = new FileCurrencyLoader("przeliczniki.txt");
        }

        public double convert(string firstname, string secondname, double amount)
        {
            foreach (var currencies in Currencies)
            {
                if (currencies.Data.ContainsKey(firstname+';'+secondname))
                {
                    return amount * currencies.Data[firstname + ';' + secondname];
                }
                    
            }
            this.Cloader.LoadFromFile(firstname, secondname);
            return amount * this.Cloader.GetConverter();
        }
    }
}



