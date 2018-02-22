using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConverter
{
    class WindowProgram:IProgram
    {
        public void Start()
        {
            ConverterWindow cw = new ConverterWindow();
            cw.ShowDialog();
        }
    }
}
