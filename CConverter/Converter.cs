using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConverter
{
    class Converter : IConverter
    {
        public List<Currencies> LCurrencies{get; set;}
        public ICurrencyLoader Cloader{get;set;}

        public Converter() 
        { 
            this.LCurrencies = new List<Currencies>();
            this.Cloader = new FileCurrencyLoader("file.txt");
        }


        public double convert(string firstname, string secondname, double amount)
        {
            
            foreach (var currencies in LCurrencies)
            {
                if (currencies.Data.ContainsKey(firstname+';'+secondname))
                {
                    return amount * currencies.Data[firstname + ';' + secondname];
                   
                }
                
                    break;
                
            }
            this.Cloader.LoadFromFile(firstname, secondname);
            return amount * this.Cloader.GetConverter();
        }
    }
}



