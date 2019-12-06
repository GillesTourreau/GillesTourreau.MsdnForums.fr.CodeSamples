using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _563b2664_cd40_40bc_b11c_dd49cd43fad5
{
    class Program
    {
        static void Main(string[] args)
        {
            XNamespace s = "urn:schemas-microsoft-com:office:spreadsheet";
            XNamespace x = "urn:schemas-microsoft-com:office:excel";
            XDocument xDoc = new XDocument(
                new XProcessingInstruction("mso-application", "progid='Excel.Sheet'"),
                            new XElement(s + "Workbook", 
                                new XAttribute(XNamespace.Xmlns + "", "urn:schemas-microsoft-com:office:spreadsheet"),
                                new XAttribute(XNamespace.Xmlns + "x", "urn:schemas-microsoft-com:office:excel"), 
                                new XAttribute(XNamespace.Xmlns + "s", "urn:schemas-microsoft-com:office:spreadsheet"),
                                new XElement("Toto", "Toto")));//juste pour aoir quelque chose dans la balise

            xDoc.Save("test.xml");
        }
    }
}
