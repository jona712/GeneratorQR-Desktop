
namespace CraerQR.Entidades
{
    partial class frmCrearCodigoQR
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
            this.components = new System.ComponentModel.Container();
            this.btnCrearQR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.gpbTipoDato = new System.Windows.Forms.GroupBox();
            this.rdbTexto = new System.Windows.Forms.RadioButton();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpbTipoDato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearQR
            // 
            this.btnCrearQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrearQR.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCrearQR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearQR.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearQR.ForeColor = System.Drawing.Color.White;
            this.btnCrearQR.Location = new System.Drawing.Point(132, 169);
            this.btnCrearQR.Name = "btnCrearQR";
            this.btnCrearQR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrearQR.Size = new System.Drawing.Size(184, 48);
            this.btnCrearQR.TabIndex = 0;
            this.btnCrearQR.Text = "Generar Código QR";
            this.btnCrearQR.UseVisualStyleBackColor = false;
            this.btnCrearQR.Click += new System.EventHandler(this.btnCrearQR_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 55);
            this.panel1.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(3, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalir.Size = new System.Drawing.Size(89, 48);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTexto);
            this.panel2.Controls.Add(this.gpbTipoDato);
            this.panel2.Controls.Add(this.btnCrearQR);
            this.panel2.Location = new System.Drawing.Point(13, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 232);
            this.panel2.TabIndex = 3;
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(53, 94);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(342, 27);
            this.txtTexto.TabIndex = 3;
            this.txtTexto.Visible = false;
            // 
            // gpbTipoDato
            // 
            this.gpbTipoDato.Controls.Add(this.rdbTexto);
            this.gpbTipoDato.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipoDato.ForeColor = System.Drawing.Color.White;
            this.gpbTipoDato.Location = new System.Drawing.Point(43, 3);
            this.gpbTipoDato.Name = "gpbTipoDato";
            this.gpbTipoDato.Size = new System.Drawing.Size(361, 57);
            this.gpbTipoDato.TabIndex = 2;
            this.gpbTipoDato.TabStop = false;
            this.gpbTipoDato.Text = "Tipo de dato";
            // 
            // rdbTexto
            // 
            this.rdbTexto.AutoSize = true;
            this.rdbTexto.Location = new System.Drawing.Point(153, 25);
            this.rdbTexto.Name = "rdbTexto";
            this.rdbTexto.Size = new System.Drawing.Size(62, 22);
            this.rdbTexto.TabIndex = 1;
            this.rdbTexto.TabStop = true;
            this.rdbTexto.Text = "Texto";
            this.rdbTexto.UseVisualStyleBackColor = true;
            this.rdbTexto.CheckedChanged += new System.EventHandler(this.rdbTexto_CheckedChanged);
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // frmCrearCodigoQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(480, 319);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearCodigoQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearCodigoQR";
            this.Load += new System.EventHandler(this.frmCrearCodigoQR_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gpbTipoDato.ResumeLayout(false);
            this.gpbTipoDato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearQR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gpbTipoDato;
        private System.Windows.Forms.RadioButton rdbTexto;
        private System.Windows.Forms.ErrorProvider erpErrores;
        private System.Windows.Forms.TextBox txtTexto;
    }
}