namespace View
{
    partial class FrmRegistroAdministrador
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApeliido = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registro de Administrador";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(388, 296);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 15);
            this.lbNombre.TabIndex = 15;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApeliido
            // 
            this.lbApeliido.AutoSize = true;
            this.lbApeliido.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApeliido.Location = new System.Drawing.Point(386, 338);
            this.lbApeliido.Name = "lbApeliido";
            this.lbApeliido.Size = new System.Drawing.Size(57, 15);
            this.lbApeliido.TabIndex = 16;
            this.lbApeliido.Text = "Apellido";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.Location = new System.Drawing.Point(396, 377);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(48, 15);
            this.lbCedula.TabIndex = 17;
            this.lbCedula.Text = "Cedula";
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.Location = new System.Drawing.Point(371, 417);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(75, 15);
            this.lbContraseña.TabIndex = 18;
            this.lbContraseña.Text = "Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(460, 296);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(460, 338);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(134, 20);
            this.txtApellido.TabIndex = 20;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(460, 377);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(134, 20);
            this.txtCedula.TabIndex = 21;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(460, 417);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(134, 20);
            this.txtContraseña.TabIndex = 22;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(383, 466);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 22);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(505, 466);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 22);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.AdmistradorRegistro;
            this.pictureBox1.Location = new System.Drawing.Point(422, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistroAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.lbApeliido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistroAdministrador";
            this.Size = new System.Drawing.Size(897, 533);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApeliido;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
