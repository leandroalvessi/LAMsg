namespace LAMsg
{
    partial class FormUltraMsg
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUltraMsg));
            this.btnEnvio = new System.Windows.Forms.Button();
            this.txtIdInstancia = new System.Windows.Forms.TextBox();
            this.lblIdInstancia = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.richMessage = new System.Windows.Forms.RichTextBox();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTelefones = new System.Windows.Forms.Label();
            this.richTelefones = new System.Windows.Forms.RichTextBox();
            this.lblStatusEnvio = new System.Windows.Forms.Label();
            this.richStatusEnvio = new System.Windows.Forms.RichTextBox();
            this.lblLicenca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnvio
            // 
            this.btnEnvio.Location = new System.Drawing.Point(10, 398);
            this.btnEnvio.Name = "btnEnvio";
            this.btnEnvio.Size = new System.Drawing.Size(75, 23);
            this.btnEnvio.TabIndex = 7;
            this.btnEnvio.Text = "Enviar";
            this.btnEnvio.UseVisualStyleBackColor = true;
            this.btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
            // 
            // txtIdInstancia
            // 
            this.txtIdInstancia.Location = new System.Drawing.Point(12, 27);
            this.txtIdInstancia.Name = "txtIdInstancia";
            this.txtIdInstancia.Size = new System.Drawing.Size(185, 23);
            this.txtIdInstancia.TabIndex = 0;
            // 
            // lblIdInstancia
            // 
            this.lblIdInstancia.AutoSize = true;
            this.lblIdInstancia.Location = new System.Drawing.Point(12, 9);
            this.lblIdInstancia.Name = "lblIdInstancia";
            this.lblIdInstancia.Size = new System.Drawing.Size(84, 15);
            this.lblIdInstancia.TabIndex = 3;
            this.lblIdInstancia.Text = "ID da instância";
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(203, 9);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(38, 15);
            this.lblToken.TabIndex = 5;
            this.lblToken.Text = "Token";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(203, 27);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(185, 23);
            this.txtToken.TabIndex = 1;
            // 
            // richMessage
            // 
            this.richMessage.Location = new System.Drawing.Point(10, 232);
            this.richMessage.Name = "richMessage";
            this.richMessage.Size = new System.Drawing.Size(376, 96);
            this.richMessage.TabIndex = 5;
            this.richMessage.Text = "";
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(12, 52);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(101, 15);
            this.lblArquivo.TabIndex = 8;
            this.lblArquivo.Text = "Arquivo Telefones";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(12, 70);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(295, 23);
            this.txtArquivo.TabIndex = 2;
            this.txtArquivo.TextChanged += new System.EventHandler(this.txtArquivo_TextChanged);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(313, 70);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 3;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(10, 214);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(66, 15);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Mensagem";
            // 
            // lblTelefones
            // 
            this.lblTelefones.AutoSize = true;
            this.lblTelefones.Location = new System.Drawing.Point(12, 95);
            this.lblTelefones.Name = "lblTelefones";
            this.lblTelefones.Size = new System.Drawing.Size(56, 15);
            this.lblTelefones.TabIndex = 11;
            this.lblTelefones.Text = "Telefones";
            // 
            // richTelefones
            // 
            this.richTelefones.Location = new System.Drawing.Point(12, 113);
            this.richTelefones.Name = "richTelefones";
            this.richTelefones.Size = new System.Drawing.Size(376, 96);
            this.richTelefones.TabIndex = 4;
            this.richTelefones.Text = "";
            this.richTelefones.TextChanged += new System.EventHandler(this.richTelefones_TextChanged);
            // 
            // lblStatusEnvio
            // 
            this.lblStatusEnvio.AutoSize = true;
            this.lblStatusEnvio.Location = new System.Drawing.Point(10, 331);
            this.lblStatusEnvio.Name = "lblStatusEnvio";
            this.lblStatusEnvio.Size = new System.Drawing.Size(87, 15);
            this.lblStatusEnvio.TabIndex = 13;
            this.lblStatusEnvio.Text = "Status de Envio";
            // 
            // richStatusEnvio
            // 
            this.richStatusEnvio.Location = new System.Drawing.Point(10, 349);
            this.richStatusEnvio.Name = "richStatusEnvio";
            this.richStatusEnvio.Size = new System.Drawing.Size(376, 43);
            this.richStatusEnvio.TabIndex = 6;
            this.richStatusEnvio.Text = "";
            // 
            // lblLicenca
            // 
            this.lblLicenca.AutoSize = true;
            this.lblLicenca.Location = new System.Drawing.Point(91, 402);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(47, 15);
            this.lblLicenca.TabIndex = 15;
            this.lblLicenca.Text = "Licença";
            // 
            // FormEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 430);
            this.Controls.Add(this.lblLicenca);
            this.Controls.Add(this.richStatusEnvio);
            this.Controls.Add(this.lblStatusEnvio);
            this.Controls.Add(this.lblTelefones);
            this.Controls.Add(this.richTelefones);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.richMessage);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.lblIdInstancia);
            this.Controls.Add(this.txtIdInstancia);
            this.Controls.Add(this.btnEnvio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEnvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAMsg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnEnvio;
        private TextBox txtIdInstancia;
        private Label lblIdInstancia;
        private Label lblToken;
        private TextBox txtToken;
        private RichTextBox richMessage;
        private Label lblArquivo;
        private TextBox txtArquivo;
        private Button btnSelecionar;
        private OpenFileDialog openFileDialog1;
        private Label lblMessage;
        private Label lblTelefones;
        private RichTextBox richTelefones;
        private Label lblStatusEnvio;
        private RichTextBox richStatusEnvio;
        private Label lblLicenca;
    }
}