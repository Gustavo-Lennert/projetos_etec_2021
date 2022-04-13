namespace AplWFAMenu
{
    partial class frmMenuPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuitemCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastrosPessoas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastrosUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastrosAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastrosTiposCompromissos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemAplicativos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAplicativosWord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAplicativosExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAplicativosCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSairSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSairSistemaSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tspMenuPrincipal = new System.Windows.Forms.ToolStrip();
            this.tspbtnWord = new System.Windows.Forms.ToolStripButton();
            this.tspbtnExcel = new System.Windows.Forms.ToolStripButton();
            this.tspbtnCalculadora = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspbtnSair = new System.Windows.Forms.ToolStripButton();
            this.mnuPrincipal.SuspendLayout();
            this.tspMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuitemCadastros,
            this.mnuitemAplicativos,
            this.mnuSairSistema});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuPrincipal.Size = new System.Drawing.Size(785, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            this.mnuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuPrincipal_ItemClicked);
            // 
            // mnuitemCadastros
            // 
            this.mnuitemCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastrosPessoas,
            this.mnuCadastrosUsuarios,
            this.mnuCadastrosAgendamento,
            this.mnuCadastrosTiposCompromissos});
            this.mnuitemCadastros.Name = "mnuitemCadastros";
            this.mnuitemCadastros.Size = new System.Drawing.Size(71, 20);
            this.mnuitemCadastros.Text = "&Cadastros";
            this.mnuitemCadastros.Click += new System.EventHandler(this.mnuitemCadastros_Click);
            // 
            // mnuCadastrosPessoas
            // 
            this.mnuCadastrosPessoas.Name = "mnuCadastrosPessoas";
            this.mnuCadastrosPessoas.Size = new System.Drawing.Size(201, 22);
            this.mnuCadastrosPessoas.Text = "&Pessoas";
            this.mnuCadastrosPessoas.Click += new System.EventHandler(this.mnuCadastrosPessoas_Click);
            // 
            // mnuCadastrosUsuarios
            // 
            this.mnuCadastrosUsuarios.Name = "mnuCadastrosUsuarios";
            this.mnuCadastrosUsuarios.Size = new System.Drawing.Size(201, 22);
            this.mnuCadastrosUsuarios.Text = "&Usuários";
            // 
            // mnuCadastrosAgendamento
            // 
            this.mnuCadastrosAgendamento.Name = "mnuCadastrosAgendamento";
            this.mnuCadastrosAgendamento.Size = new System.Drawing.Size(201, 22);
            this.mnuCadastrosAgendamento.Text = "&Agendamento";
            // 
            // mnuCadastrosTiposCompromissos
            // 
            this.mnuCadastrosTiposCompromissos.Name = "mnuCadastrosTiposCompromissos";
            this.mnuCadastrosTiposCompromissos.Size = new System.Drawing.Size(201, 22);
            this.mnuCadastrosTiposCompromissos.Text = "&Tipos de Compromissos";
            // 
            // mnuitemAplicativos
            // 
            this.mnuitemAplicativos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAplicativosWord,
            this.mnuAplicativosExcel,
            this.mnuAplicativosCalculadora});
            this.mnuitemAplicativos.Name = "mnuitemAplicativos";
            this.mnuitemAplicativos.Size = new System.Drawing.Size(77, 20);
            this.mnuitemAplicativos.Text = "&Aplicativos";
            // 
            // mnuAplicativosWord
            // 
            this.mnuAplicativosWord.Name = "mnuAplicativosWord";
            this.mnuAplicativosWord.Size = new System.Drawing.Size(137, 22);
            this.mnuAplicativosWord.Text = "&Word";
            this.mnuAplicativosWord.Click += new System.EventHandler(this.mnuAplicativosWord_Click);
            // 
            // mnuAplicativosExcel
            // 
            this.mnuAplicativosExcel.Name = "mnuAplicativosExcel";
            this.mnuAplicativosExcel.Size = new System.Drawing.Size(137, 22);
            this.mnuAplicativosExcel.Text = "&Excel";
            this.mnuAplicativosExcel.Click += new System.EventHandler(this.mnuAplicativosExcel_Click);
            // 
            // mnuAplicativosCalculadora
            // 
            this.mnuAplicativosCalculadora.Name = "mnuAplicativosCalculadora";
            this.mnuAplicativosCalculadora.Size = new System.Drawing.Size(137, 22);
            this.mnuAplicativosCalculadora.Text = "&Calculadora";
            this.mnuAplicativosCalculadora.Click += new System.EventHandler(this.mnuAplicativosCalculadora_Click);
            // 
            // mnuSairSistema
            // 
            this.mnuSairSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSairSistemaSair});
            this.mnuSairSistema.Name = "mnuSairSistema";
            this.mnuSairSistema.Size = new System.Drawing.Size(99, 20);
            this.mnuSairSistema.Text = "&Sair do Sistema";
            // 
            // mnuSairSistemaSair
            // 
            this.mnuSairSistemaSair.Name = "mnuSairSistemaSair";
            this.mnuSairSistemaSair.Size = new System.Drawing.Size(93, 22);
            this.mnuSairSistemaSair.Text = "&Sair";
            this.mnuSairSistemaSair.Click += new System.EventHandler(this.mnuSairSistemaSair_Click);
            // 
            // tspMenuPrincipal
            // 
            this.tspMenuPrincipal.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tspMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbtnWord,
            this.tspbtnExcel,
            this.tspbtnCalculadora,
            this.toolStripSeparator1,
            this.tspbtnSair});
            this.tspMenuPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tspMenuPrincipal.Name = "tspMenuPrincipal";
            this.tspMenuPrincipal.Size = new System.Drawing.Size(785, 55);
            this.tspMenuPrincipal.TabIndex = 1;
            this.tspMenuPrincipal.Text = "toolStrip1";
            // 
            // tspbtnWord
            // 
            this.tspbtnWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspbtnWord.Image = global::AplWFAMenu.Properties.Resources.word;
            this.tspbtnWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspbtnWord.Name = "tspbtnWord";
            this.tspbtnWord.Size = new System.Drawing.Size(52, 52);
            this.tspbtnWord.Text = "toolStripButton1";
            this.tspbtnWord.Click += new System.EventHandler(this.tspbtnWord_Click);
            // 
            // tspbtnExcel
            // 
            this.tspbtnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspbtnExcel.Image = global::AplWFAMenu.Properties.Resources.excel;
            this.tspbtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspbtnExcel.Name = "tspbtnExcel";
            this.tspbtnExcel.Size = new System.Drawing.Size(52, 52);
            this.tspbtnExcel.Text = "toolStripButton1";
            this.tspbtnExcel.Click += new System.EventHandler(this.tspbtnExcel_Click);
            // 
            // tspbtnCalculadora
            // 
            this.tspbtnCalculadora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspbtnCalculadora.Image = global::AplWFAMenu.Properties.Resources.calculadora;
            this.tspbtnCalculadora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspbtnCalculadora.Name = "tspbtnCalculadora";
            this.tspbtnCalculadora.Size = new System.Drawing.Size(52, 52);
            this.tspbtnCalculadora.Text = "toolStripButton2";
            this.tspbtnCalculadora.Click += new System.EventHandler(this.tspbtnCalculadora_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tspbtnSair
            // 
            this.tspbtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspbtnSair.Image = global::AplWFAMenu.Properties.Resources.exit;
            this.tspbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspbtnSair.Name = "tspbtnSair";
            this.tspbtnSair.Size = new System.Drawing.Size(52, 52);
            this.tspbtnSair.Text = "toolStripButton3";
            this.tspbtnSair.Click += new System.EventHandler(this.tspbtnSair_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 505);
            this.ControlBox = false;
            this.Controls.Add(this.tspMenuPrincipal);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.tspMenuPrincipal.ResumeLayout(false);
            this.tspMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuitemAplicativos;
        private System.Windows.Forms.ToolStripMenuItem mnuAplicativosWord;
        private System.Windows.Forms.ToolStripMenuItem mnuAplicativosExcel;
        private System.Windows.Forms.ToolStripMenuItem mnuAplicativosCalculadora;
        private System.Windows.Forms.ToolStripMenuItem mnuSairSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuSairSistemaSair;
        private System.Windows.Forms.ToolStrip tspMenuPrincipal;
        private System.Windows.Forms.ToolStripButton tspbtnWord;
        private System.Windows.Forms.ToolStripButton tspbtnExcel;
        private System.Windows.Forms.ToolStripButton tspbtnCalculadora;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tspbtnSair;
        private System.Windows.Forms.ToolStripMenuItem mnuitemCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastrosPessoas;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastrosUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastrosAgendamento;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastrosTiposCompromissos;
    }
}