using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;

namespace e4001986_31ea_4139_9d03_1749c1740e17
{
    class Program
    {
        static void Main(string[] args)
        {
            Application ExcelApp = null;

            Workbook ExcelWorkbook = null;

            Range ExcelRange = null;

            /* Open The Excel Application : */
            ExcelApp = new Application();

            /* Open The Excel Workbook : */
            ExcelWorkbook = ExcelApp.Workbooks.Open(@"c:\temp\classeur1.xlsx");

            foreach (_Worksheet ExcelWorksheet in ExcelWorkbook.Sheets)
            {
                var temp = (((Range)(ExcelWorksheet.Cells[2, 3])).Value2);

                if (temp == "10")
                {



                }

            }

        }
    }
}
