using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.core.Database
{
    public class promosyonSepeti
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        int returnInt;
        object returnObj;
        public promosyonSepeti()
        {
            con = new SqlConnection(conncetionStringOlustur());
        }

        string conncetionStringOlustur()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "ABDULLAH\\SQLEXPRESS01";
            builder.InitialCatalog = "promosyonSepeti";
            builder.IntegratedSecurity = true;
            return builder.ConnectionString;
        }

        public void BaglantiDurumuAyarla()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public int EkleDuzenleSil(SqlCommand cmd)
        {
            cmd.Connection = con;
            con.Open();
            returnInt =  cmd.ExecuteNonQuery();
            con.Close();
            return returnInt;
        }

        public SqlDataReader liste(SqlCommand cmd)
        {
            cmd.Connection = con;
            BaglantiDurumuAyarla();
            return cmd.ExecuteReader();
        }

        public object kolonGetir(SqlCommand cmd)
        {
            cmd.Connection = con;
            BaglantiDurumuAyarla();
            returnObj = cmd.ExecuteScalar();
            BaglantiDurumuAyarla();
            return returnObj;
        }
    }
}
