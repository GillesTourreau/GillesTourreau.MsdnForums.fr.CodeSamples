using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _62a05a67_bd58_4f94_b87c_d9f13269f9d0
{
    class Program
    {
        static void Main(string[] args)
        {
var elements = XDocument.Load("Test.xml")
    .Element("Tests").Elements("Test").Elements("Name")
    .Select(e => e.Value).ToArray();
        }
    }
}
