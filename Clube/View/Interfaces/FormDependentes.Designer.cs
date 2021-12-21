namespace Clube.Interfaces
{
    partial class FormDependentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDependentes));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.db_clubeDataSet = new Clube.db_clubeDataSet();
            this.dbclubeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentescoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_clubeDataSet2 = new Clube.db_clubeDataSet2();
            this.dependenteTableAdapter = new Clube.db_clubeDataSet2TableAdapters.dependenteTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_clubeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbclubeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_clubeDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 69);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(984, 14);
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
            this.label1.Location = new System.Drawing.Point(377, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "DEPENDENTES";
            // 
            // db_clubeDataSet
            // 
            this.db_clubeDataSet.DataSetName = "db_clubeDataSet";
            this.db_clubeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbclubeDataSetBindingSource
            // 
            this.dbclubeDataSetBindingSource.DataSource = this.db_clubeDataSet;
            this.dbclubeDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.numeroCartaoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.parentescoDataGridViewTextBoxColumn,
            this.idsocioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dependenteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 630);
            this.dataGridView1.TabIndex = 17;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroCartaoDataGridViewTextBoxColumn
            // 
            this.numeroCartaoDataGridViewTextBoxColumn.DataPropertyName = "numeroCartao";
            this.numeroCartaoDataGridViewTextBoxColumn.HeaderText = "numeroCartao";
            this.numeroCartaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroCartaoDataGridViewTextBoxColumn.Name = "numeroCartaoDataGridViewTextBoxColumn";
            this.numeroCartaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroCartaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentescoDataGridViewTextBoxColumn
            // 
            this.parentescoDataGridViewTextBoxColumn.DataPropertyName = "parentesco";
            this.parentescoDataGridViewTextBoxColumn.HeaderText = "parentesco";
            this.parentescoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentescoDataGridViewTextBoxColumn.Name = "parentescoDataGridViewTextBoxColumn";
            this.parentescoDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentescoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idsocioDataGridViewTextBoxColumn
            // 
            this.idsocioDataGridViewTextBoxColumn.DataPropertyName = "id_socio";
            this.idsocioDataGridViewTextBoxColumn.HeaderText = "id_socio";
            this.idsocioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idsocioDataGridViewTextBoxColumn.Name = "idsocioDataGridViewTextBoxColumn";
            this.idsocioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsocioDataGridViewTextBoxColumn.Width = 125;
            // 
            // dependenteBindingSource
            // 
            this.dependenteBindingSource.DataMember = "dependente";
            this.dependenteBindingSource.DataSource = this.db_clubeDataSet2;
            // 
            // db_clubeDataSet2
            // 
            this.db_clubeDataSet2.DataSetName = "db_clubeDataSet2";
            this.db_clubeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dependenteTableAdapter
            // 
            this.dependenteTableAdapter.ClearBeforeFill = true;
            // 
            // FormDependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 686);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormDependentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDependentes";
            this.Load += new System.EventHandler(this.FormDependentes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_clubeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbclubeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_clubeDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private db_clubeDataSet db_clubeDataSet;
        private System.Windows.Forms.BindingSource dbclubeDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_clubeDataSet2 db_clubeDataSet2;
        private System.Windows.Forms.BindingSource dependenteBindingSource;
        private db_clubeDataSet2TableAdapters.dependenteTableAdapter dependenteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCartaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentescoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsocioDataGridViewTextBoxColumn;
    }
}