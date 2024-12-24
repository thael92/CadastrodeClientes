using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CadastrodeClientes
{
    internal class Funcoes
    {


        public static DataTable BuscaSQL(string sql)
        {

            DataTable dt = new DataTable();

            using (SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-I5C3A17\\SQLEXPRESS;Initial Catalog=CadastroClientes;Integrated Security=True"))
            {
                conexao.Open();

                using (SqlCommand cmd = conexao.CreateCommand())
                {
                    
                    cmd.CommandText = sql;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {

                        da.Fill(dt);

                    }
                }

                return dt;
            }
        }


        public static void CarregarCombobox(ComboBox cb, string tabela, string campo)
        {
            cb.DataSource = Funcoes.BuscaSQL("SELECT DISTINCT " + campo + " FROM "+tabela+" WHERE "+campo+" <> ''");
            cb.DisplayMember = campo;
            cb.SelectedIndex = -1;



        }
    }

}
