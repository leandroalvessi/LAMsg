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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCallMeBot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "UltraMsg";
            this.button1.UseVisualStyleBackColor = true;
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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 123);
            this.Controls.Add(this.btnCallMeBot);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAMsg";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button btnCallMeBot;
    }
}