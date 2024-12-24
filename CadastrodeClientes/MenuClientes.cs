using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace CadastrodeClientes
{
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dgLista_Sorted(object sender, EventArgs e)
        {
            ReorganizarDataGridView();
        }

        private void ReorganizarDataGridView()
        {
            foreach (DataGridViewRow lin in dgLista.Rows)
            {
                if (lin.Cells["Situacao"].Value.ToString() == "Cancelado")
                {
                    lin.DefaultCellStyle.ForeColor = Color.Red;
                }

                if (lin.Cells["id"].Value != null && !string.IsNullOrEmpty(lin.Cells["id"].Value.ToString()))
                {
                    string id = lin.Cells["id"].Value.ToString();
                    string caminhoImagem = Path.Combine(pastaFotos, id + ".png");

                    if (File.Exists(caminhoImagem))
                    {
                        try
                        {
                            lin.Cells["foto"].Value = Image.FromFile(caminhoImagem);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao carregar a imagem para o ID {id}: {ex.Message}");
                            lin.Cells["foto"].Value = Properties.Resources.avatar_2092113_640;
                        }
                    }
                    else
                    {
                        lin.Cells["foto"].Value = Properties.Resources.avatar_2092113_640;
                    }
                }
                else
                {
                    lin.Cells["foto"].Value = Properties.Resources.avatar_2092113_640;
                }

            }
            dgLista.ClearSelection();

            BtEditar.Enabled = false;
        }

        private void dgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            BtEditar.Enabled = true;


        }

        private void dgLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se a coluna é "CPF_CNPJ" ou "RG" e se o valor não é nulo
            if ((dgLista.Columns[e.ColumnIndex].Name == "CPF_CNPJ" || dgLista.Columns[e.ColumnIndex].Name == "RG" || dgLista.Columns[e.ColumnIndex].Name == "CEP") && e.Value != null)
            {
                string CPF_CNPJ = e.Value.ToString().Trim();
                string RG = e.Value.ToString().Trim();
                string CEP = e.Value.ToString().Trim();

                // Verifica se o valor contém apenas números
                if (System.Text.RegularExpressions.Regex.IsMatch(CPF_CNPJ, @"^\d+$"))
                {
                    // Verifica se o valor é um CPF
                    if (CPF_CNPJ.Length == 11) // CPF
                    {
                        e.Value = Convert.ToUInt64(CPF_CNPJ).ToString(@"000\.000\.000\-00");
                    }
                    // Verifica se o valor é um CNPJ
                    else if (CPF_CNPJ.Length == 14) // CNPJ
                    {
                        e.Value = Convert.ToUInt64(CPF_CNPJ).ToString(@"00\.000\.000\/0000\-00");
                    }
                    // Verifica se o valor é um RG
                    else if (RG.Length == 11) // RG com 11 dígitos
                    {
                        e.Value = Convert.ToUInt64(RG).ToString(@"000\.000\.000\-00"); // Formato RG
                    }
                    // Verifica se o valor é um CEP
                    else if (CEP.Length == 8) // CEP com 8 dígitos
                    {
                        e.Value = Convert.ToUInt64(CEP).ToString(@"00,000\-000"); // Formato CEP
                    }
                }           
               
            }            
        }
      





        private void BuscarCliente()
        {
            // Cria a consulta base com um parâmetro genérico
            string queryBase = "SELECT * FROM Clientes WHERE 1=1";

            // Adiciona critérios à consulta usando o método GerarCriterios
            string criterios = GerarCriterios();
            queryBase += criterios;

            // Configura os dados no DataGridView
            dgLista.DataSource = Funcoes.BuscaSQL(queryBase);

            // Reorganiza o DataGridView
            ReorganizarDataGridView();
        }

        private string GerarCriterios()
        {
            string c = "";

            // Verifica se o valor não está vazio
            if (!string.IsNullOrEmpty(pesqCodigo.Text))
            {
                // Adiciona o critério para o Código com LIKE para busca parcial
                c += $" AND Codigo LIKE '%{pesqCodigo.Text}%'";
            }




            // Verifica se o texto do campo de pesquisa não está vazio
            if (pesqnome.Text != string.Empty)
            {
                c += $"AND (Nome LIKE '%{pesqnome.Text}%' OR CPF_CNPJ LIKE '%{pesqnome.Text}%')";
            }

            // Verifica se o texto do campo de pesquisa não está vazio
            if (pesqGenero.Text != string.Empty)
            {
                c += $"AND (Genero LIKE '%{pesqGenero.Text}%')";
            }

            // Verifica se o texto do campo de pesquisa não está vazio
            if (pesqEstadoCivil.Text != string.Empty)
            {
                c += $"AND (Estado_Civil LIKE '%{pesqEstadoCivil.Text}%')";
            }


            return c;
        }

        private void pesqCodigo_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void pesqnome_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void pesqGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void pesqEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }


    }
}
