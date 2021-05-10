
namespace appventas.VISTA
{
    partial class FrmUsuarios
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
            this.txtUsId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblIdUs = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGua = new System.Windows.Forms.Button();
            this.btnACT = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsId
            // 
            this.txtUsId.Enabled = false;
            this.txtUsId.Location = new System.Drawing.Point(92, 45);
            this.txtUsId.Name = "txtUsId";
            this.txtUsId.Size = new System.Drawing.Size(48, 20);
            this.txtUsId.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(95, 190);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(280, 20);
            this.txtPass.TabIndex = 2;
            // 
            // lblIdUs
            // 
            this.lblIdUs.AutoSize = true;
            this.lblIdUs.Location = new System.Drawing.Point(78, 25);
            this.lblIdUs.Name = "lblIdUs";
            this.lblIdUs.Size = new System.Drawing.Size(16, 13);
            this.lblIdUs.TabIndex = 3;
            this.lblIdUs.Text = "Id";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(78, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(78, 174);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUsuario,
            this.email,
            this.contraseña});
            this.dataGridView1.Location = new System.Drawing.Point(27, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 155);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDUsuario
            // 
            this.iDUsuario.HeaderText = "Id";
            this.iDUsuario.Name = "iDUsuario";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // contraseña
            // 
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            // 
            // btnGua
            // 
            this.btnGua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGua.Location = new System.Drawing.Point(50, 224);
            this.btnGua.Name = "btnGua";
            this.btnGua.Size = new System.Drawing.Size(112, 43);
            this.btnGua.TabIndex = 7;
            this.btnGua.Text = "Create New";
            this.btnGua.UseVisualStyleBackColor = false;
            this.btnGua.Click += new System.EventHandler(this.btnGua_Click);
            // 
            // btnACT
            // 
            this.btnACT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnACT.Location = new System.Drawing.Point(238, 224);
            this.btnACT.Name = "btnACT";
            this.btnACT.Size = new System.Drawing.Size(112, 43);
            this.btnACT.TabIndex = 8;
            this.btnACT.Text = "Update User";
            this.btnACT.UseVisualStyleBackColor = false;
            this.btnACT.Click += new System.EventHandler(this.btnACT_Click);
            // 
            // btnBo
            // 
            this.btnBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBo.Location = new System.Drawing.Point(439, 224);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(112, 43);
            this.btnBo.TabIndex = 9;
            this.btnBo.Text = "Delete User";
            this.btnBo.UseVisualStyleBackColor = false;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnback.Location = new System.Drawing.Point(506, 454);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(90, 29);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(620, 495);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnBo);
            this.Controls.Add(this.btnACT);
            this.Controls.Add(this.btnGua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblIdUs);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsId);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblIdUs;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.Button btnGua;
        private System.Windows.Forms.Button btnACT;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.Button btnback;
    }
}