using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _62b168b7_0d76_44c9_ad4c_044f659c2996
{
    class Program : Form
    {
        SerialPort serialPort1;
        TextBox textBox1;
        TextBox textBox2;

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            // Si le port est ouvert, le fermer
            if (!serialPort1.IsOpen) return;

            // Obtenir le nombre d'octets en attente dans le tampon du port
            int bytes = serialPort1.BytesToRead;

            // Créez une zone tampon (tableau d'octets) pour stocker les données entrantes
            byte[] buffer = new byte[bytes];

            // Lire les données du port et de le stocker dans la mémoire tampon
            serialPort1.Read(buffer, 0, bytes);

            try
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(buffer, 0, buffer.Length);
                ms.Position = 0;
                BinaryReader br = new BinaryReader(ms);
                //int write = ms.Read(data, 0, data.Length); // add by me to test 

                int length = (int)br.BaseStream.Length;
                int pos = 0, i = 0;
                float receivedata;
                StreamWriter sw = new StreamWriter(@"C:\Users\Hilouane\Desktop\ProjetMultis\Text.txt");//création du fichier 
                string[] text = new string[5];

                if (length == 20)
                {
                    text[0] = "X0:= ";
                    text[1] = "A0:= ";
                    text[2] = "Y0:= ";
                    text[3] = "B0:= ";
                    text[4] = "Theta:= ";
                    while (pos < length)
                    {

                        f[i] = br.ReadSingle();

                        this.BeginInvoke(new EventHandler(delegate
                        {
                            textBox2.Text += text[i] + f[i] + "\r\n";
                        }));

                        pos += sizeof(float);
                        System.IO.File.WriteAllText(@"C:\Users\Hilouane\Desktop\ProjetMultis\WriteText.txt", textBox2.Text);
                        //   sw.WriteLine(f[i]);
                        i++;
                    }
                    sw.Close(); //dispose streamer
                    br.Close();//dispose reader
                    ms.Close(); //dispose streamer
                }// end of if length
                else
                {
                    while (pos < length)
                    {
                        receivedata = br.ReadSingle();

                        this.BeginInvoke(new EventHandler(delegate
                        {
                            textBox2.AppendText("Position(nm):= " + receivedata + "\r\n");
                        }));
                        //textBox2.Text += "Position(nm):= " + receivedata + "\r\n";
                        //System.IO.File.WriteAllText(@"C:\Users\Hilouane\Desktop\ProjetMultis\WriteText.txt", textBox2.Text);
                        sw.WriteLine(textBox2.Text);
                    }

                    sw.Flush();
                    sw.Dispose();
                    //sw.Close(); //dispose streamer
                    br.Close();//dispose reader
                }

            } // end of try
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
        }


        /*-----------*/

        private void SetTheText(byte[] data)
        {
            

        } 
    }
}
