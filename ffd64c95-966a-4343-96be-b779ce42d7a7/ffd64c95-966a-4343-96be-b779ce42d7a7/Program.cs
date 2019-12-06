using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffd64c95_966a_4343_96be_b779ce42d7a7
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives().Where(drive => drive.DriveType != DriveType.CDRom))
            {
                var dirs = from dir in drive.RootDirectory.EnumerateDirectories() //Erreur
                           select new
                           {
                               ProgDir = dir,
                           };
            }
        }
    }
}
