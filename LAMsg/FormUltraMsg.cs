using RestSharp;
using System.Globalization;
using System.Net.Sockets;

namespace LAMsg
{
    public partial class FormUltraMsg : Form
    {
        public FormUltraMsg()
        {
            InitializeComponent();

            DateTime localDateTime;
            var client = new TcpClient("time.nist.gov", 13);
            using (var streamReader = new StreamReader(client.GetStream()))
            {
                var response = streamReader.ReadToEnd();
                var utcDateTimeString = response.Substring(7, 17);
                localDateTime = DateTime.ParseExact(utcDateTimeString, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
            }

            if (System.IO.File.Exists(Environment.CurrentDirectory + "/Campos.Json"))
            {
                try
                {
                    string strJson = "";
                    using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "/Campos.Json"))
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

            localDateTime = new DateTime(localDateTime.Year, localDateTime.Month, localDateTime.Day);
            DateTime DataValidade = new DateTime(2022, 11, 09); //WS Collection
            if (DataValidade <= localDateTime)
            {
                btnEnvio.Enabled = false;
                lblLicenca.Text = "Sua licença expirou";
            }
            else
            {
                lblLicenca.Text = "";
            }
        }

        private async void btnEnvio_Click(object sender, EventArgs e)
        {
            if (txtIdInstancia.Text == "")
            {
                MessageBox.Show("ID da instância não esta preenchida.", "LAMsg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtToken.Text == "")
            {
                MessageBox.Show("Token não esta preenchida.", "LAMsg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (richMessage.Text.Trim() == "")
            {
                MessageBox.Show("Mensagem não esta preenchida.", "LAMsg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] filelines;

            if (txtArquivo.Text != "")
            {
                filelines = File.ReadAllLines(openFileDialog1.FileName);

                if (filelines.Length < 1)
                {
                    MessageBox.Show("Nenhum linha contendo telefone encanotrada no arquivo.", "LAMsg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (richTelefones.Text.Trim() != "")
            {
                filelines = richTelefones.Lines;
            }
            else
            {
                MessageBox.Show("Nenhum campo contendo telefone informado.", "LAMsg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UltraMsg campos = new UltraMsg();
            campos.IdInstancia = txtIdInstancia.Text;
            campos.Token = txtToken.Text;
            campos.Mensagem = richMessage.Text;

            try
            {
                using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "/Campos.Json"))
                {
                    sw.WriteLine(campos.JsonSerializar(campos));
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