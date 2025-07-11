using RestSharp;

namespace LAMsg
{
    public partial class FormUltraMsg : Form
    {
        public FormUltraMsg()
        {
            InitializeComponent();

            if (System.IO.File.Exists(Environment.CurrentDirectory + "/UltraMsgDB.Json"))
            {
                try
                {
                    string strJson = "";
                    using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "/UltraMsgDB.Json"))
                    {
                        strJson = sr.ReadToEnd();
                    }

                    UltraMsg campos = UltraMsg.JsonDesserializar(strJson);
                    txtIdInstancia.Text = campos.IdInstancia;
                    txtToken.Text = campos.Token;
                    richMessage.Text = campos.Mensagem;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private async void btnEnvio_Click(object sender, EventArgs e)
        {
            if (txtIdInstancia.Text == "")
            {
                MessageBox.Show("ID da inst�ncia n�o esta preenchida.", "UltraMsg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtToken.Text == "")
            {
                MessageBox.Show("Token n�o esta preenchida.", "UltraMsg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (richMessage.Text.Trim() == "")
            {
                MessageBox.Show("Mensagem n�o esta preenchida.", "UltraMsg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] filelines;

            if (txtArquivo.Text != "")
            {
                filelines = File.ReadAllLines(openFileDialog1.FileName);

                if (filelines.Length < 1)
                {
                    MessageBox.Show("Nenhum linha contendo telefone encanotrada no arquivo.", "UltraMsg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (richTelefones.Text.Trim() != "")
            {
                filelines = richTelefones.Lines;
            }
            else
            {
                MessageBox.Show("Nenhum campo contendo telefone informado.", "UltraMsg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UltraMsg ultmsg = new UltraMsg();
            ultmsg.IdInstancia = txtIdInstancia.Text;
            ultmsg.Token = txtToken.Text;
            ultmsg.Mensagem = richMessage.Text;

            try
            {
                using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "/UltraMsgDB.Json"))
                {
                    sw.WriteLine(ultmsg.JsonSerializar(ultmsg));
                }
            }
            catch (Exception)
            {
                throw;
            }

            richStatusEnvio.Text = "";

            foreach (string line in filelines)
            {
                var url = "https://api.ultramsg.com/" + txtIdInstancia.Text.Trim() + "/messages/chat";
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Post);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("token", txtToken.Text.Trim());
                request.AddParameter("to", "+" + line.Trim());
                request.AddParameter("body", richMessage.Text);

                RestResponse response = await client.ExecuteAsync(request);

                if (richStatusEnvio.Lines.Length == 0)
                {
                    richStatusEnvio.AppendText(response.Content + " - " + line);
                    richStatusEnvio.ScrollToCaret();
                }
                else
                {
                    richStatusEnvio.AppendText("\r\n" + response.Content + " - " + line);
                    richStatusEnvio.ScrollToCaret();
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = openFileDialog1.FileName;
            }
        }

        private void txtArquivo_TextChanged(object sender, EventArgs e)
        {
            if (txtArquivo.Text != "")
            {
                richTelefones.Clear();
            }
        }

        private void richTelefones_TextChanged(object sender, EventArgs e)
        {
            if (richTelefones.Text != "")
            {
                txtArquivo.Clear();
            }
        }
    }
}