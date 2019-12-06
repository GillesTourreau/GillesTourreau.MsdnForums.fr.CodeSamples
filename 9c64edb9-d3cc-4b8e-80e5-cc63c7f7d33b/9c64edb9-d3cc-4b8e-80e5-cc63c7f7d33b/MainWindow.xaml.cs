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

namespace _9c64edb9_d3cc_4b8e_80e5_cc63c7f7d33b
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        this.comboPoliceSecours.ItemsSource = Fonts.SystemFontFamilies.OrderBy(police => police.Source);
    }
}
}
