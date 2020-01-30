namespace SistemaPet
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.pictlogo = new System.Windows.Forms.PictureBox();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelSidebarBunifu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelSubRelatorio = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton13 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuRelatorio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSubValores = new System.Windows.Forms.Panel();
            this.bunifuFlatButton18 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuValores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSubMenuServico = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuServicos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSubMenuCadastrar = new System.Windows.Forms.Panel();
            this.btnMenuAnimal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuServiços = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuFuncionario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuFuncao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuCadastro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuT = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelSideBarhost = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.bunifuTLog = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.panelWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictlogo)).BeginInit();
            this.panelSidebarBunifu.SuspendLayout();
            this.panelSubRelatorio.SuspendLayout();
            this.panelSubValores.SuspendLayout();
            this.panelSubMenuServico.SuspendLayout();
            this.panelSubMenuCadastrar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideBarhost.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(89)))));
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.minimizar);
            this.panelTop.Controls.Add(this.Fechar);
            this.bunifuTLog.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 50);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // pictureBox2
            // 
            this.bunifuT.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(757, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuT.SetDecoration(this.minimizar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.minimizar, BunifuAnimatorNS.DecorationType.None);
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(1006, 4);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(40, 40);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 7;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click_1);
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuT.SetDecoration(this.Fechar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.Fechar, BunifuAnimatorNS.DecorationType.None);
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(1052, 4);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(40, 40);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fechar.TabIndex = 5;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // panelWrapper
            // 
            this.panelWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWrapper.BackColor = System.Drawing.Color.Transparent;
            this.panelWrapper.Controls.Add(this.pictlogo);
            this.bunifuTLog.SetDecoration(this.panelWrapper, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelWrapper, BunifuAnimatorNS.DecorationType.None);
            this.panelWrapper.Location = new System.Drawing.Point(220, 50);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(880, 629);
            this.panelWrapper.TabIndex = 2;
            // 
            // pictlogo
            // 
            this.pictlogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuT.SetDecoration(this.pictlogo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.pictlogo, BunifuAnimatorNS.DecorationType.None);
            this.pictlogo.Image = ((System.Drawing.Image)(resources.GetObject("pictlogo.Image")));
            this.pictlogo.Location = new System.Drawing.Point(179, 28);
            this.pictlogo.Name = "pictlogo";
            this.pictlogo.Size = new System.Drawing.Size(570, 580);
            this.pictlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictlogo.TabIndex = 0;
            this.pictlogo.TabStop = false;
            this.pictlogo.Visible = false;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 15;
            this.bunifuElipse.TargetControl = this.panelSidebarBunifu;
            // 
            // panelSidebarBunifu
            // 
            this.panelSidebarBunifu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSidebarBunifu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSidebarBunifu.BackgroundImage")));
            this.panelSidebarBunifu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSidebarBunifu.Controls.Add(this.panelSubRelatorio);
            this.panelSidebarBunifu.Controls.Add(this.btnMenuRelatorio);
            this.panelSidebarBunifu.Controls.Add(this.panelSubValores);
            this.panelSidebarBunifu.Controls.Add(this.btnMenuValores);
            this.panelSidebarBunifu.Controls.Add(this.panelSubMenuServico);
            this.panelSidebarBunifu.Controls.Add(this.btnMenuServicos);
            this.panelSidebarBunifu.Controls.Add(this.panelSubMenuCadastrar);
            this.panelSidebarBunifu.Controls.Add(this.btnMenuCadastro);
            this.panelSidebarBunifu.Controls.Add(this.panel1);
            this.bunifuTLog.SetDecoration(this.panelSidebarBunifu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSidebarBunifu, BunifuAnimatorNS.DecorationType.None);
            this.panelSidebarBunifu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(135)))), ((int)(((byte)(52)))));
            this.panelSidebarBunifu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(135)))), ((int)(((byte)(52)))));
            this.panelSidebarBunifu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(135)))), ((int)(((byte)(52)))));
            this.panelSidebarBunifu.GradientTopRight = System.Drawing.Color.Black;
            this.panelSidebarBunifu.Location = new System.Drawing.Point(5, 6);
            this.panelSidebarBunifu.Name = "panelSidebarBunifu";
            this.panelSidebarBunifu.Quality = 10;
            this.panelSidebarBunifu.Size = new System.Drawing.Size(210, 632);
            this.panelSidebarBunifu.TabIndex = 0;
            // 
            // panelSubRelatorio
            // 
            this.panelSubRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.panelSubRelatorio.Controls.Add(this.bunifuFlatButton3);
            this.panelSubRelatorio.Controls.Add(this.bunifuFlatButton2);
            this.panelSubRelatorio.Controls.Add(this.bunifuFlatButton13);
            this.bunifuTLog.SetDecoration(this.panelSubRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSubRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.panelSubRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubRelatorio.Location = new System.Drawing.Point(0, 557);
            this.panelSubRelatorio.Name = "panelSubRelatorio";
            this.panelSubRelatorio.Size = new System.Drawing.Size(210, 110);
            this.panelSubRelatorio.TabIndex = 21;
            this.panelSubRelatorio.Visible = false;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     OS";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 30);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.Text = "     OS";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // bunifuFlatButton13
            // 
            this.bunifuFlatButton13.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton13.BorderRadius = 0;
            this.bunifuFlatButton13.ButtonText = "     Clientes";
            this.bunifuFlatButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton13.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton13.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton13.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.Iconimage = null;
            this.bunifuFlatButton13.Iconimage_right = null;
            this.bunifuFlatButton13.Iconimage_right_Selected = null;
            this.bunifuFlatButton13.Iconimage_Selected = null;
            this.bunifuFlatButton13.IconMarginLeft = 0;
            this.bunifuFlatButton13.IconMarginRight = 0;
            this.bunifuFlatButton13.IconRightVisible = true;
            this.bunifuFlatButton13.IconRightZoom = 0D;
            this.bunifuFlatButton13.IconVisible = true;
            this.bunifuFlatButton13.IconZoom = 60D;
            this.bunifuFlatButton13.IsTab = false;
            this.bunifuFlatButton13.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton13.Name = "bunifuFlatButton13";
            this.bunifuFlatButton13.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton13.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton13.selected = false;
            this.bunifuFlatButton13.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton13.TabIndex = 4;
            this.bunifuFlatButton13.Text = "     Clientes";
            this.bunifuFlatButton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton13.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton13.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton13.Click += new System.EventHandler(this.bunifuFlatButton13_Click);
            // 
            // btnMenuRelatorio
            // 
            this.btnMenuRelatorio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuRelatorio.BorderRadius = 0;
            this.btnMenuRelatorio.ButtonText = "RELATÓRIOS";
            this.btnMenuRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuRelatorio, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuRelatorio.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuRelatorio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuRelatorio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuRelatorio.Iconimage")));
            this.btnMenuRelatorio.Iconimage_right = null;
            this.btnMenuRelatorio.Iconimage_right_Selected = null;
            this.btnMenuRelatorio.Iconimage_Selected = null;
            this.btnMenuRelatorio.IconMarginLeft = 0;
            this.btnMenuRelatorio.IconMarginRight = 0;
            this.btnMenuRelatorio.IconRightVisible = true;
            this.btnMenuRelatorio.IconRightZoom = 0D;
            this.btnMenuRelatorio.IconVisible = true;
            this.btnMenuRelatorio.IconZoom = 60D;
            this.btnMenuRelatorio.IsTab = false;
            this.btnMenuRelatorio.Location = new System.Drawing.Point(0, 509);
            this.btnMenuRelatorio.Name = "btnMenuRelatorio";
            this.btnMenuRelatorio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuRelatorio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuRelatorio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuRelatorio.selected = false;
            this.btnMenuRelatorio.Size = new System.Drawing.Size(210, 48);
            this.btnMenuRelatorio.TabIndex = 20;
            this.btnMenuRelatorio.Text = "RELATÓRIOS";
            this.btnMenuRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuRelatorio.Textcolor = System.Drawing.Color.White;
            this.btnMenuRelatorio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRelatorio.Click += new System.EventHandler(this.btnMenuRelatorio_Click);
            // 
            // panelSubValores
            // 
            this.panelSubValores.BackColor = System.Drawing.Color.Transparent;
            this.panelSubValores.Controls.Add(this.bunifuFlatButton18);
            this.bunifuTLog.SetDecoration(this.panelSubValores, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSubValores, BunifuAnimatorNS.DecorationType.None);
            this.panelSubValores.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubValores.Location = new System.Drawing.Point(0, 471);
            this.panelSubValores.Name = "panelSubValores";
            this.panelSubValores.Size = new System.Drawing.Size(210, 38);
            this.panelSubValores.TabIndex = 15;
            this.panelSubValores.Visible = false;
            // 
            // bunifuFlatButton18
            // 
            this.bunifuFlatButton18.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton18.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton18.BorderRadius = 0;
            this.bunifuFlatButton18.ButtonText = "     Recibo";
            this.bunifuFlatButton18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton18, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton18, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton18.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton18.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton18.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton18.Iconimage = null;
            this.bunifuFlatButton18.Iconimage_right = null;
            this.bunifuFlatButton18.Iconimage_right_Selected = null;
            this.bunifuFlatButton18.Iconimage_Selected = null;
            this.bunifuFlatButton18.IconMarginLeft = 0;
            this.bunifuFlatButton18.IconMarginRight = 0;
            this.bunifuFlatButton18.IconRightVisible = true;
            this.bunifuFlatButton18.IconRightZoom = 0D;
            this.bunifuFlatButton18.IconVisible = true;
            this.bunifuFlatButton18.IconZoom = 60D;
            this.bunifuFlatButton18.IsTab = false;
            this.bunifuFlatButton18.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton18.Name = "bunifuFlatButton18";
            this.bunifuFlatButton18.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton18.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton18.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton18.selected = false;
            this.bunifuFlatButton18.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton18.TabIndex = 3;
            this.bunifuFlatButton18.Text = "     Recibo";
            this.bunifuFlatButton18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton18.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton18.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton18.Click += new System.EventHandler(this.bunifuFlatButton18_Click_1);
            // 
            // btnMenuValores
            // 
            this.btnMenuValores.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuValores.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuValores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuValores.BorderRadius = 0;
            this.btnMenuValores.ButtonText = "VALORES";
            this.btnMenuValores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuValores, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuValores, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuValores.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuValores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuValores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuValores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuValores.Iconimage")));
            this.btnMenuValores.Iconimage_right = null;
            this.btnMenuValores.Iconimage_right_Selected = null;
            this.btnMenuValores.Iconimage_Selected = null;
            this.btnMenuValores.IconMarginLeft = 0;
            this.btnMenuValores.IconMarginRight = 0;
            this.btnMenuValores.IconRightVisible = true;
            this.btnMenuValores.IconRightZoom = 0D;
            this.btnMenuValores.IconVisible = true;
            this.btnMenuValores.IconZoom = 60D;
            this.btnMenuValores.IsTab = false;
            this.btnMenuValores.Location = new System.Drawing.Point(0, 423);
            this.btnMenuValores.Name = "btnMenuValores";
            this.btnMenuValores.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuValores.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuValores.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuValores.selected = false;
            this.btnMenuValores.Size = new System.Drawing.Size(210, 48);
            this.btnMenuValores.TabIndex = 14;
            this.btnMenuValores.Text = "VALORES";
            this.btnMenuValores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuValores.Textcolor = System.Drawing.Color.White;
            this.btnMenuValores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuValores.Click += new System.EventHandler(this.btnMenuValores_Click);
            // 
            // panelSubMenuServico
            // 
            this.panelSubMenuServico.BackColor = System.Drawing.Color.Transparent;
            this.panelSubMenuServico.Controls.Add(this.bunifuFlatButton1);
            this.bunifuTLog.SetDecoration(this.panelSubMenuServico, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSubMenuServico, BunifuAnimatorNS.DecorationType.None);
            this.panelSubMenuServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuServico.Location = new System.Drawing.Point(0, 383);
            this.panelSubMenuServico.Name = "panelSubMenuServico";
            this.panelSubMenuServico.Size = new System.Drawing.Size(210, 40);
            this.panelSubMenuServico.TabIndex = 13;
            this.panelSubMenuServico.Visible = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     OS - Órdem de Serviço";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "     OS - Órdem de Serviço";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // btnMenuServicos
            // 
            this.btnMenuServicos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuServicos.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuServicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuServicos.BorderRadius = 0;
            this.btnMenuServicos.ButtonText = "SEVIÇOS";
            this.btnMenuServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuServicos, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuServicos, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuServicos.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuServicos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuServicos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuServicos.Iconimage")));
            this.btnMenuServicos.Iconimage_right = null;
            this.btnMenuServicos.Iconimage_right_Selected = null;
            this.btnMenuServicos.Iconimage_Selected = null;
            this.btnMenuServicos.IconMarginLeft = 0;
            this.btnMenuServicos.IconMarginRight = 0;
            this.btnMenuServicos.IconRightVisible = true;
            this.btnMenuServicos.IconRightZoom = 0D;
            this.btnMenuServicos.IconVisible = true;
            this.btnMenuServicos.IconZoom = 60D;
            this.btnMenuServicos.IsTab = false;
            this.btnMenuServicos.Location = new System.Drawing.Point(0, 335);
            this.btnMenuServicos.Name = "btnMenuServicos";
            this.btnMenuServicos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuServicos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuServicos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuServicos.selected = false;
            this.btnMenuServicos.Size = new System.Drawing.Size(210, 48);
            this.btnMenuServicos.TabIndex = 12;
            this.btnMenuServicos.Text = "SEVIÇOS";
            this.btnMenuServicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuServicos.Textcolor = System.Drawing.Color.White;
            this.btnMenuServicos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuServicos.Click += new System.EventHandler(this.btnMenuServicos_Click);
            // 
            // panelSubMenuCadastrar
            // 
            this.panelSubMenuCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.panelSubMenuCadastrar.Controls.Add(this.btnMenuAnimal);
            this.panelSubMenuCadastrar.Controls.Add(this.btnMenuServiços);
            this.panelSubMenuCadastrar.Controls.Add(this.btnMenuClientes);
            this.panelSubMenuCadastrar.Controls.Add(this.btnMenuFuncionario);
            this.panelSubMenuCadastrar.Controls.Add(this.btnMenuUsuario);
            this.panelSubMenuCadastrar.Controls.Add(this.btnMenuFuncao);
            this.bunifuTLog.SetDecoration(this.panelSubMenuCadastrar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSubMenuCadastrar, BunifuAnimatorNS.DecorationType.None);
            this.panelSubMenuCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCadastrar.Location = new System.Drawing.Point(0, 150);
            this.panelSubMenuCadastrar.Name = "panelSubMenuCadastrar";
            this.panelSubMenuCadastrar.Size = new System.Drawing.Size(210, 185);
            this.panelSubMenuCadastrar.TabIndex = 2;
            this.panelSubMenuCadastrar.Visible = false;
            // 
            // btnMenuAnimal
            // 
            this.btnMenuAnimal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuAnimal.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuAnimal.BorderRadius = 0;
            this.btnMenuAnimal.ButtonText = "     Animal";
            this.btnMenuAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuAnimal, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuAnimal, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuAnimal.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuAnimal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuAnimal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuAnimal.Iconimage = null;
            this.btnMenuAnimal.Iconimage_right = null;
            this.btnMenuAnimal.Iconimage_right_Selected = null;
            this.btnMenuAnimal.Iconimage_Selected = null;
            this.btnMenuAnimal.IconMarginLeft = 0;
            this.btnMenuAnimal.IconMarginRight = 0;
            this.btnMenuAnimal.IconRightVisible = true;
            this.btnMenuAnimal.IconRightZoom = 0D;
            this.btnMenuAnimal.IconVisible = true;
            this.btnMenuAnimal.IconZoom = 60D;
            this.btnMenuAnimal.IsTab = false;
            this.btnMenuAnimal.Location = new System.Drawing.Point(0, 150);
            this.btnMenuAnimal.Name = "btnMenuAnimal";
            this.btnMenuAnimal.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuAnimal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuAnimal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuAnimal.selected = false;
            this.btnMenuAnimal.Size = new System.Drawing.Size(210, 30);
            this.btnMenuAnimal.TabIndex = 12;
            this.btnMenuAnimal.Text = "     Animal";
            this.btnMenuAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAnimal.Textcolor = System.Drawing.Color.White;
            this.btnMenuAnimal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAnimal.Click += new System.EventHandler(this.btnMenuAnimal_Click);
            // 
            // btnMenuServiços
            // 
            this.btnMenuServiços.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuServiços.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuServiços.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuServiços.BorderRadius = 0;
            this.btnMenuServiços.ButtonText = "     Serviço";
            this.btnMenuServiços.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuServiços, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuServiços, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuServiços.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuServiços.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuServiços.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuServiços.Iconimage = null;
            this.btnMenuServiços.Iconimage_right = null;
            this.btnMenuServiços.Iconimage_right_Selected = null;
            this.btnMenuServiços.Iconimage_Selected = null;
            this.btnMenuServiços.IconMarginLeft = 0;
            this.btnMenuServiços.IconMarginRight = 0;
            this.btnMenuServiços.IconRightVisible = true;
            this.btnMenuServiços.IconRightZoom = 0D;
            this.btnMenuServiços.IconVisible = true;
            this.btnMenuServiços.IconZoom = 60D;
            this.btnMenuServiços.IsTab = false;
            this.btnMenuServiços.Location = new System.Drawing.Point(0, 120);
            this.btnMenuServiços.Name = "btnMenuServiços";
            this.btnMenuServiços.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuServiços.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuServiços.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuServiços.selected = false;
            this.btnMenuServiços.Size = new System.Drawing.Size(210, 30);
            this.btnMenuServiços.TabIndex = 11;
            this.btnMenuServiços.Text = "     Serviço";
            this.btnMenuServiços.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuServiços.Textcolor = System.Drawing.Color.White;
            this.btnMenuServiços.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuServiços.Click += new System.EventHandler(this.btnMenuServiços_Click);
            // 
            // btnMenuClientes
            // 
            this.btnMenuClientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuClientes.BorderRadius = 0;
            this.btnMenuClientes.ButtonText = "     Cliente";
            this.btnMenuClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuClientes, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuClientes.Iconimage = null;
            this.btnMenuClientes.Iconimage_right = null;
            this.btnMenuClientes.Iconimage_right_Selected = null;
            this.btnMenuClientes.Iconimage_Selected = null;
            this.btnMenuClientes.IconMarginLeft = 0;
            this.btnMenuClientes.IconMarginRight = 0;
            this.btnMenuClientes.IconRightVisible = true;
            this.btnMenuClientes.IconRightZoom = 0D;
            this.btnMenuClientes.IconVisible = true;
            this.btnMenuClientes.IconZoom = 60D;
            this.btnMenuClientes.IsTab = false;
            this.btnMenuClientes.Location = new System.Drawing.Point(0, 90);
            this.btnMenuClientes.Name = "btnMenuClientes";
            this.btnMenuClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuClientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuClientes.selected = false;
            this.btnMenuClientes.Size = new System.Drawing.Size(210, 30);
            this.btnMenuClientes.TabIndex = 9;
            this.btnMenuClientes.Text = "     Cliente";
            this.btnMenuClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuClientes.Textcolor = System.Drawing.Color.White;
            this.btnMenuClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuClientes.Click += new System.EventHandler(this.btnMenuClientes_Click);
            // 
            // btnMenuFuncionario
            // 
            this.btnMenuFuncionario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuFuncionario.BorderRadius = 0;
            this.btnMenuFuncionario.ButtonText = "     Funcionário";
            this.btnMenuFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuFuncionario, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuFuncionario, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuFuncionario.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuFuncionario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuFuncionario.Iconimage = null;
            this.btnMenuFuncionario.Iconimage_right = null;
            this.btnMenuFuncionario.Iconimage_right_Selected = null;
            this.btnMenuFuncionario.Iconimage_Selected = null;
            this.btnMenuFuncionario.IconMarginLeft = 0;
            this.btnMenuFuncionario.IconMarginRight = 0;
            this.btnMenuFuncionario.IconRightVisible = true;
            this.btnMenuFuncionario.IconRightZoom = 0D;
            this.btnMenuFuncionario.IconVisible = true;
            this.btnMenuFuncionario.IconZoom = 60D;
            this.btnMenuFuncionario.IsTab = false;
            this.btnMenuFuncionario.Location = new System.Drawing.Point(0, 60);
            this.btnMenuFuncionario.Name = "btnMenuFuncionario";
            this.btnMenuFuncionario.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuFuncionario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuFuncionario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuFuncionario.selected = false;
            this.btnMenuFuncionario.Size = new System.Drawing.Size(210, 30);
            this.btnMenuFuncionario.TabIndex = 8;
            this.btnMenuFuncionario.Text = "     Funcionário";
            this.btnMenuFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFuncionario.Textcolor = System.Drawing.Color.White;
            this.btnMenuFuncionario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFuncionario.Click += new System.EventHandler(this.btnMenuFuncionario_Click);
            // 
            // btnMenuUsuario
            // 
            this.btnMenuUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuUsuario.BorderRadius = 0;
            this.btnMenuUsuario.ButtonText = "     Usuário";
            this.btnMenuUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuUsuario, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuUsuario, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuUsuario.Iconimage = null;
            this.btnMenuUsuario.Iconimage_right = null;
            this.btnMenuUsuario.Iconimage_right_Selected = null;
            this.btnMenuUsuario.Iconimage_Selected = null;
            this.btnMenuUsuario.IconMarginLeft = 0;
            this.btnMenuUsuario.IconMarginRight = 0;
            this.btnMenuUsuario.IconRightVisible = true;
            this.btnMenuUsuario.IconRightZoom = 0D;
            this.btnMenuUsuario.IconVisible = true;
            this.btnMenuUsuario.IconZoom = 60D;
            this.btnMenuUsuario.IsTab = false;
            this.btnMenuUsuario.Location = new System.Drawing.Point(0, 30);
            this.btnMenuUsuario.Name = "btnMenuUsuario";
            this.btnMenuUsuario.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuUsuario.selected = false;
            this.btnMenuUsuario.Size = new System.Drawing.Size(210, 30);
            this.btnMenuUsuario.TabIndex = 7;
            this.btnMenuUsuario.Text = "     Usuário";
            this.btnMenuUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUsuario.Textcolor = System.Drawing.Color.White;
            this.btnMenuUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUsuario.Click += new System.EventHandler(this.btnMenuUsuario_Click);
            // 
            // btnMenuFuncao
            // 
            this.btnMenuFuncao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuFuncao.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuFuncao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuFuncao.BorderRadius = 0;
            this.btnMenuFuncao.ButtonText = "     Função";
            this.btnMenuFuncao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuFuncao, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuFuncao, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuFuncao.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuFuncao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuFuncao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuFuncao.Iconimage = null;
            this.btnMenuFuncao.Iconimage_right = null;
            this.btnMenuFuncao.Iconimage_right_Selected = null;
            this.btnMenuFuncao.Iconimage_Selected = null;
            this.btnMenuFuncao.IconMarginLeft = 0;
            this.btnMenuFuncao.IconMarginRight = 0;
            this.btnMenuFuncao.IconRightVisible = true;
            this.btnMenuFuncao.IconRightZoom = 0D;
            this.btnMenuFuncao.IconVisible = true;
            this.btnMenuFuncao.IconZoom = 60D;
            this.btnMenuFuncao.IsTab = false;
            this.btnMenuFuncao.Location = new System.Drawing.Point(0, 0);
            this.btnMenuFuncao.Name = "btnMenuFuncao";
            this.btnMenuFuncao.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuFuncao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuFuncao.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuFuncao.selected = false;
            this.btnMenuFuncao.Size = new System.Drawing.Size(210, 30);
            this.btnMenuFuncao.TabIndex = 4;
            this.btnMenuFuncao.Text = "     Função";
            this.btnMenuFuncao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFuncao.Textcolor = System.Drawing.Color.White;
            this.btnMenuFuncao.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFuncao.Click += new System.EventHandler(this.btnMenuFuncao_Click);
            // 
            // btnMenuCadastro
            // 
            this.btnMenuCadastro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.btnMenuCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuCadastro.BorderRadius = 0;
            this.btnMenuCadastro.ButtonText = "CADASTRO";
            this.btnMenuCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.btnMenuCadastro, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.btnMenuCadastro, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuCadastro.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCadastro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuCadastro.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuCadastro.Iconimage")));
            this.btnMenuCadastro.Iconimage_right = null;
            this.btnMenuCadastro.Iconimage_right_Selected = null;
            this.btnMenuCadastro.Iconimage_Selected = null;
            this.btnMenuCadastro.IconMarginLeft = 0;
            this.btnMenuCadastro.IconMarginRight = 0;
            this.btnMenuCadastro.IconRightVisible = true;
            this.btnMenuCadastro.IconRightZoom = 0D;
            this.btnMenuCadastro.IconVisible = true;
            this.btnMenuCadastro.IconZoom = 60D;
            this.btnMenuCadastro.IsTab = false;
            this.btnMenuCadastro.Location = new System.Drawing.Point(0, 102);
            this.btnMenuCadastro.Name = "btnMenuCadastro";
            this.btnMenuCadastro.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenuCadastro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.btnMenuCadastro.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuCadastro.selected = false;
            this.btnMenuCadastro.Size = new System.Drawing.Size(210, 48);
            this.btnMenuCadastro.TabIndex = 1;
            this.btnMenuCadastro.Text = "CADASTRO";
            this.btnMenuCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuCadastro.Textcolor = System.Drawing.Color.White;
            this.btnMenuCadastro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCadastro.Click += new System.EventHandler(this.btnMenuCadastro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.bunifuTLog.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 102);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(70, 42);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(70, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.bunifuT.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTLog.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 87);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(192, 11);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuT
            // 
            this.bunifuT.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuT.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuT.DefaultAnimation = animation3;
            this.bunifuT.MaxAnimationTime = 3500;
            // 
            // panelSideBarhost
            // 
            this.panelSideBarhost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(101)))), ((int)(((byte)(39)))));
            this.panelSideBarhost.Controls.Add(this.panelSidebarBunifu);
            this.bunifuTLog.SetDecoration(this.panelSideBarhost, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panelSideBarhost, BunifuAnimatorNS.DecorationType.None);
            this.panelSideBarhost.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBarhost.Location = new System.Drawing.Point(0, 50);
            this.panelSideBarhost.Name = "panelSideBarhost";
            this.panelSideBarhost.Size = new System.Drawing.Size(220, 650);
            this.panelSideBarhost.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.bunifuTLog.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(220, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 25);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuT.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(620, 17);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // bunifuTLog
            // 
            this.bunifuTLog.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.bunifuTLog.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0.5F;
            animation4.RotateLimit = 0.2F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTLog.DefaultAnimation = animation4;
            this.bunifuTLog.TimeStep = 0.01F;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(75)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "     Recibos";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuT.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTLog.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 60D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 60);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(47)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(210, 30);
            this.bunifuFlatButton3.TabIndex = 6;
            this.bunifuFlatButton3.Text = "     Recibos";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelWrapper);
            this.Controls.Add(this.panelSideBarhost);
            this.Controls.Add(this.panelTop);
            this.bunifuTLog.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuT.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.panelWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictlogo)).EndInit();
            this.panelSidebarBunifu.ResumeLayout(false);
            this.panelSubRelatorio.ResumeLayout(false);
            this.panelSubValores.ResumeLayout(false);
            this.panelSubMenuServico.ResumeLayout(false);
            this.panelSubMenuCadastrar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideBarhost.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelWrapper;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private BunifuAnimatorNS.BunifuTransition bunifuT;
        private System.Windows.Forms.PictureBox pictlogo;
        private BunifuAnimatorNS.BunifuTransition bunifuTLog;
        private Bunifu.Framework.UI.BunifuGradientPanel panelSidebarBunifu;
        private System.Windows.Forms.Panel panelSubMenuCadastrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuFuncao;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuCadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSideBarhost;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuServicos;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuFuncionario;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuUsuario;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuAnimal;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuServiços;
        private System.Windows.Forms.Panel panelSubMenuServico;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelSubRelatorio;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton13;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuRelatorio;
        private System.Windows.Forms.Panel panelSubValores;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton18;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuValores;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
    }
}

