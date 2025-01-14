using System.Windows.Forms;

namespace View
{
    partial class FrmVotacion
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCandidata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgCandidata = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnCandidata = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidatas
            // 
            this.dgvCandidatas.AllowUserToAddRows = false;
            this.dgvCandidatas.AllowUserToDeleteRows = false;
            this.dgvCandidatas.AllowUserToResizeRows = false;
            this.dgvCandidatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatas.Location = new System.Drawing.Point(66, 113);
            this.dgvCandidatas.MultiSelect = false;
            this.dgvCandidatas.Name = "dgvCandidatas";
            this.dgvCandidatas.ReadOnly = true;
            this.dgvCandidatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatas.Size = new System.Drawing.Size(807, 145);
            this.dgvCandidatas.TabIndex = 47;
            this.dgvCandidatas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCandidatas_DataBindingComplete);
            this.dgvCandidatas.SelectionChanged += new System.EventHandler(this.dgvCandidatas_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 46;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(297, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 21);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre de la Candidata";
            // 
            // txtNombreCandidata
            // 
            this.txtNombreCandidata.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCandidata.Location = new System.Drawing.Point(66, 84);
            this.txtNombreCandidata.Name = "txtNombreCandidata";
            this.txtNombreCandidata.Size = new System.Drawing.Size(214, 22);
            this.txtNombreCandidata.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 41;
            // 
            // imgCandidata
            // 
            this.imgCandidata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCandidata.Image = global::View.Properties.Resources.reinalogotarea;
            this.imgCandidata.Location = new System.Drawing.Point(308, 276);
            this.imgCandidata.Name = "imgCandidata";
            this.imgCandidata.Size = new System.Drawing.Size(155, 180);
            this.imgCandidata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCandidata.TabIndex = 48;
            this.imgCandidata.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(469, 295);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 22);
            this.txtNombre.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(469, 341);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(152, 22);
            this.txtApellido.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(469, 390);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(152, 22);
            this.txtEdad.TabIndex = 54;
            // 
            // btnCandidata
            // 
            this.btnCandidata.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCandidata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCandidata.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidata.Location = new System.Drawing.Point(424, 477);
            this.btnCandidata.Name = "btnCandidata";
            this.btnCandidata.Size = new System.Drawing.Size(89, 21);
            this.btnCandidata.TabIndex = 55;
            this.btnCandidata.Text = "Votar";
            this.btnCandidata.UseVisualStyleBackColor = false;
            this.btnCandidata.Click += new System.EventHandler(this.btnCandidata_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(469, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "Carrera";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Enabled = false;
            this.txtCarrera.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.Location = new System.Drawing.Point(469, 436);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(152, 22);
            this.txtCarrera.TabIndex = 57;
            // 
            // FrmVotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCandidata);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imgCandidata);
            this.Controls.Add(this.dgvCandidatas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCandidata);
            this.Controls.Add(this.label1);
            this.Name = "FrmVotacion";
            this.Size = new System.Drawing.Size(936, 524);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCandidatas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCandidata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgCandidata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnCandidata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCarrera;

        public DataGridView DgvCandidatas { get => dgvCandidatas; set => dgvCandidatas = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Button BtnBuscar { get => btnBuscar; set => btnBuscar = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtNombreCandidata { get => txtNombreCandidata; set => txtNombreCandidata = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public PictureBox ImgCandidata { get => imgCandidata; set => imgCandidata = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public TextBox TxtNombre { get => txtNombre; set => txtNombre = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public TextBox TxtApellido { get => txtApellido; set => txtApellido = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public TextBox TxtEdad { get => txtEdad; set => txtEdad = value; }
        public Button BtnCandidata { get => btnCandidata; set => btnCandidata = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public TextBox TxtCarrera { get => txtCarrera; set => txtCarrera = value; }
    }
}