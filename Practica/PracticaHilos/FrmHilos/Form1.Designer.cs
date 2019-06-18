namespace FrmHilos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtUno = new System.Windows.Forms.TextBox();
            this.txtDos = new System.Windows.Forms.TextBox();
            this.txtTres = new System.Windows.Forms.TextBox();
            this.txtCuatro = new System.Windows.Forms.TextBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.tmrUno = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtUno
            // 
            this.txtUno.Location = new System.Drawing.Point(12, 12);
            this.txtUno.Name = "txtUno";
            this.txtUno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUno.Size = new System.Drawing.Size(80, 20);
            this.txtUno.TabIndex = 0;
            // 
            // txtDos
            // 
            this.txtDos.Location = new System.Drawing.Point(98, 12);
            this.txtDos.Name = "txtDos";
            this.txtDos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDos.Size = new System.Drawing.Size(80, 20);
            this.txtDos.TabIndex = 1;
            // 
            // txtTres
            // 
            this.txtTres.Location = new System.Drawing.Point(184, 12);
            this.txtTres.Name = "txtTres";
            this.txtTres.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTres.Size = new System.Drawing.Size(80, 20);
            this.txtTres.TabIndex = 2;
            // 
            // txtCuatro
            // 
            this.txtCuatro.Location = new System.Drawing.Point(270, 12);
            this.txtCuatro.Name = "txtCuatro";
            this.txtCuatro.Size = new System.Drawing.Size(80, 20);
            this.txtCuatro.TabIndex = 3;
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(12, 38);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(80, 23);
            this.btnUno.TabIndex = 4;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(98, 38);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(80, 23);
            this.btnDos.TabIndex = 5;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(184, 38);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(80, 23);
            this.btnTres.TabIndex = 6;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(270, 38);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(80, 23);
            this.btnCuatro.TabIndex = 7;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // tmrUno
            // 
            this.tmrUno.Interval = 10;
            this.tmrUno.Tick += new System.EventHandler(this.tmrUno_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 86);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.txtCuatro);
            this.Controls.Add(this.txtTres);
            this.Controls.Add(this.txtDos);
            this.Controls.Add(this.txtUno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUno;
        private System.Windows.Forms.TextBox txtDos;
        private System.Windows.Forms.TextBox txtTres;
        private System.Windows.Forms.TextBox txtCuatro;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Timer tmrUno;
    }
}

