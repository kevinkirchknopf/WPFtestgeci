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
using WPF_quiz.Views;
using WPF_quiz.Models;
using WPF_quiz.Services;

namespace WPF_quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UjKerdes UjKerdes;
        
        public MainWindow()
        {
            InitializeComponent();
            UjKerdes = new UjKerdes();
            KerdesService.context.Database.EnsureCreated();
            
        }

        private void btnUjkerdes_Click(object sender, RoutedEventArgs e)
        {
            ctrlMain.Content = UjKerdes;
        }
    }
}
