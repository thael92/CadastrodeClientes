using System.Windows.Forms;

namespace CadastrodeClientes
{

    partial class cadclientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private void maskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Lógica para tratar o evento
        }

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadclientes));
            label1 = new Label();
            textCodigo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            textNome = new TextBox();
            TextNumero = new TextBox();
            TextEmail = new TextBox();
            TextObservacoes = new TextBox();
            OpCNPJ = new RadioButton();
            OpM = new RadioButton();
            OpOutros = new RadioButton();
            CKSituacao = new CheckBox();
            TextDoc = new MaskedTextBox();
            TextRG = new MaskedTextBox();
            TextDataNascimento = new MaskedTextBox();
            TextCep = new MaskedTextBox();
            TextCelular = new MaskedTextBox();
            OpF = new RadioButton();
            OpCPF = new RadioButton();
            GBGenero = new GroupBox();
            label2 = new Label();
            CBEstado = new ComboBox();
            CBEstadoCivil = new ComboBox();
            CBEndereco = new ComboBox();
            CBBairro = new ComboBox();
            CBCidade = new ComboBox();
            ImgCliente = new PictureBox();
            BTAddFoto = new Button();
            BTRemoverF = new Button();
            BTNovo = new Button();
            BTFechar = new Button();
            BTSalvar = new Button();
            GBGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImgCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(322, 41);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // textCodigo
            // 
            textCodigo.Font = new Font("Consolas", 11F);
            textCodigo.ForeColor = Color.SteelBlue;
            textCodigo.ImeMode = ImeMode.NoControl;
            textCodigo.Location = new Point(205, 69);
            textCodigo.Margin = new Padding(3, 4, 3, 4);
            textCodigo.Name = "textCodigo";
            textCodigo.ReadOnly = true;
            textCodigo.Size = new Size(90, 25);
            textCodigo.TabIndex = 23;
            textCodigo.TabStop = false;
            textCodigo.TextAlign = HorizontalAlignment.Center;
            textCodigo.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(222, 41);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 4;
            label4.Text = "Código";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 11F);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(209, 273);
            label5.Name = "label5";
            label5.Size = new Size(31, 18);
            label5.TabIndex = 5;
            label5.Text = "RG";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 11F);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(400, 275);
            label6.Name = "label6";
            label6.Size = new Size(86, 18);
            label6.TabIndex = 6;
            label6.Text = "Estado Civil";
            label6.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 11F);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(72, 348);
            label7.Name = "label7";
            label7.Size = new Size(39, 18);
            label7.TabIndex = 2;
            label7.Text = "CEP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 11F);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(208, 348);
            label8.Name = "label8";
            label8.Size = new Size(72, 18);
            label8.TabIndex = 3;
            label8.Text = "Endereço";
            label8.Click += label3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 11F);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(72, 420);
            label9.Name = "label9";
            label9.Size = new Size(48, 18);
            label9.TabIndex = 2;
            label9.Text = "Bairro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 11F);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(269, 503);
            label10.Name = "label10";
            label10.Size = new Size(54, 18);
            label10.TabIndex = 2;
            label10.Text = "Celular";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 11F);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(400, 426);
            label11.Name = "label11";
            label11.Size = new Size(54, 18);
            label11.TabIndex = 3;
            label11.Text = "Cidade";
            label11.Click += label3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 11F);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(390, 500);
            label12.Name = "label12";
            label12.Size = new Size(50, 18);
            label12.TabIndex = 3;
            label12.Text = "E-mail";
            label12.Click += label3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 11F);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(598, 275);
            label13.Name = "label13";
            label13.Size = new Size(143, 18);
            label13.TabIndex = 3;
            label13.Text = "Data de Nascimento";
            label13.Click += label3_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 11F);
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(821, 354);
            label14.Name = "label14";
            label14.Size = new Size(24, 18);
            label14.TabIndex = 3;
            label14.Text = "Nº";
            label14.Click += label3_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft Sans Serif", 11F);
            label15.ForeColor = SystemColors.ControlText;
            label15.Location = new Point(35, 612);
            label15.Name = "label15";
            label15.Size = new Size(97, 18);
            label15.TabIndex = 2;
            label15.Text = "Observações";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft Sans Serif", 11F);
            label16.ForeColor = SystemColors.ControlText;
            label16.Location = new Point(35, 771);
            label16.Name = "label16";
            label16.Size = new Size(133, 18);
            label16.TabIndex = 3;
            label16.Text = "Situação Cadastral";
            label16.Click += label3_Click;
            // 
            // textNome
            // 
            textNome.Font = new Font("Consolas", 11F);
            textNome.ForeColor = Color.SteelBlue;
            textNome.Location = new Point(311, 68);
            textNome.Margin = new Padding(3, 4, 3, 4);
            textNome.Name = "textNome";
            textNome.Size = new Size(485, 25);
            textNome.TabIndex = 0;
            textNome.TextChanged += textBox1_TextChanged;
            // 
            // TextNumero
            // 
            TextNumero.Font = new Font("Consolas", 11F);
            TextNumero.ForeColor = Color.SteelBlue;
            TextNumero.Location = new Point(803, 375);
            TextNumero.Margin = new Padding(3, 4, 3, 4);
            TextNumero.Name = "TextNumero";
            TextNumero.Size = new Size(54, 25);
            TextNumero.TabIndex = 10;
            TextNumero.TextChanged += textBox1_TextChanged;
            // 
            // TextEmail
            // 
            TextEmail.Font = new Font("Consolas", 11F);
            TextEmail.ForeColor = Color.SteelBlue;
            TextEmail.Location = new Point(385, 527);
            TextEmail.Margin = new Padding(3, 4, 3, 4);
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(473, 25);
            TextEmail.TabIndex = 15;
            TextEmail.TextChanged += textBox1_TextChanged;
            // 
            // TextObservacoes
            // 
            TextObservacoes.Font = new Font("Consolas", 11F);
            TextObservacoes.ForeColor = Color.SteelBlue;
            TextObservacoes.Location = new Point(35, 634);
            TextObservacoes.Margin = new Padding(3, 4, 3, 4);
            TextObservacoes.Multiline = true;
            TextObservacoes.Name = "TextObservacoes";
            TextObservacoes.Size = new Size(822, 113);
            TextObservacoes.TabIndex = 16;
            TextObservacoes.TextChanged += textBox1_TextChanged;
            // 
            // OpCNPJ
            // 
            OpCNPJ.BackColor = Color.Transparent;
            OpCNPJ.Font = new Font("Consolas", 11F);
            OpCNPJ.ForeColor = Color.Black;
            OpCNPJ.Location = new Point(299, 135);
            OpCNPJ.Margin = new Padding(3, 4, 3, 4);
            OpCNPJ.Name = "OpCNPJ";
            OpCNPJ.Size = new Size(71, 48);
            OpCNPJ.TabIndex = 2;
            OpCNPJ.Text = "CNPJ";
            OpCNPJ.UseVisualStyleBackColor = false;
            OpCNPJ.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // OpM
            // 
            OpM.BackColor = Color.Transparent;
            OpM.Font = new Font("Consolas", 11F);
            OpM.ForeColor = Color.Black;
            OpM.Location = new Point(145, 27);
            OpM.Margin = new Padding(3, 4, 3, 4);
            OpM.Name = "OpM";
            OpM.Size = new Size(114, 55);
            OpM.TabIndex = 2;
            OpM.TabStop = true;
            OpM.Text = "Masculino";
            OpM.UseVisualStyleBackColor = false;
            OpM.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // OpOutros
            // 
            OpOutros.AutoSize = true;
            OpOutros.BackColor = Color.Transparent;
            OpOutros.Font = new Font("Consolas", 11F);
            OpOutros.ForeColor = Color.Black;
            OpOutros.Location = new Point(295, 40);
            OpOutros.Margin = new Padding(3, 4, 3, 4);
            OpOutros.Name = "OpOutros";
            OpOutros.Size = new Size(74, 22);
            OpOutros.TabIndex = 2;
            OpOutros.TabStop = true;
            OpOutros.Text = "Outros";
            OpOutros.UseVisualStyleBackColor = false;
            OpOutros.CheckedChanged += OpOutros_CheckedChanged;
            // 
            // CKSituacao
            // 
            CKSituacao.AutoSize = true;
            CKSituacao.BackColor = Color.Transparent;
            CKSituacao.Checked = true;
            CKSituacao.CheckState = CheckState.Checked;
            CKSituacao.Font = new Font("Consolas", 11F);
            CKSituacao.Location = new Point(197, 771);
            CKSituacao.Margin = new Padding(3, 4, 3, 4);
            CKSituacao.Name = "CKSituacao";
            CKSituacao.Size = new Size(67, 22);
            CKSituacao.TabIndex = 17;
            CKSituacao.Text = "Ativo";
            CKSituacao.UseVisualStyleBackColor = false;
            // 
            // TextDoc
            // 
            TextDoc.BeepOnError = true;
            TextDoc.Font = new Font("Consolas", 11F);
            TextDoc.ForeColor = Color.SteelBlue;
            TextDoc.HidePromptOnLeave = true;
            TextDoc.Location = new Point(205, 190);
            TextDoc.Margin = new Padding(3, 4, 3, 4);
            TextDoc.Mask = "000,000,000-00";
            TextDoc.Name = "TextDoc";
            TextDoc.Size = new Size(173, 25);
            TextDoc.TabIndex = 3;
            TextDoc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            TextDoc.Validating += TextDoc_Validating;
            // 
            // TextRG
            // 
            TextRG.BeepOnError = true;
            TextRG.Font = new Font("Consolas", 11F);
            TextRG.ForeColor = Color.SteelBlue;
            TextRG.HidePromptOnLeave = true;
            TextRG.Location = new Point(205, 300);
            TextRG.Margin = new Padding(3, 4, 3, 4);
            TextRG.Mask = "000,000,000-00";
            TextRG.Name = "TextRG";
            TextRG.Size = new Size(153, 25);
            TextRG.TabIndex = 5;
            TextRG.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            TextRG.Validating += TextRG_Validating;
            // 
            // TextDataNascimento
            // 
            TextDataNascimento.BeepOnError = true;
            TextDataNascimento.Font = new Font("Consolas", 11F);
            TextDataNascimento.ForeColor = Color.SteelBlue;
            TextDataNascimento.HidePromptOnLeave = true;
            TextDataNascimento.Location = new Point(598, 300);
            TextDataNascimento.Margin = new Padding(3, 4, 3, 4);
            TextDataNascimento.Mask = "00/00/0000";
            TextDataNascimento.Name = "TextDataNascimento";
            TextDataNascimento.Size = new Size(125, 25);
            TextDataNascimento.TabIndex = 7;
            TextDataNascimento.ValidatingType = typeof(DateTime);
            TextDataNascimento.Validating += TextDataNascimento_Validating;
            // 
            // TextCep
            // 
            TextCep.BeepOnError = true;
            TextCep.Font = new Font("Consolas", 11F);
            TextCep.ForeColor = Color.SteelBlue;
            TextCep.HidePromptOnLeave = true;
            TextCep.Location = new Point(35, 375);
            TextCep.Margin = new Padding(3, 4, 3, 4);
            TextCep.Mask = "00000-000";
            TextCep.Name = "TextCep";
            TextCep.Size = new Size(125, 25);
            TextCep.TabIndex = 8;
            TextCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            TextCep.ValidatingType = typeof(DateTime);
            TextCep.Validating += TextCep_Validating;
            // 
            // TextCelular
            // 
            TextCelular.BeepOnError = true;
            TextCelular.Font = new Font("Consolas", 11F);
            TextCelular.ForeColor = Color.SteelBlue;
            TextCelular.HidePromptOnLeave = true;
            TextCelular.Location = new Point(232, 527);
            TextCelular.Margin = new Padding(3, 4, 3, 4);
            TextCelular.Mask = "(00)0,0000-0000";
            TextCelular.Name = "TextCelular";
            TextCelular.Size = new Size(146, 25);
            TextCelular.TabIndex = 14;
            TextCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            TextCelular.ValidatingType = typeof(DateTime);
            TextCelular.MaskInputRejected += maskedTextBox5_MaskedInputRejected;
            TextCelular.Validating += TextCelular_Validating;
            // 
            // OpF
            // 
            OpF.BackColor = Color.Transparent;
            OpF.Font = new Font("Consolas", 11F);
            OpF.ForeColor = Color.Black;
            OpF.Location = new Point(8, 31);
            OpF.Margin = new Padding(3, 4, 3, 4);
            OpF.Name = "OpF";
            OpF.Size = new Size(121, 48);
            OpF.TabIndex = 1;
            OpF.TabStop = true;
            OpF.Text = "Feminino";
            OpF.UseVisualStyleBackColor = false;
            OpF.CheckedChanged += OpF_CheckedChanged;
            // 
            // OpCPF
            // 
            OpCPF.BackColor = Color.Transparent;
            OpCPF.Font = new Font("Consolas", 11F);
            OpCPF.ForeColor = Color.Black;
            OpCPF.Location = new Point(222, 135);
            OpCPF.Margin = new Padding(3, 4, 3, 4);
            OpCPF.Name = "OpCPF";
            OpCPF.Size = new Size(57, 48);
            OpCPF.TabIndex = 1;
            OpCPF.TabStop = true;
            OpCPF.Text = "CPF";
            OpCPF.UseVisualStyleBackColor = false;
            OpCPF.CheckedChanged += OpCPF_CheckedChanged;
            // 
            // GBGenero
            // 
            GBGenero.BackColor = Color.Transparent;
            GBGenero.Controls.Add(OpF);
            GBGenero.Controls.Add(OpM);
            GBGenero.Controls.Add(OpOutros);
            GBGenero.Font = new Font("Consolas", 11F);
            GBGenero.Location = new Point(377, 152);
            GBGenero.Margin = new Padding(3, 4, 3, 4);
            GBGenero.Name = "GBGenero";
            GBGenero.Padding = new Padding(3, 4, 3, 4);
            GBGenero.Size = new Size(419, 99);
            GBGenero.TabIndex = 4;
            GBGenero.TabStop = false;
            GBGenero.Text = "Gênero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(70, 503);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 3;
            label2.Text = "Estado";
            label2.Click += label3_Click;
            // 
            // CBEstado
            // 
            CBEstado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CBEstado.AutoCompleteSource = AutoCompleteSource.ListItems;
            CBEstado.DropDownHeight = 200;
            CBEstado.Font = new Font("Consolas", 11F);
            CBEstado.ForeColor = Color.SteelBlue;
            CBEstado.FormattingEnabled = true;
            CBEstado.IntegralHeight = false;
            CBEstado.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espirito Santo", "Goiás", "Maranhão", "Mato Grosso do Sul", "Mato Grosso", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            CBEstado.Location = new Point(38, 527);
            CBEstado.Margin = new Padding(3, 4, 3, 4);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(187, 26);
            CBEstado.TabIndex = 13;
            CBEstado.Validating += CBEstado_Validating;
            // 
            // CBEstadoCivil
            // 
            CBEstadoCivil.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CBEstadoCivil.AutoCompleteSource = AutoCompleteSource.ListItems;
            CBEstadoCivil.DropDownHeight = 200;
            CBEstadoCivil.Font = new Font("Consolas", 11F);
            CBEstadoCivil.ForeColor = Color.SteelBlue;
            CBEstadoCivil.FormattingEnabled = true;
            CBEstadoCivil.IntegralHeight = false;
            CBEstadoCivil.Items.AddRange(new object[] { "Solteiro", "Casado(a)", "Divorciado(a)", "Viúvo(a)" });
            CBEstadoCivil.Location = new Point(377, 298);
            CBEstadoCivil.Margin = new Padding(3, 4, 3, 4);
            CBEstadoCivil.Name = "CBEstadoCivil";
            CBEstadoCivil.Size = new Size(187, 26);
            CBEstadoCivil.TabIndex = 6;
            CBEstadoCivil.Validating += CBEstadoCivil_Validating;
            // 
            // CBEndereco
            // 
            CBEndereco.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CBEndereco.AutoCompleteSource = AutoCompleteSource.ListItems;
            CBEndereco.DisplayMember = "Endereco";
            CBEndereco.DropDownHeight = 200;
            CBEndereco.Font = new Font("Consolas", 11F);
            CBEndereco.ForeColor = Color.SteelBlue;
            CBEndereco.FormattingEnabled = true;
            CBEndereco.IntegralHeight = false;
            CBEndereco.Location = new Point(205, 374);
            CBEndereco.Margin = new Padding(3, 4, 3, 4);
            CBEndereco.Name = "CBEndereco";
            CBEndereco.Size = new Size(591, 26);
            CBEndereco.TabIndex = 9;
            CBEndereco.UseWaitCursor = true;
            CBEndereco.Validating += CBEndereco_Validating;
            // 
            // CBBairro
            // 
            CBBairro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CBBairro.AutoCompleteSource = AutoCompleteSource.ListItems;
            CBBairro.DropDownHeight = 200;
            CBBairro.Font = new Font("Consolas", 11F);
            CBBairro.ForeColor = Color.SteelBlue;
            CBBairro.FormattingEnabled = true;
            CBBairro.IntegralHeight = false;
            CBBairro.Location = new Point(35, 447);
            CBBairro.Margin = new Padding(3, 4, 3, 4);
            CBBairro.Name = "CBBairro";
            CBBairro.Size = new Size(322, 26);
            CBBairro.TabIndex = 11;
            // 
            // CBCidade
            // 
            CBCidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CBCidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            CBCidade.DropDownHeight = 200;
            CBCidade.Font = new Font("Consolas", 11F);
            CBCidade.ForeColor = Color.SteelBlue;
            CBCidade.FormattingEnabled = true;
            CBCidade.IntegralHeight = false;
            CBCidade.Location = new Point(377, 447);
            CBCidade.Margin = new Padding(3, 4, 3, 4);
            CBCidade.Name = "CBCidade";
            CBCidade.Size = new Size(481, 26);
            CBCidade.TabIndex = 12;
            // 
            // ImgCliente
            // 
            ImgCliente.BackColor = Color.Transparent;
            ImgCliente.ErrorImage = Properties.Resources.avatar_2092113_640;
            ImgCliente.Image = Properties.Resources.avatar_2092113_640;
            ImgCliente.ImageLocation = " ";
            ImgCliente.InitialImage = Properties.Resources.avatar_2092113_640;
            ImgCliente.Location = new Point(14, 4);
            ImgCliente.Margin = new Padding(3, 4, 3, 4);
            ImgCliente.Name = "ImgCliente";
            ImgCliente.Size = new Size(184, 247);
            ImgCliente.SizeMode = PictureBoxSizeMode.Zoom;
            ImgCliente.TabIndex = 10;
            ImgCliente.TabStop = false;
            // 
            // BTAddFoto
            // 
            BTAddFoto.BackColor = Color.SandyBrown;
            BTAddFoto.Cursor = Cursors.Hand;
            BTAddFoto.FlatAppearance.BorderSize = 0;
            BTAddFoto.FlatStyle = FlatStyle.Flat;
            BTAddFoto.Font = new Font("Consolas", 11F);
            BTAddFoto.ForeColor = Color.White;
            BTAddFoto.Image = (Image)resources.GetObject("BTAddFoto.Image");
            BTAddFoto.Location = new Point(19, 255);
            BTAddFoto.Margin = new Padding(3, 4, 3, 4);
            BTAddFoto.Name = "BTAddFoto";
            BTAddFoto.Size = new Size(119, 44);
            BTAddFoto.TabIndex = 21;
            BTAddFoto.TabStop = false;
            BTAddFoto.Text = "Foto";
            BTAddFoto.TextAlign = ContentAlignment.MiddleRight;
            BTAddFoto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTAddFoto.UseVisualStyleBackColor = false;
            BTAddFoto.Click += BTAddFoto_Click;
            // 
            // BTRemoverF
            // 
            BTRemoverF.BackColor = Color.Gray;
            BTRemoverF.Cursor = Cursors.Hand;
            BTRemoverF.FlatAppearance.BorderSize = 0;
            BTRemoverF.FlatStyle = FlatStyle.Flat;
            BTRemoverF.Font = new Font("Consolas", 11F);
            BTRemoverF.ForeColor = Color.White;
            BTRemoverF.Image = (Image)resources.GetObject("BTRemoverF.Image");
            BTRemoverF.Location = new Point(145, 255);
            BTRemoverF.Margin = new Padding(3, 4, 3, 4);
            BTRemoverF.Name = "BTRemoverF";
            BTRemoverF.Size = new Size(38, 44);
            BTRemoverF.TabIndex = 22;
            BTRemoverF.TabStop = false;
            BTRemoverF.TextAlign = ContentAlignment.MiddleRight;
            BTRemoverF.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTRemoverF.UseVisualStyleBackColor = false;
            BTRemoverF.Click += BTRemoverF_Click;
            // 
            // BTNovo
            // 
            BTNovo.BackColor = Color.RoyalBlue;
            BTNovo.Cursor = Cursors.Hand;
            BTNovo.FlatAppearance.BorderSize = 0;
            BTNovo.FlatStyle = FlatStyle.Flat;
            BTNovo.Font = new Font("Consolas", 11F);
            BTNovo.ForeColor = Color.White;
            BTNovo.Image = (Image)resources.GetObject("BTNovo.Image");
            BTNovo.Location = new Point(171, 815);
            BTNovo.Margin = new Padding(3, 4, 3, 4);
            BTNovo.Name = "BTNovo";
            BTNovo.Size = new Size(119, 44);
            BTNovo.TabIndex = 19;
            BTNovo.TabStop = false;
            BTNovo.Text = "Novo";
            BTNovo.TextAlign = ContentAlignment.MiddleRight;
            BTNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNovo.UseVisualStyleBackColor = false;
            BTNovo.Click += BTNovo_Click;
            // 
            // BTFechar
            // 
            BTFechar.BackColor = Color.MediumBlue;
            BTFechar.Cursor = Cursors.Hand;
            BTFechar.FlatAppearance.BorderSize = 0;
            BTFechar.FlatStyle = FlatStyle.Flat;
            BTFechar.Font = new Font("Consolas", 11F);
            BTFechar.ForeColor = Color.White;
            BTFechar.Image = (Image)resources.GetObject("BTFechar.Image");
            BTFechar.Location = new Point(42, 815);
            BTFechar.Margin = new Padding(3, 4, 3, 4);
            BTFechar.Name = "BTFechar";
            BTFechar.Size = new Size(119, 44);
            BTFechar.TabIndex = 18;
            BTFechar.TabStop = false;
            BTFechar.Text = "Fechar";
            BTFechar.TextAlign = ContentAlignment.MiddleRight;
            BTFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTFechar.UseVisualStyleBackColor = false;
            BTFechar.Click += BTFechar_Click;
            // 
            // BTSalvar
            // 
            BTSalvar.BackColor = Color.MediumBlue;
            BTSalvar.Cursor = Cursors.Hand;
            BTSalvar.FlatAppearance.BorderSize = 0;
            BTSalvar.FlatStyle = FlatStyle.Flat;
            BTSalvar.Font = new Font("Consolas", 11F);
            BTSalvar.ForeColor = Color.White;
            BTSalvar.Image = (Image)resources.GetObject("BTSalvar.Image");
            BTSalvar.Location = new Point(739, 815);
            BTSalvar.Margin = new Padding(3, 4, 3, 4);
            BTSalvar.Name = "BTSalvar";
            BTSalvar.Size = new Size(119, 44);
            BTSalvar.TabIndex = 20;
            BTSalvar.Text = "Salvar";
            BTSalvar.TextAlign = ContentAlignment.MiddleRight;
            BTSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTSalvar.UseVisualStyleBackColor = false;
            BTSalvar.Click += BTSalvar_Click;
            // 
            // cadclientes
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImage = Properties.Resources.granent_cadastro_client;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 942);
            Controls.Add(OpCPF);
            Controls.Add(OpCNPJ);
            Controls.Add(TextDoc);
            Controls.Add(BTRemoverF);
            Controls.Add(BTFechar);
            Controls.Add(BTSalvar);
            Controls.Add(BTNovo);
            Controls.Add(BTAddFoto);
            Controls.Add(ImgCliente);
            Controls.Add(CBCidade);
            Controls.Add(CBBairro);
            Controls.Add(CBEndereco);
            Controls.Add(CBEstadoCivil);
            Controls.Add(CBEstado);
            Controls.Add(GBGenero);
            Controls.Add(TextCelular);
            Controls.Add(TextCep);
            Controls.Add(TextDataNascimento);
            Controls.Add(TextRG);
            Controls.Add(CKSituacao);
            Controls.Add(label4);
            Controls.Add(label16);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(TextObservacoes);
            Controls.Add(TextEmail);
            Controls.Add(TextNumero);
            Controls.Add(textNome);
            Controls.Add(textCodigo);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Consolas", 11F);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "cadclientes";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            Load += Form1_Load;
            KeyDown += cadclientes_KeyDown;
            GBGenero.ResumeLayout(false);
            GBGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImgCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textNome;
        private TextBox TextNumero;
        private TextBox TextEmail;
        private TextBox TextObservacoes;
        private RadioButton OpCNPJ;
        private RadioButton OpM;
        private RadioButton OpOutros;
        private CheckBox CKSituacao;
        private MaskedTextBox TextDoc;
        private MaskedTextBox TextRG;
        private MaskedTextBox TextDataNascimento;
        private MaskedTextBox TextCep;
        private MaskedTextBox TextCelular;
        private RadioButton OpF;
        private RadioButton OpCPF;
        private GroupBox GBGenero;
        private Label label2;
        private ComboBox CBEstado;
        private ComboBox CBEstadoCivil;
        private ComboBox CBEndereco;
        private ComboBox CBBairro;
        private ComboBox CBCidade;
        private PictureBox ImgCliente;
        private Button BTAddFoto;
        private Button BTRemoverF;
        private Button BTNovo;
        private Button BTFechar;
        private Button BTSalvar;
        private readonly MaskInputRejectedEventHandler maskedTextBox1_MaskInputRejected;
        public TextBox textCodigo;
    }
}
