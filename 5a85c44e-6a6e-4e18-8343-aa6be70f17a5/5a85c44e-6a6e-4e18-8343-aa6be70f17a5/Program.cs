using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _5a85c44e_6a6e_4e18_8343_aa6be70f17a5
{
    class Program
    {
        static void Main(string[] args)
        {
WebClient client;
client = new WebClient();

byte[] contenuFlash;
contenuFlash = client.DownloadData("http://....");
        }
    }
}
