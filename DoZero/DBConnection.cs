using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoZero
{
    class DBConnection
    {

        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D037;Initial" +
    " Catalog=BDmanhã;Persist Security Info=True;User ID=guest01;Password=@Senac2021");


        /// <summary>
        /// Select all values from all elements from given table, already have dbo.before table
        /// This function returns all elements selected in the table, the table already inclube dbo.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="element"></param>
        /// <returns>List(string) allSelectElements</returns>
        public static List<string> GenericUnitSelect(string element, string table)
        {
            List<string> returnElements = new List<string>();



            string select = $"SELECT {element} from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();



            return returnElements;


        }

        public static void GenericExecute(string command)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand(command, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public static List<string[]> GenericSelectAll(string table)
        {
            List<string[]> lista = new List<string[]>();
            string select = $"SELECT * from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
            
                string[] vetor = new string[dr.FieldCount];
                for(int i = 0; i < vetor.Length;i++)
                {
                    vetor[i] = dr[i.ToString();
                }
                lista.Add(vetor);                            
            }
            dr.Close();
            Connection.Close();
            return.lista;
        
        }
    }
}
