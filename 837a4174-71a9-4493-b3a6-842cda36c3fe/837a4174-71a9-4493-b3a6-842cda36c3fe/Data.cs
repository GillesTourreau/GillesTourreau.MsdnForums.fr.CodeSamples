using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _837a4174_71a9_4493_b3a6_842cda36c3fe
{
public class Data : INotifyPropertyChanged
{
    private string valeurTextBox;

    public string ValeurTextBox
    {
        get
        {
            return this.valeurTextBox;
        }

        set
        {
            if (this.valeurTextBox != value)
            {
                this.valeurTextBox = value;

                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("ValeurTextBox"));
                }
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
}
}
