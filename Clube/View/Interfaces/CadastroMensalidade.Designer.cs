namespace Clube.Interfaces
{
    partial class CadastroMensalidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMensalidade));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataVencimento = new System.Windows.Forms.TextBox();
            this.txtDataPagamento = new System.Windows.Forms.TextBox();
            this.txtValorMensalidade = new System.Windows.Forms.TextBox();
            this.txtJurosAplicados = new System.Windows.Forms.TextBox();
            this.btnMensalidade = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-6, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 69);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(830, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "CADASTRO DE MENSALIDADE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "DATA VENCIMENTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "DATA PAGAMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "VALOR DA MENSALIDADE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "JUROS APLICADOS";
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVencimento.Location = new System.Drawing.Point(392, 138);
            this.txtDataVencimento.Multiline = true;
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(378, 38);
            this.txtDataVencimento.TabIndex = 20;
            // 
            // txtDataPagamento
            // 
            this.txtDataPagamento.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPagamento.Location = new System.Drawing.Point(392, 239);
            this.txtDataPagamento.Multiline = true;
            this.txtDataPagamento.Name = "txtDataPagamento";
            this.txtDataPagamento.Size = new System.Drawing.Size(378, 30);
            this.txtDataPagamento.TabIndex = 21;
            // 
            // txtValorMensalidade
            // 
            this.txtValorMensalidade.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMensalidade.Location = new System.Drawing.Point(392, 344);
            this.txtValorMensalidade.Multiline = true;
            this.txtValorMensalidade.Name = "txtValorMensalidade";
            this.txtValorMensalidade.Size = new System.Drawing.Size(378, 30);
            this.txtValorMensalidade.TabIndex = 22;
            // 
            // txtJurosAplicados
            // 
            this.txtJurosAplicados.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJurosAplicados.Location = new System.Drawing.Point(392, 453);
            this.txtJurosAplicados.Multiline = true;
            this.txtJurosAplicados.Name = "txtJurosAplicados";
            this.txtJurosAplicados.Size = new System.Drawing.Size(378, 30);
            this.txtJurosAplicados.TabIndex = 23;
            // 
            // btnMensalidade
            // 
            this.btnMensalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.btnMensalidade.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensalidade.Location = new System.Drawing.Point(428, 545);
            this.btnMensalidade.Name = "btnMensalidade";
            this.btnMensalidade.Size = new System.Drawing.Size(252, 63);
            this.btnMensalidade.TabIndex = 24;
            this.btnMensalidade.Text = "CADASTRAR";
            this.btnMensalidade.UseVisualStyleBackColor = false;
            this.btnMensalidade.Click += new System.EventHandler(this.btnMensalidade_Click);
            // 
            // CadastroMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 652);
            this.Controls.Add(this.btnMensalidade);
            this.Controls.Add(this.txtJurosAplicados);
            this.Controls.Add(this.txtValorMensalidade);
            this.Controls.Add(this.txtDataPagamento);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroMensalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroMensalidade";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataVencimento;
        private System.Windows.Forms.TextBox txtDataPagamento;
        private System.Windows.Forms.TextBox txtValorMensalidade;
        private System.Windows.Forms.TextBox txtJurosAplicados;
        private System.Windows.Forms.Button btnMensalidade;
    }
}