namespace Clube.Interfaces
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sócioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarMensalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSóciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verDependentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.verMensalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sócioToolStripMenuItem,
            this.dependenteToolStripMenuItem,
            this.mensalidadeToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sócioToolStripMenuItem
            // 
            this.sócioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pagarMensalidadeToolStripMenuItem,
            this.verSóciosToolStripMenuItem});
            this.sócioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.sócioToolStripMenuItem.Name = "sócioToolStripMenuItem";
            this.sócioToolStripMenuItem.Size = new System.Drawing.Size(83, 35);
            this.sócioToolStripMenuItem.Text = "Sócio";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(297, 36);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // pagarMensalidadeToolStripMenuItem
            // 
            this.pagarMensalidadeToolStripMenuItem.Name = "pagarMensalidadeToolStripMenuItem";
            this.pagarMensalidadeToolStripMenuItem.Size = new System.Drawing.Size(297, 36);
            this.pagarMensalidadeToolStripMenuItem.Text = "Pagar mensalidade";
            this.pagarMensalidadeToolStripMenuItem.Click += new System.EventHandler(this.pagarMensalidadeToolStripMenuItem_Click);
            // 
            // verSóciosToolStripMenuItem
            // 
            this.verSóciosToolStripMenuItem.Name = "verSóciosToolStripMenuItem";
            this.verSóciosToolStripMenuItem.Size = new System.Drawing.Size(297, 36);
            this.verSóciosToolStripMenuItem.Text = "Ver sócios";
            this.verSóciosToolStripMenuItem.Click += new System.EventHandler(this.verSóciosToolStripMenuItem_Click);
            // 
            // dependenteToolStripMenuItem
            // 
            this.dependenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.verDependentesToolStripMenuItem});
            this.dependenteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.dependenteToolStripMenuItem.Name = "dependenteToolStripMenuItem";
            this.dependenteToolStripMenuItem.Size = new System.Drawing.Size(154, 35);
            this.dependenteToolStripMenuItem.Text = "Dependente";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(275, 36);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // verDependentesToolStripMenuItem
            // 
            this.verDependentesToolStripMenuItem.Name = "verDependentesToolStripMenuItem";
            this.verDependentesToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.verDependentesToolStripMenuItem.Text = "Ver dependentes";
            this.verDependentesToolStripMenuItem.Click += new System.EventHandler(this.verDependentesToolStripMenuItem_Click_1);
            // 
            // mensalidadeToolStripMenuItem
            // 
            this.mensalidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem2,
            this.verMensalidadesToolStripMenuItem});
            this.mensalidadeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.mensalidadeToolStripMenuItem.Name = "mensalidadeToolStripMenuItem";
            this.mensalidadeToolStripMenuItem.Size = new System.Drawing.Size(160, 35);
            this.mensalidadeToolStripMenuItem.Text = "Mensalidade";
            // 
            // cadastrarToolStripMenuItem2
            // 
            this.cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            this.cadastrarToolStripMenuItem2.Size = new System.Drawing.Size(282, 36);
            this.cadastrarToolStripMenuItem2.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem2.Click += new System.EventHandler(this.cadastrarToolStripMenuItem2_Click);
            // 
            // verMensalidadesToolStripMenuItem
            // 
            this.verMensalidadesToolStripMenuItem.Name = "verMensalidadesToolStripMenuItem";
            this.verMensalidadesToolStripMenuItem.Size = new System.Drawing.Size(282, 36);
            this.verMensalidadesToolStripMenuItem.Text = "Ver mensalidades";
            this.verMensalidadesToolStripMenuItem.Click += new System.EventHandler(this.verMensalidadesToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarCategoriaToolStripMenuItem,
            this.listarCategoriasToolStripMenuItem});
            this.categoriaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(127, 35);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // cadastrarCategoriaToolStripMenuItem
            // 
            this.cadastrarCategoriaToolStripMenuItem.Name = "cadastrarCategoriaToolStripMenuItem";
            this.cadastrarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(302, 36);
            this.cadastrarCategoriaToolStripMenuItem.Text = "Cadastrar categoria";
            this.cadastrarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCategoriaToolStripMenuItem_Click);
            // 
            // listarCategoriasToolStripMenuItem
            // 
            this.listarCategoriasToolStripMenuItem.Name = "listarCategoriasToolStripMenuItem";
            this.listarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(302, 36);
            this.listarCategoriasToolStripMenuItem.Text = "Listar categorias";
            this.listarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.listarCategoriasToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(944, 603);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sócioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarMensalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dependenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mensalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem verDependentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verSóciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMensalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCategoriasToolStripMenuItem;
    }
}