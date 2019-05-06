namespace VistaForm
{
    partial class FormDT
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nudExperiencia = new System.Windows.Forms.NumericUpDown();
            this.nudDni = new System.Windows.Forms.NumericUpDown();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudExperiencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(22, 57);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(22, 91);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(90, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // nudExperiencia
            // 
            this.nudExperiencia.Location = new System.Drawing.Point(90, 159);
            this.nudExperiencia.Name = "nudExperiencia";
            this.nudExperiencia.Size = new System.Drawing.Size(120, 20);
            this.nudExperiencia.TabIndex = 7;
            // 
            // nudDni
            // 
            this.nudDni.Location = new System.Drawing.Point(90, 124);
            this.nudDni.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudDni.Name = "nudDni";
            this.nudDni.Size = new System.Drawing.Size(120, 20);
            this.nudDni.TabIndex = 6;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(90, 89);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 20);
            this.nudEdad.TabIndex = 5;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(22, 126);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "DNI";
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.Location = new System.Drawing.Point(22, 161);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(62, 13);
            this.lblExperiencia.TabIndex = 9;
            this.lblExperiencia.Text = "Experiencia";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(25, 214);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(135, 214);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 11;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // FormDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 261);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblExperiencia);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.nudDni);
            this.Controls.Add(this.nudExperiencia);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDT";
            this.Load += new System.EventHandler(this.FormDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudExperiencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nudExperiencia;
        private System.Windows.Forms.NumericUpDown nudDni;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblExperiencia;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
    }
}

