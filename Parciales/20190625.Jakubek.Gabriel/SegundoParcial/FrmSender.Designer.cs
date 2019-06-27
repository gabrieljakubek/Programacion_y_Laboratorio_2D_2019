namespace SegundoParcial
{
    partial class FrmSender
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.richOutPut = new System.Windows.Forms.RichTextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.richMensaje = new System.Windows.Forms.RichTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnSendWhat = new System.Windows.Forms.Button();
            this.btnShowMail = new System.Windows.Forms.Button();
            this.btnShowWhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(12, 262);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 18);
            this.lblOutput.TabIndex = 23;
            this.lblOutput.Text = "Output";
            // 
            // richOutPut
            // 
            this.richOutPut.Location = new System.Drawing.Point(15, 283);
            this.richOutPut.Name = "richOutPut";
            this.richOutPut.ReadOnly = true;
            this.richOutPut.Size = new System.Drawing.Size(458, 123);
            this.richOutPut.TabIndex = 22;
            this.richOutPut.Text = "";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(15, 143);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(137, 21);
            this.cmbProducto.Sorted = true;
            this.cmbProducto.TabIndex = 21;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(12, 122);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(69, 18);
            this.lblProducto.TabIndex = 20;
            this.lblProducto.Text = "Producto";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(160, 10);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(64, 18);
            this.lblMensaje.TabIndex = 19;
            this.lblMensaje.Text = "Mensaje";
            // 
            // richMensaje
            // 
            this.richMensaje.Location = new System.Drawing.Point(163, 31);
            this.richMensaje.Name = "richMensaje";
            this.richMensaje.Size = new System.Drawing.Size(320, 134);
            this.richMensaje.TabIndex = 18;
            this.richMensaje.Text = "";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(12, 67);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(32, 18);
            this.lblTel.TabIndex = 17;
            this.lblTel.Text = "Tel.";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(15, 88);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(137, 20);
            this.txtTel.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(137, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(15, 194);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(102, 49);
            this.btnSendEmail.TabIndex = 13;
            this.btnSendEmail.Text = "Enviar Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.BtnSendEmail_Click);
            // 
            // btnSendWhat
            // 
            this.btnSendWhat.Location = new System.Drawing.Point(264, 194);
            this.btnSendWhat.Name = "btnSendWhat";
            this.btnSendWhat.Size = new System.Drawing.Size(100, 49);
            this.btnSendWhat.TabIndex = 12;
            this.btnSendWhat.Text = "Enviar Whatsapp";
            this.btnSendWhat.UseVisualStyleBackColor = true;
            this.btnSendWhat.Click += new System.EventHandler(this.BtnSendWhat_Click);
            // 
            // btnShowMail
            // 
            this.btnShowMail.Location = new System.Drawing.Point(123, 194);
            this.btnShowMail.Name = "btnShowMail";
            this.btnShowMail.Size = new System.Drawing.Size(101, 49);
            this.btnShowMail.TabIndex = 24;
            this.btnShowMail.Text = "Email Info";
            this.btnShowMail.UseVisualStyleBackColor = true;
            this.btnShowMail.Click += new System.EventHandler(this.BtnMailInfo_Click);
            // 
            // btnShowWhat
            // 
            this.btnShowWhat.Location = new System.Drawing.Point(370, 194);
            this.btnShowWhat.Name = "btnShowWhat";
            this.btnShowWhat.Size = new System.Drawing.Size(113, 49);
            this.btnShowWhat.TabIndex = 25;
            this.btnShowWhat.Text = "Whatsapp Info";
            this.btnShowWhat.UseVisualStyleBackColor = true;
            this.btnShowWhat.Click += new System.EventHandler(this.BtnWhatInfo_Click);
            // 
            // FrmSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 412);
            this.Controls.Add(this.btnShowWhat);
            this.Controls.Add(this.btnShowMail);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.richOutPut);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.richMensaje);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.btnSendWhat);
            this.Name = "FrmSender";
            this.Text = "Nombre.Apellido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSender_FormClosed);
            this.Load += new System.EventHandler(this.FrmSender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RichTextBox richOutPut;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.RichTextBox richMensaje;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnSendWhat;
        private System.Windows.Forms.Button btnShowMail;
        private System.Windows.Forms.Button btnShowWhat;
    }
}

