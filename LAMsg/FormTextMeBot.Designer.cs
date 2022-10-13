namespace LAMsg
{
    partial class FormTextMeBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextMeBot));
            this.richStatusEnvio = new System.Windows.Forms.RichTextBox();
            this.lblStatusEnvio = new System.Windows.Forms.Label();
            this.richTelefones = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.richMessage = new System.Windows.Forms.RichTextBox();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.btnEnvio = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblTelefones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richStatusEnvio
            // 
            this.richStatusEnvio.Location = new System.Drawing.Point(10, 349);
            this.richStatusEnvio.Name = "richStatusEnvio";
            this.richStatusEnvio.Size = new System.Drawing.Size(378, 43);
            this.richStatusEnvio.TabIndex = 22;
            this.richStatusEnvio.Text = "";
            // 
            // lblStatusEnvio
            // 
            this.lblStatusEnvio.AutoSize = true;
            this.lblStatusEnvio.Location = new System.Drawing.Point(10, 331);
            this.lblStatusEnvio.Name = "lblStatusEnvio";
            this.lblStatusEnvio.Size = new System.Drawing.Size(87, 15);
            this.lblStatusEnvio.TabIndex = 26;
            this.lblStatusEnvio.Text = "Status de Envio";
            // 
            // richTelefones
            // 
            this.richTelefones.Location = new System.Drawing.Point(12, 113);
            this.richTelefones.Name = "richTelefones";
            this.richTelefones.Size = new System.Drawing.Size(376, 96);
            this.richTelefones.TabIndex = 19;
            this.richTelefones.Text = "";
            this.richTelefones.TextChanged += new System.EventHandler(this.richTelefones_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(10, 214);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(66, 15);
            this.lblMessage.TabIndex = 25;
            this.lblMessage.Text = "Mensagem";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(313, 70);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 17;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(12, 52);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(101, 15);
            this.lblArquivo.TabIndex = 24;
            this.lblArquivo.Text = "Arquivo Telefones";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(12, 70);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(295, 23);
            this.txtArquivo.TabIndex = 16;
            this.txtArquivo.TextChanged += new System.EventHandler(this.txtArquivo_TextChanged);
            // 
            // richMessage
            // 
            this.richMessage.Location = new System.Drawing.Point(10, 232);
            this.richMessage.Name = "richMessage";
            this.richMessage.Size = new System.Drawing.Size(378, 96);
            this.richMessage.TabIndex = 20;
            this.richMessage.Text = "";
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(12, 9);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(44, 15);
            this.lblApiKey.TabIndex = 18;
            this.lblApiKey.Text = "ApiKey";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(12, 27);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(376, 23);
            this.txtApiKey.TabIndex = 14;
            // 
            // btnEnvio
            // 
            this.btnEnvio.Location = new System.Drawing.Point(10, 398);
            this.btnEnvio.Name = "btnEnvio";
            this.btnEnvio.Size = new System.Drawing.Size(75, 23);
            this.btnEnvio.TabIndex = 23;
            this.btnEnvio.Text = "Enviar";
            this.btnEnvio.UseVisualStyleBackColor = true;
            this.btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTelefones
            // 
            this.lblTelefones.AutoSize = true;
            this.lblTelefones.Location = new System.Drawing.Point(12, 95);
            this.lblTelefones.Name = "lblTelefones";
            this.lblTelefones.Size = new System.Drawing.Size(56, 15);
            this.lblTelefones.TabIndex = 27;
            this.lblTelefones.Text = "Telefones";
            // 
            // FormTextMeBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 430);
            this.Controls.Add(this.lblTelefones);
            this.Controls.Add(this.richStatusEnvio);
            this.Controls.Add(this.lblStatusEnvio);
            this.Controls.Add(this.richTelefones);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.richMessage);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.btnEnvio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTextMeBot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextMeBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richStatusEnvio;
        private Label lblStatusEnvio;
        private RichTextBox richTelefones;
        private Label lblMessage;
        private Button btnSelecionar;
        private Label lblArquivo;
        private TextBox txtArquivo;
        private RichTextBox richMessage;
        private Label lblApiKey;
        private TextBox txtApiKey;
        private Button btnEnvio;
        private OpenFileDialog openFileDialog1;
        private Label lblTelefones;
    }
}