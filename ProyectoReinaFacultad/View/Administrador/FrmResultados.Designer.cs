using System.Windows.Forms;

namespace View
{
    partial class FrmResultados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvCandidatas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVotosFotogenia = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellidoFotogenia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreFotogenia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblVotosReina = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidoReina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreReina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFotoFotogenia = new System.Windows.Forms.PictureBox();
            this.pbFotoReina = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCandidatas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoFotogenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoReina)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvCandidatas);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Location = new System.Drawing.Point(21, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtgvCandidatas
            // 
            this.dtgvCandidatas.AllowUserToAddRows = false;
            this.dtgvCandidatas.AllowUserToDeleteRows = false;
            this.dtgvCandidatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCandidatas.Location = new System.Drawing.Point(10, 58);
            this.dtgvCandidatas.Name = "dtgvCandidatas";
            this.dtgvCandidatas.ReadOnly = true;
            this.dtgvCandidatas.RowTemplate.Height = 100;
            this.dtgvCandidatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCandidatas.Size = new System.Drawing.Size(477, 371);
            this.dtgvCandidatas.TabIndex = 3;
            this.dtgvCandidatas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgvCandidatas_DataBindingComplete);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(236, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cédula";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(6, 31);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(211, 22);
            this.txtCedula.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVotosFotogenia);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtApellidoFotogenia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNombreFotogenia);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.pbFotoFotogenia);
            this.groupBox2.Controls.Add(this.lblVotosReina);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtApellidoReina);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNombreReina);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pbFotoReina);
            this.groupBox2.Location = new System.Drawing.Point(537, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 452);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblVotosFotogenia
            // 
            this.lblVotosFotogenia.AutoSize = true;
            this.lblVotosFotogenia.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotosFotogenia.Location = new System.Drawing.Point(217, 372);
            this.lblVotosFotogenia.Name = "lblVotosFotogenia";
            this.lblVotosFotogenia.Size = new System.Drawing.Size(81, 41);
            this.lblVotosFotogenia.TabIndex = 17;
            this.lblVotosFotogenia.Text = "000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(172, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Votos Obtenidos:";
            // 
            // txtApellidoFotogenia
            // 
            this.txtApellidoFotogenia.Enabled = false;
            this.txtApellidoFotogenia.Location = new System.Drawing.Point(175, 325);
            this.txtApellidoFotogenia.Name = "txtApellidoFotogenia";
            this.txtApellidoFotogenia.Size = new System.Drawing.Size(164, 20);
            this.txtApellidoFotogenia.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(172, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "Apellido";
            // 
            // txtNombreFotogenia
            // 
            this.txtNombreFotogenia.Enabled = false;
            this.txtNombreFotogenia.Location = new System.Drawing.Point(175, 283);
            this.txtNombreFotogenia.Name = "txtNombreFotogenia";
            this.txtNombreFotogenia.Size = new System.Drawing.Size(164, 20);
            this.txtNombreFotogenia.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(172, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(88, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "Miss Fotogenia Ganadora";
            // 
            // lblVotosReina
            // 
            this.lblVotosReina.AutoSize = true;
            this.lblVotosReina.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotosReina.Location = new System.Drawing.Point(217, 153);
            this.lblVotosReina.Name = "lblVotosReina";
            this.lblVotosReina.Size = new System.Drawing.Size(81, 41);
            this.lblVotosReina.TabIndex = 9;
            this.lblVotosReina.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Votos Obtenidos:";
            // 
            // txtApellidoReina
            // 
            this.txtApellidoReina.Enabled = false;
            this.txtApellidoReina.Location = new System.Drawing.Point(175, 106);
            this.txtApellidoReina.Name = "txtApellidoReina";
            this.txtApellidoReina.Size = new System.Drawing.Size(164, 20);
            this.txtApellidoReina.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellido";
            // 
            // txtNombreReina
            // 
            this.txtNombreReina.Enabled = false;
            this.txtNombreReina.Location = new System.Drawing.Point(175, 63);
            this.txtNombreReina.Name = "txtNombreReina";
            this.txtNombreReina.Size = new System.Drawing.Size(164, 20);
            this.txtNombreReina.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reina Ganadora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultados de las Votaciones";
            // 
            // pbFotoFotogenia
            // 
            this.pbFotoFotogenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoFotogenia.Location = new System.Drawing.Point(26, 265);
            this.pbFotoFotogenia.Name = "pbFotoFotogenia";
            this.pbFotoFotogenia.Size = new System.Drawing.Size(139, 164);
            this.pbFotoFotogenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoFotogenia.TabIndex = 10;
            this.pbFotoFotogenia.TabStop = false;
            // 
            // pbFotoReina
            // 
            this.pbFotoReina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoReina.Location = new System.Drawing.Point(26, 46);
            this.pbFotoReina.Name = "pbFotoReina";
            this.pbFotoReina.Size = new System.Drawing.Size(139, 164);
            this.pbFotoReina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoReina.TabIndex = 0;
            this.pbFotoReina.TabStop = false;
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmResultados";
            this.Size = new System.Drawing.Size(936, 521);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCandidatas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoFotogenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoReina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvCandidatas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pbFotoReina;
        private System.Windows.Forms.Label lblVotosReina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidoReina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreReina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVotosFotogenia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellidoFotogenia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreFotogenia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbFotoFotogenia;
    }
}