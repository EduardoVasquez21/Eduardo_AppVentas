
namespace appventas.VISTA
{
    partial class FrmMdi
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnUs = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Black;
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.Location = new System.Drawing.Point(48, 74);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(113, 40);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.Black;
            this.btnDoc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDoc.Location = new System.Drawing.Point(48, 137);
            this.btnDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(113, 39);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.Text = "Documentos";
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.Color.Black;
            this.btnProd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProd.Location = new System.Drawing.Point(48, 199);
            this.btnProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(113, 35);
            this.btnProd.TabIndex = 2;
            this.btnProd.Text = "Producto";
            this.btnProd.UseVisualStyleBackColor = false;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnUs
            // 
            this.btnUs.BackColor = System.Drawing.Color.Black;
            this.btnUs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUs.Location = new System.Drawing.Point(48, 253);
            this.btnUs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUs.Name = "btnUs";
            this.btnUs.Size = new System.Drawing.Size(113, 35);
            this.btnUs.TabIndex = 3;
            this.btnUs.Text = "Usuario";
            this.btnUs.UseVisualStyleBackColor = false;
            this.btnUs.Click += new System.EventHandler(this.btnUs_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(164, 347);
            this.btnReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(116, 36);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Back";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // FrmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(333, 433);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnUs);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnClientes);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMdi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnUs;
        private System.Windows.Forms.Button btnReg;
    }
}