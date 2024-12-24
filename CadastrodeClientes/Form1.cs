using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace CadastrodeClientes
{
    public partial class cadclientes : Form
    {
        public cadclientes()
        {
            InitializeComponent();

            // Associando o mesmo método de validação a CBEndereco e CBBairro
            CBEndereco.Validating += CBEndereco_Validating;
            CBBairro.Validating += CBEndereco_Validating;
            CBCidade.Validating += CBEndereco_Validating;


        }
        string strcon = "Data Source=DESKTOP-I5C3A17\\SQLEXPRESS;Initial Catalog=CadastroClientes;Integrated Security=True";


        // Definindo a pasta "Fotos" na raiz do projeto
        string pastaFotos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Fotos");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Salva a posição atual do cursor
            int cursorPosition = textNome.SelectionStart;

            // Converte o texto para Title Case
            var cultureInfo = System.Globalization.CultureInfo.CurrentCulture;
            var textInfo = cultureInfo.TextInfo;
            string formattedText = textInfo.ToTitleCase(textNome.Text.ToLower());

            // Atualiza o texto no TextBox
            textNome.Text = formattedText;

            // Restaura a posição do cursor
            textNome.SelectionStart = cursorPosition;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

            
        
        
        



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TextRG.Focus();
        }
        private void maskedTextBox_MaskInputRejected(object sender, EventArgs e)
        {
            // Lógica para tratar o evento
        }
        private void maskedTextBox5_MaskedInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Lógica do evento
        }


        private void cadclientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Implementação do evento

            if (OpCNPJ.Checked == true)
            {
                TextDoc.Mask = "00,000,000/0000-00";
                TextDoc.Focus();
            }
        }

        private void SalvarClienteSql()

        {
            // Conexão com o banco de dados
            using (SqlConnection conexao = new SqlConnection(strcon))
            {
                try
                {
                    conexao.Open();

                    // Criação do comando SQL
                    using (SqlCommand cmd = conexao.CreateCommand())
                    {
                        if (textCodigo.Text == "")
                        {
                            // Inserir novo registro
                            cmd.CommandText = @"
    INSERT INTO Clientes 
    (Nome, CPF_CNPJ, Genero, RG, Estado_Civil, Data_Nascimento, CEP, Endereco, Numero, Bairro, Cidade, Estado, Celular, Email, Observacoes, Situacao_Cadastral) 
    VALUES 
    (@Nome, @CPF_CNPJ, @Genero, @RG, @Estado_Civil, @Data_Nascimento, @CEP, @Endereco, @Numero, @Bairro, @Cidade, @Estado, @Celular, @Email, @Observacoes, @Situacao_Cadastral)";
                        }
                        else
                        {
                            // Atualizar registro existente
                            cmd.CommandText = @"
    UPDATE Clientes 
    SET 
    Nome = @Nome, 
    CPF_CNPJ = @CPF_CNPJ, 
    Genero = @Genero, 
    RG = @RG, 
    Estado_Civil = @Estado_Civil, 
    Data_Nascimento = @Data_Nascimento, 
    CEP = @CEP, 
    Endereco = @Endereco, 
    Numero = @Numero, 
    Bairro = @Bairro, 
    Cidade = @Cidade, 
    Estado = @Estado, 
    Celular = @Celular, 
    Email = @Email, 
    Observacoes = @Observacoes, 
    Situacao_Cadastral = @Situacao_Cadastral 
    WHERE Codigo = @Codigo";

                            // Adicionando o parâmetro do Código
                            cmd.Parameters.AddWithValue("@Codigo", textCodigo.Text);
                        }


                        // Adicionando parâmetros com valores
                        cmd.Parameters.AddWithValue("@Nome", textNome.Text.Trim());
                        cmd.Parameters.AddWithValue("@CPF_CNPJ", TextDoc.Text.Trim()); // Substitua `CPF_CNPJ` pelo controle correto
                                              


                        if (OpF.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Genero", "Feminino");
                        }

                        else if (OpM.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Genero", "Masculino");
                        }
                        else if (OpOutros.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@Genero", "Outros");
                        }

                        cmd.Parameters.AddWithValue("@RG", TextRG.Text.Trim());
                        cmd.Parameters.AddWithValue("@Estado_Civil", CBEstadoCivil.Text.Trim());

                        DateTime dataNascimento;

                        if (DateTime.TryParse(TextDataNascimento.Text, out dataNascimento))
                        {
                            cmd.Parameters.AddWithValue("@Data_Nascimento", dataNascimento);
                        }
                        else
                        {
                            // Se o campo estiver vazio ou o formato for inválido, defina como NULL
                            cmd.Parameters.AddWithValue("@Data_Nascimento", DBNull.Value);
                        }


                        cmd.Parameters.AddWithValue("@CEP", TextCep.Text.Trim());
                        cmd.Parameters.AddWithValue("@Endereco", CBEndereco.Text.Trim());
                        cmd.Parameters.AddWithValue("@Numero", TextNumero.Text.Trim());
                        cmd.Parameters.AddWithValue("@Bairro", CBBairro.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cidade", CBCidade.Text.Trim());
                        cmd.Parameters.AddWithValue("@Estado", CBEstado.Text.Trim());
                        cmd.Parameters.AddWithValue("@Celular", TextCelular.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", TextEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Observacoes", TextObservacoes.Text.Trim());


                        cmd.Parameters.AddWithValue("@Situacao_Cadastral", CKSituacao.Checked ? "Ativo" : "Cancelado");


                        // Executando o comando SQL
                        cmd.ExecuteNonQuery();

                        if (textCodigo.Text == "")
                        { 
                        cmd.CommandText = "SELECT @@IDENTITY";
                        textCodigo.Text = cmd.ExecuteScalar().ToString();
                        }


                        MessageBox.Show("Registro inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Tratamento de erro
                    MessageBox.Show($"Erro ao inserir registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void BTSalvar_Click(object sender, EventArgs e)
        {
            if (Validacoes() == true)
                return;

           
            SalvarClienteSql();
        }

        private bool ClienteJaExiste()
        {
            // Conexão com o banco de dados
            using (SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-I5C3A17\\SQLEXPRESS;Initial Catalog=CadastroClientes;Integrated Security=True"))
            {
                try
                {
                    conexao.Open();

                    // Comando SQL para verificar a existência do cliente
                    string query = "SELECT * FROM Clientes WHERE CPF_CNPJ = @CPF_CNPJ";

                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        // Adiciona o valor do parâmetro
                        comando.Parameters.AddWithValue("@CPF_CNPJ", TextDoc.Text.Trim());

                        // Executa o comando e verifica se o cliente já existe
                        int count = Convert.ToInt32(comando.ExecuteScalar());
                        return count > 0; // Retorna verdadeiro se o cliente já existe
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao verificar cliente: {ex.Message}");
                    return false;
                }
            }
        }


        private bool Validacoes()
        {
            if (textNome.Text == "")
            {
                MessageBox.Show("Digite Seu Nome");
                textNome.Focus();
                return true;
            }

            if (OpCPF.Checked == false && OpCNPJ.Checked == false)

            {
                MessageBox.Show("Marque Tipo de Documento \r CPF ou CNPJ");
                return true;
            }
            if (TextDoc.Text == "")
            {
                if (OpCPF.Checked == true)
                    MessageBox.Show("Digite CPF");
                else
                    MessageBox.Show("Digite CNPJ");
                TextDoc.Focus();
                return true;
            }

            if (OpF.Checked == false && OpM.Checked == false && OpOutros.Checked == false)

            {
                MessageBox.Show("Marque o Genero");
                return true;
            }

            try
            {
                DateTime dataNascimento;

                if (!DateTime.TryParseExact(TextDataNascimento.Text, "dd/MM/yyyy",
                                            System.Globalization.CultureInfo.InvariantCulture,
                                            System.Globalization.DateTimeStyles.None,
                                            out dataNascimento))
                {
                    MessageBox.Show("Data inválida. Insira a data no formato dd/MM/yyyy.",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TextDataNascimento.Focus();
                    return true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return false;
        }

        private void BTNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deletar Dados?", "Informações",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Limpa os campos de texto
                textCodigo.Text = "";
                textNome.Text = "";
                TextDoc.Text = "";
                TextDataNascimento.Text = "";
                TextCep.Text = "";
                TextRG.Text = "";
                TextNumero.Text = "";
                TextCelular.Text = "";
                TextEmail.Text = "";

                // Limpa os ComboBox
                // Resetar os ComboBox
                CBEstadoCivil.Text = "";
                CBEstadoCivil.SelectedIndex = -1; // Garante o reset
                CBEstadoCivil.SelectedItem = null; // Deseleciona qualquer item

                CBEndereco.Text = "";        // Limpa o texto inserido
                CBEndereco.SelectedIndex = -1; // Deseleciona qualquer item
                CBEndereco.SelectedItem = null; // Garante que nenhum item está selecionado


                CBBairro.Text = "";
                CBBairro.SelectedIndex = -1;
                CBBairro.SelectedItem = null;

                CBCidade.Text = "";
                CBCidade.SelectedIndex = -1;
                CBCidade.SelectedItem = null;

                CBEstado.Text = "";
                CBEstado.SelectedIndex = -1;
                CBEstado.SelectedItem = null;




                // Desmarca os radio buttons
                OpF.Checked = false;
                OpM.Checked = false;
                OpOutros.Checked = false;
                OpCNPJ.Checked = false;
                OpCPF.Checked = false;

                // Limpa o campo de observações
                TextObservacoes.Text = "";

                BTSalvar.Text = "Salvar";
                ImgCliente.Image = Properties.Resources.avatar_2092113_640;



                // Mensagem de confirmação
                MessageBox.Show("Os campos foram limpos com sucesso.",
                                "Informação",
                                MessageBoxButtons.OK,                
                                
                                MessageBoxIcon.Information);

                if (ClienteJaExiste())
                {
                    MessageBox.Show("Já existe um cliente com os mesmos dados. Verifique as informações.");
                    return;
                }

            }
        }

        private void BTFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (OpCPF.Checked == true)

            {
                TextDoc.Mask = "000,000,000-00";
                TextDoc.Focus();
            }
        }

        private void OpF_CheckedChanged(object sender, EventArgs e)
        {
            TextRG.Focus();
        }

        private void OpOutros_CheckedChanged(object sender, EventArgs e)
        {
            TextRG.Focus();
        }

        private void TextDataNascimento_Validating(object sender, CancelEventArgs e)
        {
            if (TextDataNascimento.Text == "  /  /")
                return;

            try
            {
                TextDataNascimento.Text = Convert.ToDateTime(TextDataNascimento.Text).ToString();

            }
            catch (Exception)
            {


            }
        }

        private void CBEstadoCivil_Validating(object sender, CancelEventArgs e)
        {
            if (CBEstadoCivil.Text == "")
                return;
            if (CBEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione Estado Civil");
                e.Cancel = true;
            }
        }

        private void CBEstado_Validating(object sender, CancelEventArgs e)
        {
            if (CBEstado.Text == "")
                return;
            if (CBEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Estado");
                e.Cancel = true;
            }
        }

        private void CBEndereco_Validating(object sender, CancelEventArgs e)
        {
            // Referência ao ComboBox que disparou o evento
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;

            if (comboBox == null || string.IsNullOrWhiteSpace(comboBox.Text))
                return;

            // Converte o texto: primeira letra maiúscula, restante minúsculas
            string text = comboBox.Text.ToLower();
            string formattedText = char.ToUpper(text[0]) + text.Substring(1);

            // Atualiza o texto no ComboBox
            comboBox.Text = formattedText;


        }
        private void TextCep_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextCep.Text))
                return;

            if (TextCep.Text.Replace(" ", "").Length < 8)
            {
                MessageBox.Show("Informação incompleta");
                e.Cancel = true; // Impede que o foco saia do controle enquanto a validação não for satisfeita
            }
        }


        private void TextDoc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextDoc.Text.Replace(" ", "")))
                return;

            if (OpCPF.Checked == true && TextDoc.Text.Replace(" ", "").Length < 11)
            {
                MessageBox.Show("Informação incompleta");

                e.Cancel = true;

            }
            if (OpCNPJ.Checked == true && TextDoc.Text.Replace(" ", "").Length < 14)
            {
                MessageBox.Show("Informação incompleta");

                e.Cancel = true;

            }


        }

        private void TextCelular_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextCelular.Text.Replace(" ", "")))
                return;

            if (TextCelular.Text.Length < 11)
            {
                MessageBox.Show("Informação incompleta");
                e.Cancel = true; // Impede a mudança de foco devido à validação incompleta
            }
        }

        private void TextRG_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextRG.Text.Replace(" ", "")))
                return;

            if (TextRG.Text.Length < 11)
            {
                MessageBox.Show("Informação incompleta");
                e.Cancel = true; // Impede a mudança de foco devido à validação incompleta
            }
        }


        private void BTAddFoto_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text == "")
            {
                MessageBox.Show("Digite os Dados do Cliente e Salve");
                return;
            }

            // Configura o OpenFileDialog
            OpenFileDialog caixa = new OpenFileDialog();
            caixa.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            // Se o usuário selecionar uma imagem
            if (caixa.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Exibe a imagem no PictureBox
                    ImgCliente.Image = System.Drawing.Image.FromFile(caixa.FileName);

                    // Define o caminho correto da pasta "Fotos" (na raiz do projeto)
                    string pastaFotos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fotos");

                    // Cria a pasta caso não exista
                    if (!Directory.Exists(pastaFotos))
                    {
                        Directory.CreateDirectory(pastaFotos);
                    }

                    // Obtém a extensão do arquivo original
                    string extensao = Path.GetExtension(caixa.FileName);

                    // Define o caminho de destino com a extensão correta
                    string caminhoDestino = Path.Combine(pastaFotos, textCodigo.Text + extensao);

                    // Copia o arquivo selecionado para a pasta "Fotos" com o nome do código do cliente
                    File.Copy(caixa.FileName, caminhoDestino, true); // Substitui se já existir

                    // Depuração: Verifique se o arquivo foi copiado corretamente

                    MessageBox.Show("Foto adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar a foto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        private void BTRemoverF_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Remover a Foto?", "Confirmação",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;


            try
            {

                string pastaFotos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fotos");
                string caminhoImagem = Path.Combine(pastaFotos, textCodigo.Text + ".png");

                if (File.Exists(caminhoImagem))
                {
                    File.Delete(caminhoImagem);
                    MessageBox.Show("Foto removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A foto não existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Recarregar a imagem padrão
                ImgCliente.Image = Properties.Resources.avatar_2092113_640;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover a foto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CarregarFotoCliente()
        {
            try
            {

                // Garante que a pasta exista
                if (!Directory.Exists(pastaFotos))
                {
                    Directory.CreateDirectory(pastaFotos);
                }

                // Caminho da imagem
                string caminhoImagem = Path.Combine(pastaFotos, textCodigo.Text + ".png");

              

                // Libera a imagem anterior para evitar bloqueio
                if (ImgCliente.Image != null)
                {
                    ImgCliente.Image.Dispose();
                    ImgCliente.Image = null;
                }

                // Verifica as possíveis extensões da foto
                string[] extensoes = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
                foreach (var ext in extensoes)
                {
                    string caminhoCompleto = caminhoImagem + ext;
                    if (File.Exists(caminhoCompleto))
                    {
                        using (var stream = new FileStream(caminhoCompleto, FileMode.Open, FileAccess.Read))
                        {
                            ImgCliente.Image = System.Drawing.Image.FromStream(stream);
                        }
                        return; // Foto encontrada, sai do método
                    }
                }

                // Se a foto não for encontrada, carrega a foto padrão
                ImgCliente.Image = Properties.Resources.avatar_2092113_640;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a foto do cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {

            Funcoes.CarregarCombobox(CBEndereco, "Clientes", "Endereco");

            Funcoes.CarregarCombobox(CBBairro, "Clientes", "Bairro");

            Funcoes.CarregarCombobox(CBCidade, "Clientes", "Cidade");
          



            if (textCodigo.Text == "")
                return;
            BTSalvar.Text = "Atualizar";

            using (SqlConnection conexao = new SqlConnection(strcon))
            {
                conexao.Open();

                using (SqlCommand cmd = conexao.CreateCommand())
                {
                    // Query SQL com parâmetro seguro
                    cmd.CommandText = "SELECT * FROM Clientes WHERE Codigo = @Codigo";
                    cmd.Parameters.AddWithValue("@Codigo", textCodigo.Text);

                    DataTable dt = new DataTable();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            textNome.Text = dt.Rows[0]["Nome"].ToString();
                            TextDoc.Text = dt.Rows[0]["CPF_CNPJ"].ToString();
                            TextRG.Text = dt.Rows[0]["RG"].ToString();
                            CBEstadoCivil.Text = dt.Rows[0]["Estado_Civil"].ToString();
                            TextDataNascimento.Text = dt.Rows[0]["Data_Nascimento"].ToString();
                            TextCep.Text = dt.Rows[0]["CEP"].ToString();
                            CBEndereco.Text = dt.Rows[0]["Endereco"].ToString();
                            TextNumero.Text = dt.Rows[0]["Numero"].ToString();
                            CBBairro.Text = dt.Rows[0]["Bairro"].ToString();
                            CBCidade.Text = dt.Rows[0]["Cidade"].ToString();
                            CBEstado.Text = dt.Rows[0]["Estado"].ToString();
                            TextCelular.Text = dt.Rows[0]["Celular"].ToString();
                            TextEmail.Text = dt.Rows[0]["Email"].ToString();
                            TextObservacoes.Text = dt.Rows[0]["Observacoes"].ToString();

                            if (dt.Rows[0]["CPF_CNPJ"].ToString().Length == 11)
                            {
                                OpCPF.Checked = true;
                            }
                            else
                            {
                                OpCPF.Checked = true;
                            }


                            if (dt.Rows[0]["Genero"].ToString()=="Feminino")

                            {
                                OpF.Checked = true;
                            }

                            else if (dt.Rows[0]["Genero"].ToString() == "Masculino")

                            {
                                OpM.Checked = true;
                            }

                            else
                            {
                                OpOutros.Checked = true;
                            }


                            // Verificar e carregar a foto
                            CarregarFotoCliente();
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

    }
}


