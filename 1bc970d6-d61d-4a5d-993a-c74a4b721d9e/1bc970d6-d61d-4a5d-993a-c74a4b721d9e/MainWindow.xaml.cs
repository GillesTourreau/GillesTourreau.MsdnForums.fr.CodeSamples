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

namespace _1bc970d6_d61d_4a5d_993a_c74a4b721d9e
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

private void ButtonPourOuvrirWindowWithButton_Click(object sender, RoutedEventArgs e)
{
    WindowWithButton window;
    window = new WindowWithButton(this);

    window.ShowDialog();
}
    }
}
