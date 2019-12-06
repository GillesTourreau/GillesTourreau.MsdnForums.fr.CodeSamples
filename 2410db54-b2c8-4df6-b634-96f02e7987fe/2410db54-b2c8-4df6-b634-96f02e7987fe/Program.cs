using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2410db54_b2c8_4df6_b634_96f02e7987fe
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlCommand cmd = new SqlCommand("insert into Patient select '" + textBox1.Text + "', '" + textBox2.Text + "' ,   BulkColumn FROM OPENROWSET(BULK  '" + open.fileName + "' , SINGLE_BLOB) AS Document_PDF  ", C.cn);

            cmd.ExecuteNonQuery();

using (SqlConnection connexion = new SqlConnection("..."))
{
    using (SqlCommand commande = new SqlCommand("SELECT Document_PDF FROM Patient", connexion))
    {
        connexion.Open();

        using (SqlDataReader reader = commande.ExecuteReader())
        {
            reader.Read();

            File.WriteAllBytes("C:\\....\\MonFichier.pdf", (byte[])reader[0]);
        }
    }
}
        }
    }
}
