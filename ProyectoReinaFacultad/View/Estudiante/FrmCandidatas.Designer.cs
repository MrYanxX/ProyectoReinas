namespace View
{
    partial class FrmCandidatas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCandidatas = new System.Windows.Forms.DataGridView();
            this.btnPortafolio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidatas
            // 
            this.dgvCandidatas.AllowUserToAddRows = false;
            this.dgvCandidatas.AllowUserToDeleteRows = false;
            this.dgvCandidatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatas.Location = new System.Drawing.Point(58, 65);
            this.dgvCandidatas.Name = "dgvCandidatas";
            this.dgvCandidatas.ReadOnly = true;
            this.dgvCandidatas.RowTemplate.Height = 150;
            this.dgvCandidatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatas.Size = new System.Drawing.Size(535, 419);
            this.dgvCandidatas.TabIndex = 1;
            this.dgvCandidatas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidatas_CellClick_1);
            this.dgvCandidatas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCandidatas_DataBindingComplete);
            // 
            // btnPortafolio
            // 
            this.btnPortafolio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPortafolio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPortafolio.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortafolio.Location = new System.Drawing.Point(663, 234);
            this.btnPortafolio.Name = "btnPortafolio";
            this.btnPortafolio.Size = new System.Drawing.Size(141, 26);
            this.btnPortafolio.TabIndex = 2;
            this.btnPortafolio.Text = "Ver Portafolio";
            this.btnPortafolio.UseVisualStyleBackColor = false;
            this.btnPortafolio.Click += new System.EventHandler(this.btnPortafolio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Candidatas a Reina y Miss Fotogenia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.reinalogotarea;
            this.pictureBox1.Location = new System.Drawing.Point(663, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCandidatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPortafolio);
            this.Controls.Add(this.dgvCandidatas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmCandidatas";
            this.Size = new System.Drawing.Size(936, 496);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidatas;
        private System.Windows.Forms.Button btnPortafolio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
