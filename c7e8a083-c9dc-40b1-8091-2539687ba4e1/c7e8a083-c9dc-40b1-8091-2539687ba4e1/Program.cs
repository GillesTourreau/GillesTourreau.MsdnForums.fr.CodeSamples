using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c7e8a083_c9dc_40b1_8091_2539687ba4e1
{
    class Program
    {
        static void Main(string[] args)
        {
string[] répertoires;
répertoires = new string[] { "C:\\Rep1", "C:\\Rep2", "C:\\Rep3" };

List<string> fichiersTrouvés;
fichiersTrouvés = new List<string>();

foreach(string répertoire in répertoires)
{
    fichiersTrouvés.AddRange(Directory.GetFiles(répertoire, "*.*", SearchOption.AllDirectories));
}

// Tous les fichiers trouvés se trouvent dans la liste "fichiersTrouvés"
        }
    }
}
