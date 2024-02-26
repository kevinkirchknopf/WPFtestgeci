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
using WPF_quiz.Services;
using WPF_quiz.Models;

namespace WPF_quiz.Views
{
    /// <summary>
    /// Interaction logic for UjKerdes.xaml
    /// </summary>
    public partial class UjKerdes : UserControl
    {
        public UjKerdes()
        {
            InitializeComponent();
            cbxPont.ItemsSource = new List<string> {"1","2","3"};
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            KerdesService.Kerdesfeltoltes(txtbxKerdesszoveg.Text, txtbxKat.Text, Convert.ToInt32(cbxPont.SelectedValue), txtHelyesvalasz.Text, txtValasz2.Text, txtValasz3.Text, txtValasz4.Text);
            MessageBox.Show("Sikeres Mentés!");
        }
    }
}
