namespace EditorTexto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip_Bar = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarRefazer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarDataEHora = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarQuebraLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomAmpliar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomReduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirBarraStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbarNovo = new System.Windows.Forms.ToolStripButton();
            this.toolbarAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolbarSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarFonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarAmpliar = new System.Windows.Forms.ToolStripButton();
            this.toolbarReduzir = new System.Windows.Forms.ToolStripButton();
            this.toolbarRestaturar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarAjuda = new System.Windows.Forms.ToolStripButton();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.menuStrip_Bar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Bar
            // 
            this.menuStrip_Bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mEditar,
            this.mFormatar,
            this.mExibir,
            this.mAjuda});
            this.menuStrip_Bar.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Bar.Name = "menuStrip_Bar";
            this.menuStrip_Bar.Size = new System.Drawing.Size(784, 24);
            this.menuStrip_Bar.TabIndex = 0;
            this.menuStrip_Bar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivoNovo,
            this.mArquivoNovaJanela,
            this.toolStripSeparator1,
            this.mArquivoAbrir,
            this.mArquivoSalvar,
            this.mArquivoSalvarComo,
            this.toolStripSeparator2,
            this.mArquivoSair});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(61, 20);
            this.mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            this.mArquivoNovo.Image = global::EditorTexto.Properties.Resources.new_document;
            this.mArquivoNovo.Name = "mArquivoNovo";
            this.mArquivoNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mArquivoNovo.Size = new System.Drawing.Size(211, 22);
            this.mArquivoNovo.Text = "Novo";
            this.mArquivoNovo.Click += new System.EventHandler(this.mArquivoNovo_Click);
            // 
            // mArquivoNovaJanela
            // 
            this.mArquivoNovaJanela.Image = global::EditorTexto.Properties.Resources.notes;
            this.mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            this.mArquivoNovaJanela.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mArquivoNovaJanela.Size = new System.Drawing.Size(211, 22);
            this.mArquivoNovaJanela.Text = "Nova janela";
            this.mArquivoNovaJanela.Click += new System.EventHandler(this.mArquivoNovaJanela_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // mArquivoAbrir
            // 
            this.mArquivoAbrir.Image = global::EditorTexto.Properties.Resources.folder;
            this.mArquivoAbrir.Name = "mArquivoAbrir";
            this.mArquivoAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mArquivoAbrir.Size = new System.Drawing.Size(211, 22);
            this.mArquivoAbrir.Text = "Abrir";
            this.mArquivoAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // mArquivoSalvar
            // 
            this.mArquivoSalvar.Image = global::EditorTexto.Properties.Resources.save;
            this.mArquivoSalvar.Name = "mArquivoSalvar";
            this.mArquivoSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvar.Size = new System.Drawing.Size(211, 22);
            this.mArquivoSalvar.Text = "Salvar";
            this.mArquivoSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // mArquivoSalvarComo
            // 
            this.mArquivoSalvarComo.Image = global::EditorTexto.Properties.Resources.save;
            this.mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            this.mArquivoSalvarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvarComo.Size = new System.Drawing.Size(211, 22);
            this.mArquivoSalvarComo.Text = "Salvar como";
            this.mArquivoSalvarComo.Click += new System.EventHandler(this.mArquivoSalvarComo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
            // 
            // mArquivoSair
            // 
            this.mArquivoSair.Image = global::EditorTexto.Properties.Resources.exit;
            this.mArquivoSair.Name = "mArquivoSair";
            this.mArquivoSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mArquivoSair.Size = new System.Drawing.Size(211, 22);
            this.mArquivoSair.Text = "Sair";
            this.mArquivoSair.Click += new System.EventHandler(this.mArquivoSair_Click);
            // 
            // mEditar
            // 
            this.mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditarDesfazer,
            this.mEditarRefazer,
            this.toolStripSeparator3,
            this.mEditarRecortar,
            this.mEditarCopiar,
            this.mEditarColar,
            this.mEditarExcluir,
            this.toolStripSeparator4,
            this.mEditarDataEHora});
            this.mEditar.Name = "mEditar";
            this.mEditar.Size = new System.Drawing.Size(49, 20);
            this.mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            this.mEditarDesfazer.Name = "mEditarDesfazer";
            this.mEditarDesfazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditarDesfazer.Size = new System.Drawing.Size(159, 22);
            this.mEditarDesfazer.Text = "Desfazer";
            this.mEditarDesfazer.Click += new System.EventHandler(this.mEditarDesfazer_Click);
            // 
            // mEditarRefazer
            // 
            this.mEditarRefazer.Name = "mEditarRefazer";
            this.mEditarRefazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mEditarRefazer.Size = new System.Drawing.Size(159, 22);
            this.mEditarRefazer.Text = "Refazer";
            this.mEditarRefazer.Click += new System.EventHandler(this.mEditarRefazer_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(156, 6);
            // 
            // mEditarRecortar
            // 
            this.mEditarRecortar.Name = "mEditarRecortar";
            this.mEditarRecortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditarRecortar.Size = new System.Drawing.Size(159, 22);
            this.mEditarRecortar.Text = "Recortar";
            this.mEditarRecortar.Click += new System.EventHandler(this.mEditarRecortar_Click);
            // 
            // mEditarCopiar
            // 
            this.mEditarCopiar.Name = "mEditarCopiar";
            this.mEditarCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditarCopiar.Size = new System.Drawing.Size(159, 22);
            this.mEditarCopiar.Text = "Copiar";
            this.mEditarCopiar.Click += new System.EventHandler(this.mEditarCopiar_Click);
            // 
            // mEditarColar
            // 
            this.mEditarColar.Name = "mEditarColar";
            this.mEditarColar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditarColar.Size = new System.Drawing.Size(159, 22);
            this.mEditarColar.Text = "Colar";
            this.mEditarColar.Click += new System.EventHandler(this.mEditarColar_Click);
            // 
            // mEditarExcluir
            // 
            this.mEditarExcluir.Name = "mEditarExcluir";
            this.mEditarExcluir.ShortcutKeyDisplayString = "Delete";
            this.mEditarExcluir.Size = new System.Drawing.Size(159, 22);
            this.mEditarExcluir.Text = "Excluir";
            this.mEditarExcluir.Click += new System.EventHandler(this.mEditarExcluir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(156, 6);
            // 
            // mEditarDataEHora
            // 
            this.mEditarDataEHora.Name = "mEditarDataEHora";
            this.mEditarDataEHora.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mEditarDataEHora.Size = new System.Drawing.Size(159, 22);
            this.mEditarDataEHora.Text = "Data e hora";
            this.mEditarDataEHora.Click += new System.EventHandler(this.mEditarDataEHora_Click);
            // 
            // mFormatar
            // 
            this.mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatarQuebraLinha,
            this.mFormatarFonte});
            this.mFormatar.Name = "mFormatar";
            this.mFormatar.Size = new System.Drawing.Size(67, 20);
            this.mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebraLinha
            // 
            this.mFormatarQuebraLinha.CheckOnClick = true;
            this.mFormatarQuebraLinha.Name = "mFormatarQuebraLinha";
            this.mFormatarQuebraLinha.Size = new System.Drawing.Size(221, 22);
            this.mFormatarQuebraLinha.Text = "Quebra automática de linha";
            this.mFormatarQuebraLinha.Click += new System.EventHandler(this.mFormatarQuebraLinha_Click);
            // 
            // mFormatarFonte
            // 
            this.mFormatarFonte.Name = "mFormatarFonte";
            this.mFormatarFonte.Size = new System.Drawing.Size(221, 22);
            this.mFormatarFonte.Text = "Fonte";
            this.mFormatarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // mExibir
            // 
            this.mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoom,
            this.mExibirBarraStatus});
            this.mExibir.Name = "mExibir";
            this.mExibir.Size = new System.Drawing.Size(48, 20);
            this.mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            this.mExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoomAmpliar,
            this.mExibirZoomReduzir,
            this.mExibirZoomRestaurar});
            this.mExibirZoom.Name = "mExibirZoom";
            this.mExibirZoom.Size = new System.Drawing.Size(151, 22);
            this.mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomAmpliar
            // 
            this.mExibirZoomAmpliar.Image = global::EditorTexto.Properties.Resources.zoom;
            this.mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
            this.mExibirZoomAmpliar.ShortcutKeyDisplayString = "Ctrl + +";
            this.mExibirZoomAmpliar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.mExibirZoomAmpliar.Size = new System.Drawing.Size(164, 22);
            this.mExibirZoomAmpliar.Text = "Ampliar";
            this.mExibirZoomAmpliar.Click += new System.EventHandler(this.mExibirZoomAmpliar_Click);
            // 
            // mExibirZoomReduzir
            // 
            this.mExibirZoomReduzir.Image = global::EditorTexto.Properties.Resources.zoom;
            this.mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            this.mExibirZoomReduzir.ShortcutKeyDisplayString = "Ctrl + -";
            this.mExibirZoomReduzir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.mExibirZoomReduzir.Size = new System.Drawing.Size(164, 22);
            this.mExibirZoomReduzir.Text = "Reduzir";
            this.mExibirZoomReduzir.Click += new System.EventHandler(this.mExibirZoomReduzir_Click);
            // 
            // mExibirZoomRestaurar
            // 
            this.mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            this.mExibirZoomRestaurar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.mExibirZoomRestaurar.Size = new System.Drawing.Size(164, 22);
            this.mExibirZoomRestaurar.Text = "Restaurar";
            this.mExibirZoomRestaurar.Click += new System.EventHandler(this.mExibirZoomRestaurar_Click);
            // 
            // mExibirBarraStatus
            // 
            this.mExibirBarraStatus.Checked = true;
            this.mExibirBarraStatus.CheckOnClick = true;
            this.mExibirBarraStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mExibirBarraStatus.Name = "mExibirBarraStatus";
            this.mExibirBarraStatus.Size = new System.Drawing.Size(151, 22);
            this.mExibirBarraStatus.Text = "Barra de status";
            this.mExibirBarraStatus.Click += new System.EventHandler(this.mExibirBarraStatus_Click);
            // 
            // mAjuda
            // 
            this.mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaExibir,
            this.mAjudaSobre});
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(50, 20);
            this.mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibir
            // 
            this.mAjudaExibir.Image = global::EditorTexto.Properties.Resources.help;
            this.mAjudaExibir.Name = "mAjudaExibir";
            this.mAjudaExibir.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mAjudaExibir.Size = new System.Drawing.Size(194, 22);
            this.mAjudaExibir.Text = "Exibir ajuda";
            this.mAjudaExibir.Click += new System.EventHandler(this.mAjudaExibir_Click);
            // 
            // mAjudaSobre
            // 
            this.mAjudaSobre.Name = "mAjudaSobre";
            this.mAjudaSobre.Size = new System.Drawing.Size(194, 22);
            this.mAjudaSobre.Text = "Sobre o editor de texto";
            this.mAjudaSobre.Click += new System.EventHandler(this.mAjudaSobre_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 539);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(38, 17);
            this.statusBarLabel.Text = "100 %";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarNovo,
            this.toolbarAbrir,
            this.toolbarSalvar,
            this.toolStripSeparator5,
            this.toolbarFonte,
            this.toolStripSeparator6,
            this.toolbarAmpliar,
            this.toolbarReduzir,
            this.toolbarRestaturar,
            this.toolStripSeparator7,
            this.toolbarAjuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolbarNovo
            // 
            this.toolbarNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbarNovo.Image = global::EditorTexto.Properties.Resources.new_document;
            this.toolbarNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarNovo.Name = "toolbarNovo";
            this.toolbarNovo.Size = new System.Drawing.Size(23, 22);
            this.toolbarNovo.Text = "Novo";
            this.toolbarNovo.Click += new System.EventHandler(this.mArquivoNovo_Click);
            // 
            // toolbarAbrir
            // 
            this.toolbarAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbarAbrir.Image = global::EditorTexto.Properties.Resources.folder;
            this.toolbarAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarAbrir.Name = "toolbarAbrir";
            this.toolbarAbrir.Size = new System.Drawing.Size(23, 22);
            this.toolbarAbrir.Text = "Abrir";
            this.toolbarAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // toolbarSalvar
            // 
            this.toolbarSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbarSalvar.Image = global::EditorTexto.Properties.Resources.save;
            this.toolbarSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarSalvar.Name = "toolbarSalvar";
            this.toolbarSalvar.Size = new System.Drawing.Size(23, 22);
            this.toolbarSalvar.Text = "Salvar";
            this.toolbarSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbarFonte
            // 
            this.toolbarFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarFonte.Font = new System.Drawing.Font("Stencil", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.toolbarFonte.Image = ((System.Drawing.Image)(resources.GetObject("toolbarFonte.Image")));
            this.toolbarFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarFonte.Name = "toolbarFonte";
            this.toolbarFonte.Size = new System.Drawing.Size(23, 22);
            this.toolbarFonte.Text = "A";
            this.toolbarFonte.ToolTipText = "Formatar fonte";
            this.toolbarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbarAmpliar
            // 
            this.toolbarAmpliar.Image = global::EditorTexto.Properties.Resources.zoom;
            this.toolbarAmpliar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarAmpliar.Name = "toolbarAmpliar";
            this.toolbarAmpliar.Size = new System.Drawing.Size(35, 22);
            this.toolbarAmpliar.Text = "+";
            this.toolbarAmpliar.ToolTipText = "Ampliar";
            this.toolbarAmpliar.Click += new System.EventHandler(this.mExibirZoomAmpliar_Click);
            // 
            // toolbarReduzir
            // 
            this.toolbarReduzir.Image = global::EditorTexto.Properties.Resources.zoom1;
            this.toolbarReduzir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarReduzir.Name = "toolbarReduzir";
            this.toolbarReduzir.Size = new System.Drawing.Size(32, 22);
            this.toolbarReduzir.Text = "-";
            this.toolbarReduzir.ToolTipText = "Reduzir";
            this.toolbarReduzir.Click += new System.EventHandler(this.mExibirZoomReduzir_Click);
            // 
            // toolbarRestaturar
            // 
            this.toolbarRestaturar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbarRestaturar.Image = global::EditorTexto.Properties.Resources.zoom;
            this.toolbarRestaturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarRestaturar.Name = "toolbarRestaturar";
            this.toolbarRestaturar.Size = new System.Drawing.Size(23, 22);
            this.toolbarRestaturar.Text = "Restaurar";
            this.toolbarRestaturar.Click += new System.EventHandler(this.mExibirZoomRestaurar_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbarAjuda
            // 
            this.toolbarAjuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbarAjuda.Image = global::EditorTexto.Properties.Resources.help;
            this.toolbarAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarAjuda.Name = "toolbarAjuda";
            this.toolbarAjuda.Size = new System.Drawing.Size(23, 22);
            this.toolbarAjuda.Text = "Ajuda";
            this.toolbarAjuda.Click += new System.EventHandler(this.mAjudaExibir_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConteudo.Location = new System.Drawing.Point(0, 49);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(784, 490);
            this.txtConteudo.TabIndex = 4;
            this.txtConteudo.Text = "";
            this.txtConteudo.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip_Bar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Bar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de texto";
            this.menuStrip_Bar.ResumeLayout(false);
            this.menuStrip_Bar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip_Bar;
        private ToolStripMenuItem mArquivo;
        private ToolStripMenuItem mArquivoNovo;
        private ToolStripMenuItem mArquivoNovaJanela;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mArquivoAbrir;
        private ToolStripMenuItem mArquivoSalvar;
        private ToolStripMenuItem mArquivoSalvarComo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mArquivoSair;
        private ToolStripMenuItem mEditar;
        private ToolStripMenuItem mEditarDesfazer;
        private ToolStripMenuItem mEditarRefazer;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mEditarRecortar;
        private ToolStripMenuItem mEditarCopiar;
        private ToolStripMenuItem mEditarColar;
        private ToolStripMenuItem mEditarExcluir;
        private ToolStripMenuItem mFormatar;
        private ToolStripMenuItem mExibir;
        private ToolStripMenuItem mAjuda;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mEditarDataEHora;
        private ToolStripMenuItem mFormatarQuebraLinha;
        private ToolStripMenuItem mFormatarFonte;
        private ToolStripMenuItem mExibirZoom;
        private ToolStripMenuItem mExibirZoomAmpliar;
        private ToolStripMenuItem mExibirZoomReduzir;
        private ToolStripMenuItem mExibirZoomRestaurar;
        private ToolStripMenuItem mExibirBarraStatus;
        private ToolStripMenuItem mAjudaExibir;
        private ToolStripMenuItem mAjudaSobre;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusBarLabel;
        private ToolStrip toolStrip1;
        private RichTextBox txtConteudo;
        private ToolStripButton toolbarNovo;
        private ToolStripButton toolbarAbrir;
        private ToolStripButton toolbarSalvar;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolbarFonte;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolbarAmpliar;
        private ToolStripButton toolbarReduzir;
        private ToolStripButton toolbarRestaturar;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolbarAjuda;
    }
}