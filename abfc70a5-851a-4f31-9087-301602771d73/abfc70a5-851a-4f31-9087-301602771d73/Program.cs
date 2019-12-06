using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abfc70a5_851a_4f31_9087_301602771d73
{
    class Program
    {
        static void Main(string[] args)
        {
byte[] abcdef = new byte[] {  };
string bcd = UnicodeEncoding.Default.GetString(abcdef);

foreach(char caractèreInterdit in Path.GetInvalidPathChars())
{
    bcd = bcd.Replace(caractèreInterdit.ToString(), "");
}

var folder = Directory.CreateDirectory("C:\\" + bcd);
        }
    }
}
