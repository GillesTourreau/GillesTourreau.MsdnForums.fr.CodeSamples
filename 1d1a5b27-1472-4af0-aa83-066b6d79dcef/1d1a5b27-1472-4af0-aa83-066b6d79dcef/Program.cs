using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1d1a5b27_1472_4af0_aa83_066b6d79dcef
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }

private void MaMéthode(int numero, DateTime dateInscription)
{
    string Message = "insert into CompteClient(Numero, DateInscription) values (@numero, @dateInscription)";

    SqlCommand oCmd = new SqlCommand(Message, oConn);
    oCmd.Parameters.AddWithValue("@numero", numero);
    oCmd.Parameters.AddWithValue("@dateInscription", dateInscription);
    int n = oCmd.ExecuteNonQuery();
}
    }
}
