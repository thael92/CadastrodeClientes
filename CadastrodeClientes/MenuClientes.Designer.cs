
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace CadastrodeClientes
{

    partial class MenuClientes
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        string pastaFotos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fotos");


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuClientes));
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            BtFicha = new Button();
            BtRelatorio = new Button();
            BtEditar = new Button();
            BtAdd = new Button();
            button1 = new Button();
            dgLista = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            nome = new DataGridViewTextBoxColumn();
            CPF_CNPJ = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            RG = new DataGridViewTextBoxColumn();
            Estado_Civil = new DataGridViewTextBoxColumn();
            Data_Nascimento = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            Endereco = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Bairro = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Observacoes = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            pesqEstadoCivil = new ComboBox();
            pesqGenero = new ComboBox();
            pesqnome = new TextBox();
            label2 = new Label();
            pesqCodigo = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(BtFicha);
            groupBox1.Controls.Add(BtRelatorio);
            groupBox1.Controls.Add(BtEditar);
            groupBox1.Controls.Add(BtAdd);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = SystemColors.ButtonShadow;
            groupBox1.Location = new Point(8, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ações";
            // 
            // BtFicha
            // 
            BtFicha.BackColor = Color.Transparent;
            BtFicha.Cursor = Cursors.Hand;
            BtFicha.Enabled = false;
            BtFicha.FlatAppearance.BorderSize = 0;
            BtFicha.FlatStyle = FlatStyle.Flat;
            BtFicha.Image = (Image)resources.GetObject("BtFicha.Image");
            BtFicha.Location = new Point(168, 21);
            BtFicha.Name = "BtFicha";
            BtFicha.Size = new Size(48, 48);
            BtFicha.TabIndex = 1;
            BtFicha.UseVisualStyleBackColor = false;
            BtFicha.Click += button4_Click;
            // 
            // BtRelatorio
            // 
            BtRelatorio.BackColor = Color.Transparent;
            BtRelatorio.Cursor = Cursors.Hand;
            BtRelatorio.FlatAppearance.BorderSize = 0;
            BtRelatorio.FlatStyle = FlatStyle.Flat;
            BtRelatorio.Image = (Image)resources.GetObject("BtRelatorio.Image");
            BtRelatorio.Location = new Point(114, 24);
            BtRelatorio.Name = "BtRelatorio";
            BtRelatorio.Size = new Size(48, 48);
            BtRelatorio.TabIndex = 1;
            BtRelatorio.UseVisualStyleBackColor = false;
            BtRelatorio.Click += button3_Click;
            // 
            // BtEditar
            // 
            BtEditar.BackColor = Color.Transparent;
            BtEditar.Cursor = Cursors.Hand;
            BtEditar.Enabled = false;
            BtEditar.FlatAppearance.BorderSize = 0;
            BtEditar.FlatStyle = FlatStyle.Flat;
            BtEditar.Image = (Image)resources.GetObject("BtEditar.Image");
            BtEditar.Location = new Point(60, 24);
            BtEditar.Name = "BtEditar";
            BtEditar.Size = new Size(48, 48);
            BtEditar.TabIndex = 1;
            BtEditar.UseVisualStyleBackColor = false;
            BtEditar.Click += BtEditar_Click;
            // 
            // BtAdd
            // 
            BtAdd.BackColor = Color.Transparent;
            BtAdd.Cursor = Cursors.Hand;
            BtAdd.FlatAppearance.BorderSize = 0;
            BtAdd.FlatStyle = FlatStyle.Flat;
            BtAdd.Image = Properties.Resources.Add;
            BtAdd.Location = new Point(6, 24);
            BtAdd.Name = "BtAdd";
            BtAdd.Size = new Size(48, 48);
            BtAdd.TabIndex = 1;
            BtAdd.UseVisualStyleBackColor = false;
            BtAdd.Click += BtAdd_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.Add;
            button1.Location = new Point(6, 24);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // dgLista
            // 
            dgLista.AllowUserToAddRows = false;
            dgLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = Color.PowderBlue;
            dgLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dgLista.BorderStyle = BorderStyle.None;
            dgLista.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle20.Font = new Font("Consolas", 11F);
            dataGridViewCellStyle20.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            dgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dgLista.ColumnHeadersHeight = 30;
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgLista.Columns.AddRange(new DataGridViewColumn[] { id, Foto, nome, CPF_CNPJ, Genero, RG, Estado_Civil, Data_Nascimento, CEP, Endereco, Numero, Bairro, Cidade, Estado, Celular, Email, Observacoes, Situacao });
            dgLista.EnableHeadersVisualStyles = false;
            dgLista.Location = new Point(10, 94);
            dgLista.Name = "dgLista";
            dgLista.ReadOnly = true;
            dgLista.RowHeadersVisible = false;
            dgLista.RowHeadersWidth = 4;
            dgLista.RowTemplate.Height = 30;
            dgLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLista.Size = new Size(1242, 534);
            dgLista.TabIndex = 1;
            dgLista.CellClick += dgLista_CellClick;
            dgLista.CellFormatting += dgLista_CellFormatting;
            dgLista.Sorted += dgLista_Sorted;
            // 
            // id
            // 
            id.DataPropertyName = "Codigo";
            id.HeaderText = "Nº";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 68;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            Foto.Width = 50;
            // 
            // nome
            // 
            nome.DataPropertyName = "Nome";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nome.DefaultCellStyle = dataGridViewCellStyle21;
            nome.HeaderText = "Nome do Cliente";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 332;
            // 
            // CPF_CNPJ
            // 
            CPF_CNPJ.DataPropertyName = "CPF_CNPJ";
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CPF_CNPJ.DefaultCellStyle = dataGridViewCellStyle22;
            CPF_CNPJ.HeaderText = "CPF/CNPJ";
            CPF_CNPJ.Name = "CPF_CNPJ";
            CPF_CNPJ.ReadOnly = true;
            CPF_CNPJ.Width = 175;
            // 
            // Genero
            // 
            Genero.DataPropertyName = "Genero";
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Genero.DefaultCellStyle = dataGridViewCellStyle23;
            Genero.HeaderText = "Gênero";
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            Genero.Width = 132;
            // 
            // RG
            // 
            RG.DataPropertyName = "RG";
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            RG.DefaultCellStyle = dataGridViewCellStyle24;
            RG.HeaderText = "Nº RG";
            RG.Name = "RG";
            RG.ReadOnly = true;
            RG.Width = 125;
            // 
            // Estado_Civil
            // 
            Estado_Civil.DataPropertyName = "Estado_Civil";
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Estado_Civil.DefaultCellStyle = dataGridViewCellStyle25;
            Estado_Civil.HeaderText = "Estado Civil";
            Estado_Civil.Name = "Estado_Civil";
            Estado_Civil.ReadOnly = true;
            Estado_Civil.Width = 156;
            // 
            // Data_Nascimento
            // 
            Data_Nascimento.DataPropertyName = "Data_Nascimento";
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Format = "d";
            dataGridViewCellStyle26.NullValue = null;
            Data_Nascimento.DefaultCellStyle = dataGridViewCellStyle26;
            Data_Nascimento.HeaderText = "Data/Nascimento";
            Data_Nascimento.Name = "Data_Nascimento";
            Data_Nascimento.ReadOnly = true;
            Data_Nascimento.Width = 123;
            // 
            // CEP
            // 
            CEP.DataPropertyName = "CEP";
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CEP.DefaultCellStyle = dataGridViewCellStyle27;
            CEP.HeaderText = "CEP";
            CEP.Name = "CEP";
            CEP.ReadOnly = true;
            CEP.Width = 111;
            // 
            // Endereco
            // 
            Endereco.DataPropertyName = "Endereco";
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Endereco.DefaultCellStyle = dataGridViewCellStyle28;
            Endereco.HeaderText = "Endereço";
            Endereco.Name = "Endereco";
            Endereco.ReadOnly = true;
            Endereco.Width = 271;
            // 
            // Numero
            // 
            Numero.DataPropertyName = "Numero";
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Numero.DefaultCellStyle = dataGridViewCellStyle29;
            Numero.HeaderText = "Numero";
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            Numero.Width = 92;
            // 
            // Bairro
            // 
            Bairro.DataPropertyName = "Bairro";
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Bairro.DefaultCellStyle = dataGridViewCellStyle30;
            Bairro.HeaderText = "Bairro";
            Bairro.Name = "Bairro";
            Bairro.ReadOnly = true;
            Bairro.Width = 255;
            // 
            // Cidade
            // 
            Cidade.DataPropertyName = "Cidade";
            dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Cidade.DefaultCellStyle = dataGridViewCellStyle31;
            Cidade.HeaderText = "Cidade";
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            Cidade.Width = 271;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Estado.DefaultCellStyle = dataGridViewCellStyle32;
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 81;
            // 
            // Celular
            // 
            Celular.DataPropertyName = "Celular";
            dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Celular.DefaultCellStyle = dataGridViewCellStyle33;
            Celular.HeaderText = "Celular";
            Celular.Name = "Celular";
            Celular.ReadOnly = true;
            Celular.Width = 159;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            dataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Email.DefaultCellStyle = dataGridViewCellStyle34;
            Email.HeaderText = "E-mail";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 220;
            // 
            // Observacoes
            // 
            Observacoes.DataPropertyName = "Observacoes";
            dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Observacoes.DefaultCellStyle = dataGridViewCellStyle35;
            Observacoes.HeaderText = "Observações";
            Observacoes.Name = "Observacoes";
            Observacoes.ReadOnly = true;
            Observacoes.Width = 113;
            // 
            // Situacao
            // 
            Situacao.DataPropertyName = "Situacao_Cadastral";
            dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Situacao.DefaultCellStyle = dataGridViewCellStyle36;
            Situacao.HeaderText = "Situação";
            Situacao.Name = "Situacao";
            Situacao.ReadOnly = true;
            Situacao.Width = 124;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(pesqEstadoCivil);
            groupBox2.Controls.Add(pesqGenero);
            groupBox2.Controls.Add(pesqnome);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(pesqCodigo);
            groupBox2.Controls.Add(label1);
            groupBox2.ForeColor = SystemColors.ButtonShadow;
            groupBox2.Location = new Point(254, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(950, 78);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opções de Consulta";
            // 
            // pesqEstadoCivil
            // 
            pesqEstadoCivil.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            pesqEstadoCivil.AutoCompleteSource = AutoCompleteSource.ListItems;
            pesqEstadoCivil.DropDownHeight = 200;
            pesqEstadoCivil.Font = new Font("Consolas", 11F);
            pesqEstadoCivil.ForeColor = Color.SteelBlue;
            pesqEstadoCivil.FormattingEnabled = true;
            pesqEstadoCivil.IntegralHeight = false;
            pesqEstadoCivil.Items.AddRange(new object[] { "Solteiro", "Casado(a)", "Divorciado(a)", "Viúvo(a)" });
            pesqEstadoCivil.Location = new Point(413, 45);
            pesqEstadoCivil.Margin = new Padding(3, 4, 3, 4);
            pesqEstadoCivil.Name = "pesqEstadoCivil";
            pesqEstadoCivil.Size = new Size(115, 26);
            pesqEstadoCivil.TabIndex = 7;
            pesqEstadoCivil.SelectedIndexChanged += pesqEstadoCivil_SelectedIndexChanged;
            pesqEstadoCivil.TextChanged += pesqnome_TextChanged;
            // 
            // pesqGenero
            // 
            pesqGenero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            pesqGenero.AutoCompleteSource = AutoCompleteSource.ListItems;
            pesqGenero.DropDownHeight = 200;
            pesqGenero.Font = new Font("Consolas", 11F);
            pesqGenero.ForeColor = Color.SteelBlue;
            pesqGenero.FormattingEnabled = true;
            pesqGenero.IntegralHeight = false;
            pesqGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros(a)" });
            pesqGenero.Location = new Point(292, 45);
            pesqGenero.Margin = new Padding(3, 4, 3, 4);
            pesqGenero.Name = "pesqGenero";
            pesqGenero.Size = new Size(115, 26);
            pesqGenero.TabIndex = 7;
            pesqGenero.SelectedIndexChanged += pesqGenero_SelectedIndexChanged;
            pesqGenero.TextChanged += pesqnome_TextChanged;
            // 
            // pesqnome
            // 
            pesqnome.Font = new Font("Consolas", 11F);
            pesqnome.ForeColor = SystemColors.ActiveBorder;
            pesqnome.Location = new Point(89, 46);
            pesqnome.Margin = new Padding(3, 4, 3, 4);
            pesqnome.Name = "pesqnome";
            pesqnome.Size = new Size(197, 25);
            pesqnome.TabIndex = 1;
            pesqnome.TextChanged += pesqnome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(98, 28);
            label2.Name = "label2";
            label2.Size = new Size(156, 18);
            label2.TabIndex = 2;
            label2.Text = "Nome / CPF ou CNPJ";
            // 
            // pesqCodigo
            // 
            pesqCodigo.Font = new Font("Consolas", 11F);
            pesqCodigo.ForeColor = SystemColors.ActiveBorder;
            pesqCodigo.Location = new Point(6, 46);
            pesqCodigo.Margin = new Padding(3, 4, 3, 4);
            pesqCodigo.Name = "pesqCodigo";
            pesqCodigo.Size = new Size(67, 25);
            pesqCodigo.TabIndex = 1;
            pesqCodigo.TextChanged += pesqCodigo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(292, 28);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 2;
            label3.Text = "Gênero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(413, 28);
            label4.Name = "label4";
            label4.Size = new Size(86, 18);
            label4.TabIndex = 2;
            label4.Text = "Estado Civil";
            // 
            // MenuClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImage = Properties.Resources.granent_cadastro_client;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgLista);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Consolas", 11F);
            ForeColor = SystemColors.WindowText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuClientes";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Clientes de Cadastro";
            Load += MenuClientes_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private void MenuClientes_Load(object sender, EventArgs e)
        {

            BuscarCliente();  
            
            
        }
    

        private void BtAdd_Click(object sender, EventArgs e)
        {
        

            cadclientes frm = new cadclientes();
            frm.ShowDialog();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            cadclientes frm = new cadclientes();

            frm.textCodigo.Text = dgLista.CurrentRow.Cells["id"].Value.ToString();


            frm.ShowDialog();

            BuscarCliente();


        }


        private void button3_Click(object sender, EventArgs e)
        {
           
        }




        #endregion
        private GroupBox groupBox1;
        private Button button1;
        private Button BtFicha;
        private Button BtRelatorio;
        private Button BtEditar;
        private Button BtAdd;
        private DataGridView dgLista;
        private DataGridViewTextBoxColumn id;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn CPF_CNPJ;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn RG;
        private DataGridViewTextBoxColumn Estado_Civil;
        private DataGridViewTextBoxColumn Data_Nascimento;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Observacoes;
        private DataGridViewTextBoxColumn Situacao;
        private GroupBox groupBox2;
        private TextBox pesqCodigo;
        private Label label1;
        private TextBox pesqnome;
        private Label label2;
        private ComboBox pesqEstadoCivil;
        private ComboBox pesqGenero;
        private Label label4;
        private Label label3;
    }
}