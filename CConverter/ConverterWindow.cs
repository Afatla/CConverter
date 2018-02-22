using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CConverter
{
    public partial class ConverterWindow : Form
    {
        
        public ConverterWindow()
        {
            InitializeComponent();
            
        }

        private void ConverterWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IErrorLogger el = new WindowErrorLogger();
            Converter converter = new Converter();
            if (this.textBox1.Text != null && 
                this.comboBox1.SelectedItem!=null && 
                this.comboBox2.SelectedItem!=null)
            {
                try
                {
                    this.textBox2.Text=converter.convert(this.comboBox1.SelectedItem.ToString(), 
                        this.comboBox2.SelectedItem.ToString(), 
                        double.Parse(this.textBox1.Text)).ToString();
                }
                catch (ArgumentNullException ex)
                {
                    el.ShowMessage(ex.Message);
                }
            }
        }

       
    }
}
