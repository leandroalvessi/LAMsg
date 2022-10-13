using RestSharp;

namespace LAMsg
{
    public partial class FormTextMeBot : Form
    {
        public FormTextMeBot()
        {
            InitializeComponent();

            if (System.IO.File.Exists(Environment.CurrentDirectory + "/TextMeBotDB.Json"))
            {
                try
                {
                    string strJson = "";
                    using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "/TextMeBotDB.Json"))
                    {
                        strJson = sr.ReadToEnd();
                    }

                    TextMeBot txtmebot = TextMeBot.JsonDesserializar(strJson);
                    txtApiKey.Text = txtmebot.ApiKey;
                    richMessage.Text = txtmebot.Mensagem;
                }
                catch (Exception)
                {
                    throw;
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

        private async void btnEnvio_Click(object sender, EventArgs e)
        {

            if (txtApiKey.Text == "")
            {
                MessageBox.Show("ApiKey não esta preenchida.", "TextMeBot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (richMessage.Text.Trim() == "")
            {
                MessageBox.Show("Mensagem não esta preenchida.", "TextMeBot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] filelines;

            if (txtArquivo.Text != "")
            {
                filelines = File.ReadAllLines(openFileDialog1.FileName);

                if (filelines.Length < 1)
                {
                    MessageBox.Show("Nenhum linha contendo telefone encanotrada no arquivo.", "TextMeBot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (richTelefones.Text.Trim() != "")
            {
                filelines = richTelefones.Lines;
            }
            else
            {
                MessageBox.Show("Nenhum campo contendo telefone informado.", "TextMeBot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TextMeBot txtmebot = new TextMeBot();
            txtmebot.ApiKey = txtApiKey.Text;
            txtmebot.Mensagem = richMessage.Text;

            try
            {
                using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "/TextMeBotDB.Json"))
                {
                    sw.WriteLine(txtmebot.JsonSerializar(txtmebot));
                }
            }
            catch (Exception)
            {
                throw;
            }

            richStatusEnvio.Text = "";

            foreach (string line in filelines)
            {
                var url = "http://api.textmebot.com/send.php?recipient=+" + line.Trim() + "&apikey=" + txtApiKey.Text.Trim() + "&text=" + richMessage.Text;
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Post);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");

                await Task.Delay(5000);
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
