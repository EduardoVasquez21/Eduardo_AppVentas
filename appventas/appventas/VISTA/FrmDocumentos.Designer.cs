
namespace appventas.VISTA
{
    partial class FrmDocumentos
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
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.txtDocTipo = new System.Windows.Forms.TextBox();
            this.lblidDoc = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.dtgDoc = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.iDDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocId
            // 
            this.txtDocId.Enabled = false;
            this.txtDocId.Location = new System.Drawing.Point(78, 50);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.Size = new System.Drawing.Size(119, 21);
            this.txtDocId.TabIndex = 0;
            // 
            // txtDocTipo
            // 
            this.txtDocTipo.Location = new System.Drawing.Point(78, 92);
            this.txtDocTipo.Name = "txtDocTipo";
            this.txtDocTipo.Size = new System.Drawing.Size(119, 21);
            this.txtDocTipo.TabIndex = 1;
            // 
            // lblidDoc
            // 
            this.lblidDoc.AutoSize = true;
            this.lblidDoc.Location = new System.Drawing.Point(46, 28);
            this.lblidDoc.Name = "lblidDoc";
            this.lblidDoc.Size = new System.Drawing.Size(80, 14);
            this.lblidDoc.TabIndex = 2;
            this.lblidDoc.Text = "Id Documento";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(46, 74);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(108, 14);
            this.lblDoc.TabIndex = 3;
            this.lblDoc.Text = "Tipo de Documento";
            // 
            // dtgDoc
            // 
            this.dtgDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dtgDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDocumento,
            this.nombreDocumento});
            this.dtgDoc.Location = new System.Drawing.Point(24, 171);
            this.dtgDoc.Name = "dtgDoc";
            this.dtgDoc.Size = new System.Drawing.Size(356, 156);
            this.dtgDoc.TabIndex = 4;
            this.dtgDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDoc_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(270, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpd.Location = new System.Drawing.Point(270, 68);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(110, 27);
            this.btnUpd.TabIndex = 6;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelet.Location = new System.Drawing.Point(270, 116);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(110, 27);
            this.btnDelet.TabIndex = 7;
            this.btnDelet.Text = "Delete";
            this.btnDelet.UseVisualStyleBackColor = false;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // iDDocumento
            // 
            this.iDDocumento.HeaderText = "Id";
            this.iDDocumento.Name = "iDDocumento";
            // 
            // nombreDocumento
            // 
            this.nombreDocumento.HeaderText = "Tipo de Documento";
            this.nombreDocumento.Name = "nombreDocumento";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.SpringGreen;
            this.btnback.Location = new System.Drawing.Point(176, 353);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(77, 29);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FrmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(411, 400);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtgDoc);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblidDoc);
            this.Controls.Add(this.txtDocTipo);
            this.Controls.Add(this.txtDocId);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDocumentos";
            this.Load += new System.EventHandler(this.FrmDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.TextBox txtDocTipo;
        private System.Windows.Forms.Label lblidDoc;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.DataGridView dtgDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDocumento;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnback;
    }
}