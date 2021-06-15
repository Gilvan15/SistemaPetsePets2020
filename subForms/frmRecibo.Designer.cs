namespace SistemaPet.subForms
{
    partial class frmRecibo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecibo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmitente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textAssinatura = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textCnpj = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textRecebemosde = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.textImportanciade1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.textImportanciade2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textReferentea1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textReferentea2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPesquisar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textNumeroRecibo = new System.Windows.Forms.TextBox();
            this.textValorRecibo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboPrinter1 = new System.Windows.Forms.ComboBox();
            this.btnFecharRecibo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPrepararImpressao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dbpetsepetsDataSet = new SistemaPet.dbpetsepetsDataSet();
            this.dbpetsepetsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelSelecionePrint = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbpetsepetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpetsepetsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Emitente:";
            // 
            // textEmitente
            // 
            this.textEmitente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmitente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmitente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textEmitente.HintForeColor = System.Drawing.Color.Empty;
            this.textEmitente.HintText = "";
            this.textEmitente.isPassword = false;
            this.textEmitente.LineFocusedColor = System.Drawing.Color.Blue;
            this.textEmitente.LineIdleColor = System.Drawing.Color.Gray;
            this.textEmitente.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textEmitente.LineThickness = 4;
            this.textEmitente.Location = new System.Drawing.Point(98, 363);
            this.textEmitente.Margin = new System.Windows.Forms.Padding(4);
            this.textEmitente.Name = "textEmitente";
            this.textEmitente.Size = new System.Drawing.Size(389, 33);
            this.textEmitente.TabIndex = 6;
            this.textEmitente.Text = "PETS & PETS RAÇÕES E ACESSÓRIOS";
            this.textEmitente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textAssinatura
            // 
            this.textAssinatura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textAssinatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAssinatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textAssinatura.HintForeColor = System.Drawing.Color.Empty;
            this.textAssinatura.HintText = "";
            this.textAssinatura.isPassword = false;
            this.textAssinatura.LineFocusedColor = System.Drawing.Color.Blue;
            this.textAssinatura.LineIdleColor = System.Drawing.Color.Gray;
            this.textAssinatura.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textAssinatura.LineThickness = 4;
            this.textAssinatura.Location = new System.Drawing.Point(110, 437);
            this.textAssinatura.Margin = new System.Windows.Forms.Padding(4);
            this.textAssinatura.Name = "textAssinatura";
            this.textAssinatura.Size = new System.Drawing.Size(377, 33);
            this.textAssinatura.TabIndex = 89;
            this.textAssinatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Assinatura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "CNPJ:";
            // 
            // textCnpj
            // 
            this.textCnpj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textCnpj.HintForeColor = System.Drawing.Color.Empty;
            this.textCnpj.HintText = "";
            this.textCnpj.isPassword = false;
            this.textCnpj.LineFocusedColor = System.Drawing.Color.Blue;
            this.textCnpj.LineIdleColor = System.Drawing.Color.Gray;
            this.textCnpj.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textCnpj.LineThickness = 4;
            this.textCnpj.Location = new System.Drawing.Point(546, 363);
            this.textCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.textCnpj.Name = "textCnpj";
            this.textCnpj.Size = new System.Drawing.Size(297, 33);
            this.textCnpj.TabIndex = 7;
            this.textCnpj.Text = "33.555.177/0001-03";
            this.textCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(43, 10);
            this.bunifuCustomLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(210, 22);
            this.bunifuCustomLabel8.TabIndex = 70;
            this.bunifuCustomLabel8.Text = "- Pets e Pets: RECIBO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Recebi(emos) de";
            // 
            // textRecebemosde
            // 
            this.textRecebemosde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textRecebemosde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRecebemosde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textRecebemosde.HintForeColor = System.Drawing.Color.Empty;
            this.textRecebemosde.HintText = "";
            this.textRecebemosde.isPassword = false;
            this.textRecebemosde.LineFocusedColor = System.Drawing.Color.Blue;
            this.textRecebemosde.LineIdleColor = System.Drawing.Color.Gray;
            this.textRecebemosde.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textRecebemosde.LineThickness = 4;
            this.textRecebemosde.Location = new System.Drawing.Point(156, 78);
            this.textRecebemosde.Margin = new System.Windows.Forms.Padding(4);
            this.textRecebemosde.Name = "textRecebemosde";
            this.textRecebemosde.Size = new System.Drawing.Size(687, 33);
            this.textRecebemosde.TabIndex = 2;
            this.textRecebemosde.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textRecebemosde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRecebemosde_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "a importância de R$";
            // 
            // textImportanciade1
            // 
            this.textImportanciade1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textImportanciade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textImportanciade1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textImportanciade1.HintForeColor = System.Drawing.Color.Empty;
            this.textImportanciade1.HintText = "";
            this.textImportanciade1.isPassword = false;
            this.textImportanciade1.LineFocusedColor = System.Drawing.Color.Blue;
            this.textImportanciade1.LineIdleColor = System.Drawing.Color.Gray;
            this.textImportanciade1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textImportanciade1.LineThickness = 4;
            this.textImportanciade1.Location = new System.Drawing.Point(156, 131);
            this.textImportanciade1.Margin = new System.Windows.Forms.Padding(4);
            this.textImportanciade1.Name = "textImportanciade1";
            this.textImportanciade1.Size = new System.Drawing.Size(687, 33);
            this.textImportanciade1.TabIndex = 3;
            this.textImportanciade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textImportanciade1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textImportanciade1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "referente a";
            // 
            // textImportanciade2
            // 
            this.textImportanciade2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textImportanciade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textImportanciade2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textImportanciade2.HintForeColor = System.Drawing.Color.Empty;
            this.textImportanciade2.HintText = "";
            this.textImportanciade2.isPassword = false;
            this.textImportanciade2.LineFocusedColor = System.Drawing.Color.Blue;
            this.textImportanciade2.LineIdleColor = System.Drawing.Color.Gray;
            this.textImportanciade2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textImportanciade2.LineThickness = 4;
            this.textImportanciade2.Location = new System.Drawing.Point(23, 184);
            this.textImportanciade2.Margin = new System.Windows.Forms.Padding(4);
            this.textImportanciade2.Name = "textImportanciade2";
            this.textImportanciade2.Size = new System.Drawing.Size(820, 33);
            this.textImportanciade2.TabIndex = 4;
            this.textImportanciade2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textImportanciade2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textImportanciade2_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(302, 10);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(30, 22);
            this.bunifuCustomLabel1.TabIndex = 80;
            this.bunifuCustomLabel1.Text = "Nº";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(628, 10);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(65, 22);
            this.bunifuCustomLabel2.TabIndex = 83;
            this.bunifuCustomLabel2.Text = "Valor:";
            // 
            // textReferentea1
            // 
            this.textReferentea1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textReferentea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReferentea1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textReferentea1.HintForeColor = System.Drawing.Color.Empty;
            this.textReferentea1.HintText = "";
            this.textReferentea1.isPassword = false;
            this.textReferentea1.LineFocusedColor = System.Drawing.Color.Blue;
            this.textReferentea1.LineIdleColor = System.Drawing.Color.Gray;
            this.textReferentea1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textReferentea1.LineThickness = 4;
            this.textReferentea1.Location = new System.Drawing.Point(113, 238);
            this.textReferentea1.Margin = new System.Windows.Forms.Padding(4);
            this.textReferentea1.Name = "textReferentea1";
            this.textReferentea1.Size = new System.Drawing.Size(730, 33);
            this.textReferentea1.TabIndex = 5;
            this.textReferentea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textReferentea1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textReferentea1_KeyPress);
            // 
            // textReferentea2
            // 
            this.textReferentea2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textReferentea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReferentea2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textReferentea2.HintForeColor = System.Drawing.Color.Empty;
            this.textReferentea2.HintText = "";
            this.textReferentea2.isPassword = false;
            this.textReferentea2.LineFocusedColor = System.Drawing.Color.Blue;
            this.textReferentea2.LineIdleColor = System.Drawing.Color.Gray;
            this.textReferentea2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textReferentea2.LineThickness = 4;
            this.textReferentea2.Location = new System.Drawing.Point(23, 294);
            this.textReferentea2.Margin = new System.Windows.Forms.Padding(4);
            this.textReferentea2.Name = "textReferentea2";
            this.textReferentea2.Size = new System.Drawing.Size(820, 33);
            this.textReferentea2.TabIndex = 6;
            this.textReferentea2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textReferentea2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textReferentea2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 92;
            this.label7.Text = "Data de Emissão:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(152, 542);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(59, 20);
            this.lbldata.TabIndex = 93;
            this.lbldata.Text = "lblData";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textNumeroRecibo);
            this.panel1.Controls.Add(this.textValorRecibo);
            this.panel1.Controls.Add(this.lbldata);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textReferentea2);
            this.panel1.Controls.Add(this.textReferentea1);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.textAssinatura);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textCnpj);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.textImportanciade2);
            this.panel1.Controls.Add(this.textEmitente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textImportanciade1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textRecebemosde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(134, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 576);
            this.panel1.TabIndex = 98;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.textPesquisar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(251, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 76);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar - Nome";
            this.groupBox1.Visible = false;
            // 
            // textPesquisar
            // 
            this.textPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPesquisar.HintForeColor = System.Drawing.Color.Empty;
            this.textPesquisar.HintText = "";
            this.textPesquisar.isPassword = false;
            this.textPesquisar.LineFocusedColor = System.Drawing.Color.Blue;
            this.textPesquisar.LineIdleColor = System.Drawing.Color.Gray;
            this.textPesquisar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textPesquisar.LineThickness = 3;
            this.textPesquisar.Location = new System.Drawing.Point(60, 26);
            this.textPesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.textPesquisar.Name = "textPesquisar";
            this.textPesquisar.Size = new System.Drawing.Size(357, 35);
            this.textPesquisar.TabIndex = 112;
            this.textPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPesquisar.OnValueChanged += new System.EventHandler(this.textPesquisar_OnValueChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // textNumeroRecibo
            // 
            this.textNumeroRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroRecibo.Location = new System.Drawing.Point(339, 3);
            this.textNumeroRecibo.Name = "textNumeroRecibo";
            this.textNumeroRecibo.Size = new System.Drawing.Size(148, 29);
            this.textNumeroRecibo.TabIndex = 0;
            // 
            // textValorRecibo
            // 
            this.textValorRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValorRecibo.Location = new System.Drawing.Point(689, 3);
            this.textValorRecibo.Name = "textValorRecibo";
            this.textValorRecibo.Size = new System.Drawing.Size(154, 29);
            this.textValorRecibo.TabIndex = 1;
            this.textValorRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textValorRecibo.TextChanged += new System.EventHandler(this.textValorRecibo_TextChanged_1);
            this.textValorRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textValorRecibo_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(537, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 172);
            this.panel3.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 15);
            this.label10.TabIndex = 104;
            this.label10.Text = "Email: contato@petsepetsam.com.br";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 15);
            this.label9.TabIndex = 103;
            this.label9.Text = "Fone: (92) 98433-8895";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 15);
            this.label8.TabIndex = 102;
            this.label8.Text = "End: Rua Júlio Ribeiro 362 Bairro: Compensa";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(87, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 101;
            this.pictureBox3.TabStop = false;
            // 
            // comboPrinter1
            // 
            this.comboPrinter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboPrinter1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboPrinter1.FormattingEnabled = true;
            this.comboPrinter1.Items.AddRange(new object[] {
            "SELECIONE UMA IMPRESSORA"});
            this.comboPrinter1.Location = new System.Drawing.Point(695, 598);
            this.comboPrinter1.Name = "comboPrinter1";
            this.comboPrinter1.Size = new System.Drawing.Size(201, 21);
            this.comboPrinter1.TabIndex = 119;
            this.comboPrinter1.Visible = false;
            // 
            // btnFecharRecibo
            // 
            this.btnFecharRecibo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(89)))));
            this.btnFecharRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharRecibo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnFecharRecibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnFecharRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharRecibo.ForeColor = System.Drawing.Color.White;
            this.btnFecharRecibo.Location = new System.Drawing.Point(900, 596);
            this.btnFecharRecibo.Name = "btnFecharRecibo";
            this.btnFecharRecibo.Size = new System.Drawing.Size(113, 25);
            this.btnFecharRecibo.TabIndex = 117;
            this.btnFecharRecibo.Text = "Fechar Recibo";
            this.btnFecharRecibo.UseVisualStyleBackColor = false;
            this.btnFecharRecibo.Visible = false;
            this.btnFecharRecibo.Click += new System.EventHandler(this.btnFecharRecibo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(89)))));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(1019, 596);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(82, 25);
            this.btnImprimir.TabIndex = 116;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Controls.Add(this.btnPrepararImpressao);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Location = new System.Drawing.Point(1034, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 253);
            this.panel2.TabIndex = 104;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(89)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(3, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(87, 30);
            this.btnNovo.TabIndex = 115;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPrepararImpressao
            // 
            this.btnPrepararImpressao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(89)))));
            this.btnPrepararImpressao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrepararImpressao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnPrepararImpressao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnPrepararImpressao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrepararImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrepararImpressao.ForeColor = System.Drawing.Color.White;
            this.btnPrepararImpressao.Location = new System.Drawing.Point(2, 203);
            this.btnPrepararImpressao.Name = "btnPrepararImpressao";
            this.btnPrepararImpressao.Size = new System.Drawing.Size(88, 44);
            this.btnPrepararImpressao.TabIndex = 114;
            this.btnPrepararImpressao.Text = "Preparar Impressão";
            this.btnPrepararImpressao.UseVisualStyleBackColor = false;
            this.btnPrepararImpressao.Click += new System.EventHandler(this.btnPrepararImpressao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(89)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(3, 163);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 30);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(89)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(3, 83);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 30);
            this.btnEditar.TabIndex = 112;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(89)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(3, 123);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 30);
            this.btnPesquisar.TabIndex = 111;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(89)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(3, 43);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 30);
            this.btnLimpar.TabIndex = 108;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dbpetsepetsDataSet
            // 
            this.dbpetsepetsDataSet.DataSetName = "dbpetsepetsDataSet";
            this.dbpetsepetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbpetsepetsDataSetBindingSource
            // 
            this.dbpetsepetsDataSetBindingSource.DataSource = this.dbpetsepetsDataSet;
            this.dbpetsepetsDataSetBindingSource.Position = 0;
            // 
            // labelSelecionePrint
            // 
            this.labelSelecionePrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelecionePrint.AutoSize = true;
            this.labelSelecionePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelecionePrint.Location = new System.Drawing.Point(501, 601);
            this.labelSelecionePrint.Name = "labelSelecionePrint";
            this.labelSelecionePrint.Size = new System.Drawing.Size(191, 15);
            this.labelSelecionePrint.TabIndex = 105;
            this.labelSelecionePrint.Text = "Selecione uma Impressora >";
            this.labelSelecionePrint.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 594);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 182);
            this.dataGridView1.TabIndex = 120;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // frmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 788);
            this.Controls.Add(this.labelSelecionePrint);
            this.Controls.Add(this.comboPrinter1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnFecharRecibo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecibo";
            this.Load += new System.EventHandler(this.frmRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbpetsepetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpetsepetsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textEmitente;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textAssinatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textCnpj;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textRecebemosde;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textImportanciade1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textImportanciade2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textReferentea1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textReferentea2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textValorRecibo;
        private System.Windows.Forms.BindingSource dbpetsepetsDataSetBindingSource;
        private SistemaPet.dbpetsepetsDataSet dbpetsepetsDataSet;
        private System.Windows.Forms.TextBox textNumeroRecibo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPrepararImpressao;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFecharRecibo;
        private System.Windows.Forms.ComboBox comboPrinter1;
        private System.Windows.Forms.Label labelSelecionePrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}