namespace Serializacion_Form
{
    partial class Principal
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
            this.lbxXml = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbxBinario = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxXml
            // 
            this.lbxXml.FormattingEnabled = true;
            this.lbxXml.Location = new System.Drawing.Point(12, 13);
            this.lbxXml.Name = "lbxXml";
            this.lbxXml.Size = new System.Drawing.Size(473, 95);
            this.lbxXml.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 257);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(189, 37);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(301, 257);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(184, 37);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "Refresh";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(157, 300);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(189, 37);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbxBinario
            // 
            this.lbxBinario.FormattingEnabled = true;
            this.lbxBinario.Location = new System.Drawing.Point(12, 114);
            this.lbxBinario.Name = "lbxBinario";
            this.lbxBinario.Size = new System.Drawing.Size(473, 134);
            this.lbxBinario.TabIndex = 5;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 344);
            this.Controls.Add(this.lbxBinario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lbxXml);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxXml;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lbxBinario;
    }
}

