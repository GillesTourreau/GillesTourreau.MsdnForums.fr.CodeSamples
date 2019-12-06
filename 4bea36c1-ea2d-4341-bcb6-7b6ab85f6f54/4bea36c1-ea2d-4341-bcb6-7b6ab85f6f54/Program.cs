using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4bea36c1_ea2d_4341_bcb6_7b6ab85f6f54
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Office.Interop.Word.Page p;
            Microsoft.Office.Interop.Word.Selection s;
            Microsoft.Office.Interop.Word.Range rng;

            Microsoft.Office.Interop.Word._Application ox_word;
ox_word.Selection.InsertNewPage();
rng.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak);
        }
    }
}
