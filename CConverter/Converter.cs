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
        public IErrorLogger el;

        public Converter() 
        { 
            this.Currencies = new List<Currency>();
            this.Cloader = new FileCurrencyLoader("przeliczniki.txt");
            this.el = new WindowErrorLogger();
        }

        public double convert(string firstname, string secondname, double amount)
        {
            try
            {
                foreach (var currencies in Currencies)
                {
                    if (currencies.Data.ContainsKey(firstname + ';' + secondname))
                    {
                        return amount * currencies.Data[firstname + ';' + secondname];
                    }

                }
            }
            catch (ArgumentNullException e)
            {
               el.ShowMessage(e.Message);
            }
            this.Cloader.LoadFromFile(firstname, secondname);
            Currency currency = new Currency();
            currency.Data.Add(this.Cloader._data[0] + ";" + this.Cloader._data[1], this.Cloader.GetConverter());
            this.Currencies.Add(currency);
            return amount * this.Cloader.GetConverter();
        }
    }
}



