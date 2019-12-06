using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eeb1aead_148f_4299_979d_780a1ab7ecce
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
