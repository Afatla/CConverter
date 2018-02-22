using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;

namespace CConverter
{
    /// <summary>
    /// Interaction logic for WPFErrorLogger.xaml
    /// </summary>
    public partial class WPFErrorLogger : UserControl, IErrorLogger
    {
        public WPFErrorLogger()
        {
            InitializeComponent();
        }

        private void ___Button___convert__Click(object sender, RoutedEventArgs e)
        {
            IErrorLogger el = new WindowErrorLogger();
            Converter converter = new Converter();
           
            if (this.TextBox1.Text != null &&
                this.ComboBox1.SelectedItem != null &&
                this.ComboBox2.SelectedItem != null)
            {
                try
                {
                    this.TextBox2.Text = converter.convert(this.ComboBox1.SelectedItem.ToString(),
                        this.ComboBox2.SelectedItem.ToString(),
                        double.Parse(this.TextBox1.Text)).ToString();
                }
                catch (ArgumentNullException ex)
                {
                    el.ShowMessage(ex.Message);
                }
            }
        }
    }
}
