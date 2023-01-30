using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._1
{
    public class lmao
    {
        private int id;
        private string jmeno;
        private string prijmeni;

        public int ID { get { return id; } set { id = value; } }
        public string Jmeno { get { return jmeno; } set { jmeno = value; } }
        public string Prijmeni { get { return prijmeni; } set { prijmeni = value; } }

        public lmao(int id, string jmeno, string prijmeni)
        {
            this.id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public void Vklad(SqlConnection c, string jmeno, string prijmeni)
        {
            string querry = "insert into lmao(jmeno,prijmeni) values('"+ jmeno + "','" + prijmeni + "')";
            using (SqlCommand cmd = new SqlCommand(querry, c))
            {
                cmd.ExecuteNonQuery();
            }
        }
        
        public lmao Nacist(SqlConnection c, int id)
        {
            string querry = "select * from lmao";
            using (SqlCommand cmd = new SqlCommand(querry, c))
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read())
                {

                }
            }
        }
    }
}
