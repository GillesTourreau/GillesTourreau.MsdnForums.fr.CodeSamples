using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace b4b450d2_ef56_4b91_aff1_b812d0ffb153
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
    }

public class Arbre : INotifyPropertyChanged
{
    private BitmapImage _image;

    public BitmapImage image
    {
        get
        {
            return this._image;
        }

        set
        {
            if (this._image != value)
            {
                this._image = value;

                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("image"));
                }
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
} 
}
