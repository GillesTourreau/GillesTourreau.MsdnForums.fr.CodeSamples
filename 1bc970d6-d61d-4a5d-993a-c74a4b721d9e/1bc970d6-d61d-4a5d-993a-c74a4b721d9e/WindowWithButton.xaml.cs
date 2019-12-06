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
using System.Windows.Shapes;

namespace _1bc970d6_d61d_4a5d_993a_c74a4b721d9e
{
    /// <summary>
    /// Logique d'interaction pour WindowWithButton.xaml
    /// </summary>
public partial class WindowWithButton : Window
{
    private MainWindow mainWindow;

    public WindowWithButton(MainWindow mainWindow)
    {
        InitializeComponent();

        this.mainWindow = mainWindow;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        this.mainWindow.tb_maTextbox.Text = "Hello";
    }
}
}
