namespace LAMsg
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnUltraMsg = new System.Windows.Forms.Button();
            this.btnCallMeBot = new System.Windows.Forms.Button();
            this.lblLicenca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUltraMsg
            // 
            this.btnUltraMsg.Location = new System.Drawing.Point(12, 12);
            this.btnUltraMsg.Name = "btnUltraMsg";
            this.btnUltraMsg.Size = new System.Drawing.Size(117, 57);
            this.btnUltraMsg.TabIndex = 0;
            this.btnUltraMsg.Text = "UltraMsg";
            this.btnUltraMsg.UseVisualStyleBackColor = true;
            this.btnUltraMsg.Click += new System.EventHandler(this.btnUltraMsg_Click);
            // 
            // btnCallMeBot
            // 
            this.btnCallMeBot.Location = new System.Drawing.Point(149, 12);
            this.btnCallMeBot.Name = "btnCallMeBot";
            this.btnCallMeBot.Size = new System.Drawing.Size(117, 57);
            this.btnCallMeBot.TabIndex = 1;
            this.btnCallMeBot.Text = "CallMeBot";
            this.btnCallMeBot.UseVisualStyleBackColor = true;
            // 
            // lblLicenca
            // 
            this.lblLicenca.AutoSize = true;
            this.lblLicenca.Location = new System.Drawing.Point(12, 81);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(47, 15);
            this.lblLicenca.TabIndex = 16;
            this.lblLicenca.Text = "Licença";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 114);
            this.Controls.Add(this.lblLicenca);
            this.Controls.Add(this.btnCallMeBot);
            this.Controls.Add(this.btnUltraMsg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAMsg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUltraMsg;
        private Button btnCallMeBot;
        private Label lblLicenca;
    }
}