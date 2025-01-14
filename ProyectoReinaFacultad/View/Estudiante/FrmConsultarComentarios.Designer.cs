namespace View
{
    partial class FrmConsultarComentarios
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
            this.txtNombreCandidata = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pbFoto1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lbNombre = new System.Windows.Forms.Label();
            this.dgvCandidatas = new System.Windows.Forms.DataGridView();
            this.pbFoto2 = new System.Windows.Forms.PictureBox();
            this.pbFoto3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCandidata
            // 
            this.txtNombreCandidata.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCandidata.Location = new System.Drawing.Point(22, 33);
            this.txtNombreCandidata.Name = "txtNombreCandidata";
            this.txtNombreCandidata.Size = new System.Drawing.Size(214, 22);
            this.txtNombreCandidata.TabIndex = 43;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(266, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 20);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pbFoto1
            // 
            this.pbFoto1.Location = new System.Drawing.Point(22, 196);
            this.pbFoto1.Name = "pbFoto1";
            this.pbFoto1.Size = new System.Drawing.Size(110, 111);
            this.pbFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto1.TabIndex = 16;
            this.pbFoto1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 47;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(313, 313);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 48;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(591, 313);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 49;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(19, 17);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(49, 14);
            this.lbNombre.TabIndex = 50;
            this.lbNombre.Text = "Nombre";
            // 
            // dgvCandidatas
            // 
            this.dgvCandidatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatas.Location = new System.Drawing.Point(22, 59);
            this.dgvCandidatas.Name = "dgvCandidatas";
            this.dgvCandidatas.Size = new System.Drawing.Size(809, 115);
            this.dgvCandidatas.TabIndex = 51;
            this.dgvCandidatas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCandidatas_DataBindingComplete);
            // 
            // pbFoto2
            // 
            this.pbFoto2.Location = new System.Drawing.Point(313, 196);
            this.pbFoto2.Name = "pbFoto2";
            this.pbFoto2.Size = new System.Drawing.Size(110, 111);
            this.pbFoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto2.TabIndex = 52;
            this.pbFoto2.TabStop = false;
            // 
            // pbFoto3
            // 
            this.pbFoto3.Location = new System.Drawing.Point(591, 196);
            this.pbFoto3.Name = "pbFoto3";
            this.pbFoto3.Size = new System.Drawing.Size(110, 111);
            this.pbFoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto3.TabIndex = 53;
            this.pbFoto3.TabStop = false;
            // 
            // FrmConsultarComentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbFoto3);
            this.Controls.Add(this.pbFoto2);
            this.Controls.Add(this.dgvCandidatas);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbFoto1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreCandidata);
            this.Name = "FrmConsultarComentarios";
            this.Size = new System.Drawing.Size(865, 493);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreCandidata;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pbFoto1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.DataGridView dgvCandidatas;
        private System.Windows.Forms.PictureBox pbFoto2;
        private System.Windows.Forms.PictureBox pbFoto3;
    }
}
