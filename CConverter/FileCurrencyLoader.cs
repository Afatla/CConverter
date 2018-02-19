using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CConverter
{
    class FileCurrencyLoader:ICurrencyLoader
    {
        public string Filepath { get; set; }
        private string[] _data;
        public FileCurrencyLoader()
        {
            this._data = new string[3]; 
        }

        public FileCurrencyLoader(string p)
        {
            this.Filepath = p;
        }

        public void LoadFromFile(string firstname, string secondname)
        {
            var source = File.ReadAllLines(this.Filepath);
            var czy=0;
            foreach (var line in source)
            {
                if (line.StartsWith(firstname + ";" + secondname)) //nie czyta tutaj!!!!!!!!
                {
                    czy = 1;
                    _data = line.Split(';');

                }
                else
                {
                    czy = 0;
                }
            }
            
        }
        public double GetConverter()
        {
            return double.Parse(_data[2]);
        }
    }
}
