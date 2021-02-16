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

namespace WpfApp2_SavingMoney1
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

        private void btCalculate_Click(object sender, RoutedEventArgs e)
        {
            int numberRevenue = int.Parse(txtRevenue.Text);
            int numberCost = int.Parse(txtCost.Text);
            int numberExpect = int.Parse(txtExpect.Text);
            int diffNumer = 0;
            float numberDay = 0;
            string result = "";

            diffNumer = numberRevenue - numberCost;

            if (diffNumer > 0)
            {
                numberDay = numberExpect / diffNumer;
                result = numberDay.ToString();
                txtNumberDay.Text = result;
            } else
            {
                MessageBox.Show("It is impossible");
            }



        }
    }
}
