namespace ScreenConnectDownloader
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSupportCode = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnJoinSession = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSupportCode
            // 
            this.txtSupportCode.Location = new System.Drawing.Point(149, 161);
            this.txtSupportCode.Name = "txtSupportCode";
            this.txtSupportCode.Size = new System.Drawing.Size(100, 20);
            this.txtSupportCode.TabIndex = 0;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(164, 143);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(70, 15);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Vul code in:";
            this.lblPrompt.Click += new System.EventHandler(this.lblPrompt_Click);
            // 
            // btnJoinSession
            // 
            this.btnJoinSession.Location = new System.Drawing.Point(149, 187);
            this.btnJoinSession.Name = "btnJoinSession";
            this.btnJoinSession.Size = new System.Drawing.Size(100, 23);
            this.btnJoinSession.TabIndex = 2;
            this.btnJoinSession.Text = "Deelnemen";
            this.btnJoinSession.UseVisualStyleBackColor = true;
            this.btnJoinSession.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ScreenConnectDownloader.Properties.Resources.Hype_logo_zilver_transparant_groot;
            this.pictureBox1.Location = new System.Drawing.Point(70, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "hype.nl | 0342 400 510 | support@hype.nl";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnJoinSession;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnJoinSession);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtSupportCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ondersteuning op afstand | Hype Automatisering";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSupportCode;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnJoinSession;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
