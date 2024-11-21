using System.Windows.Forms;

namespace View.Album
{
    partial class FrmGaleria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.dgvCandidatas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tituloUno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descripcionUno = new System.Windows.Forms.RichTextBox();
            this.descripcionDos = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tituloDos = new System.Windows.Forms.TextBox();
            this.descripcionTres = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tituloTres = new System.Windows.Forms.TextBox();
            this.btnConsultarAlbum = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imagenUno = new System.Windows.Forms.PictureBox();
            this.imagenDos = new System.Windows.Forms.PictureBox();
            this.imagenTres = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenTres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Galería de Candidatas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(179, 73);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 22);
            this.cmbEstado.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(319, 73);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 21);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(31, 73);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(121, 22);
            this.txtCedula.TabIndex = 16;
            // 
            // dgvCandidatas
            // 
            this.dgvCandidatas.AllowUserToAddRows = false;
            this.dgvCandidatas.AllowUserToDeleteRows = false;
            this.dgvCandidatas.AllowUserToResizeRows = false;
            this.dgvCandidatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatas.Location = new System.Drawing.Point(31, 100);
            this.dgvCandidatas.MultiSelect = false;
            this.dgvCandidatas.Name = "dgvCandidatas";
            this.dgvCandidatas.ReadOnly = true;
            this.dgvCandidatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatas.Size = new System.Drawing.Size(838, 119);
            this.dgvCandidatas.TabIndex = 21;
            this.dgvCandidatas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCandidatas_DataBindingComplete);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Título";
            // 
            // tituloUno
            // 
            this.tituloUno.Location = new System.Drawing.Point(142, 41);
            this.tituloUno.Name = "tituloUno";
            this.tituloUno.Size = new System.Drawing.Size(121, 23);
            this.tituloUno.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Descripción";
            // 
            // descripcionUno
            // 
            this.descripcionUno.Location = new System.Drawing.Point(142, 91);
            this.descripcionUno.Name = "descripcionUno";
            this.descripcionUno.Size = new System.Drawing.Size(121, 69);
            this.descripcionUno.TabIndex = 27;
            this.descripcionUno.Text = "";
            // 
            // descripcionDos
            // 
            this.descripcionDos.Location = new System.Drawing.Point(416, 91);
            this.descripcionDos.Name = "descripcionDos";
            this.descripcionDos.Size = new System.Drawing.Size(121, 69);
            this.descripcionDos.TabIndex = 32;
            this.descripcionDos.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Título";
            // 
            // tituloDos
            // 
            this.tituloDos.Location = new System.Drawing.Point(416, 41);
            this.tituloDos.Name = "tituloDos";
            this.tituloDos.Size = new System.Drawing.Size(121, 23);
            this.tituloDos.TabIndex = 29;
            // 
            // descripcionTres
            // 
            this.descripcionTres.Location = new System.Drawing.Point(693, 91);
            this.descripcionTres.Name = "descripcionTres";
            this.descripcionTres.Size = new System.Drawing.Size(121, 69);
            this.descripcionTres.TabIndex = 37;
            this.descripcionTres.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(690, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Descripción";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(690, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Título";
            // 
            // tituloTres
            // 
            this.tituloTres.Location = new System.Drawing.Point(693, 41);
            this.tituloTres.Name = "tituloTres";
            this.tituloTres.Size = new System.Drawing.Size(121, 23);
            this.tituloTres.TabIndex = 34;
            // 
            // btnConsultarAlbum
            // 
            this.btnConsultarAlbum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultarAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarAlbum.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAlbum.Location = new System.Drawing.Point(31, 225);
            this.btnConsultarAlbum.Name = "btnConsultarAlbum";
            this.btnConsultarAlbum.Size = new System.Drawing.Size(119, 24);
            this.btnConsultarAlbum.TabIndex = 38;
            this.btnConsultarAlbum.Text = "Consultar Albúm";
            this.btnConsultarAlbum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultarAlbum.UseVisualStyleBackColor = false;
            this.btnConsultarAlbum.Click += new System.EventHandler(this.btnConsultarAlbum_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(438, 460);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 21);
            this.btnRegistrar.TabIndex = 39;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(419, 460);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(99, 21);
            this.btnActualizar.TabIndex = 40;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descripcionDos);
            this.groupBox1.Controls.Add(this.imagenUno);
            this.groupBox1.Controls.Add(this.tituloUno);
            this.groupBox1.Controls.Add(this.descripcionTres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.descripcionUno);
            this.groupBox1.Controls.Add(this.tituloTres);
            this.groupBox1.Controls.Add(this.imagenDos);
            this.groupBox1.Controls.Add(this.imagenTres);
            this.groupBox1.Controls.Add(this.tituloDos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 180);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Álbum";
            // 
            // imagenUno
            // 
            this.imagenUno.BackgroundImage = global::View.Properties.Resources.IconoAlbumFotos;
            this.imagenUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenUno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenUno.Location = new System.Drawing.Point(11, 24);
            this.imagenUno.Name = "imagenUno";
            this.imagenUno.Size = new System.Drawing.Size(116, 136);
            this.imagenUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenUno.TabIndex = 22;
            this.imagenUno.TabStop = false;
            this.imagenUno.Click += new System.EventHandler(this.imagenUno_Click);
            // 
            // imagenDos
            // 
            this.imagenDos.BackgroundImage = global::View.Properties.Resources.IconoAlbumFotos;
            this.imagenDos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenDos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenDos.Location = new System.Drawing.Point(285, 24);
            this.imagenDos.Name = "imagenDos";
            this.imagenDos.Size = new System.Drawing.Size(116, 136);
            this.imagenDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenDos.TabIndex = 28;
            this.imagenDos.TabStop = false;
            this.imagenDos.Click += new System.EventHandler(this.imagenDos_Click);
            // 
            // imagenTres
            // 
            this.imagenTres.BackgroundImage = global::View.Properties.Resources.IconoAlbumFotos;
            this.imagenTres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenTres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenTres.Location = new System.Drawing.Point(562, 24);
            this.imagenTres.Name = "imagenTres";
            this.imagenTres.Size = new System.Drawing.Size(116, 136);
            this.imagenTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenTres.TabIndex = 33;
            this.imagenTres.TabStop = false;
            this.imagenTres.Click += new System.EventHandler(this.imagenTres_Click);
            // 
            // FrmGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnConsultarAlbum);
            this.Controls.Add(this.dgvCandidatas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGaleria";
            this.Size = new System.Drawing.Size(918, 502);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenTres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DataGridView dgvCandidatas;
        private System.Windows.Forms.PictureBox imagenUno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tituloUno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox descripcionUno;
        private System.Windows.Forms.RichTextBox descripcionDos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tituloDos;
        private System.Windows.Forms.PictureBox imagenDos;
        private System.Windows.Forms.RichTextBox descripcionTres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tituloTres;
        private System.Windows.Forms.PictureBox imagenTres;
        private System.Windows.Forms.Button btnConsultarAlbum;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private GroupBox groupBox1;
    }
}
