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
        private string Filepath { get; set; }
        public string[] _data { get; set; }
        public IErrorLogger el;
        public FileCurrencyLoader()
        {
            this._data = new string[3];
            this.el = new WindowErrorLogger();
        }

        public FileCurrencyLoader(string p)
        {
            this.Filepath = p;
        }

        public void LoadFromFile(string firstname, string secondname)
        {
            try
            {
                var source = File.ReadAllLines(this.Filepath);
                foreach (var line in source)
                {
                    if (line.StartsWith(firstname + ";" + secondname))
                    {
                        _data = line.Split(';'); 
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                el.ShowMessage(e.Message);
            }
            catch (ArgumentNullException e)
            {
                el.ShowMessage(e.Message);
            }  
        }
        public double GetConverter()
        {
            try
            {
                return double.Parse(_data[2]);
            }
            catch (NullReferenceException e)
            {
                el.ShowMessage(e.Message);
                return 0;
            }
            catch (ArgumentNullException e)
            {
                el.ShowMessage(e.Message);
                return 0;
            }
            catch (FormatException e)
            {
                el.ShowMessage(e.Message);
                return 0;
            }
        }
    }
}
