using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H10Oef2DelenTryCatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double number = double.Parse(numberTextBox.Text);
                double divider = double.Parse(dividerTextBox.Text);

                resultTextBox.Text = (number / divider).ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Delen door 0 mag niet!");
                dividerTextBox.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Je moet 2 getallen ingeven!");
                numberTextBox.Focus();
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}