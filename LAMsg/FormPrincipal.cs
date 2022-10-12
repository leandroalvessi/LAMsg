using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMsg
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
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

            localDateTime = new DateTime(localDateTime.Year, localDateTime.Month, localDateTime.Day);
            DateTime DataValidade = new DateTime(2022, 11, 09); //WS Collection
            if (DataValidade <= localDateTime)
            {
                btnUltraMsg.Enabled = false;
                btnTextMeBot.Enabled = false;
                lblLicenca.Text = "Sua licença expirou";
            }
            else
            {
                lblLicenca.Text = "";
            }
        }

        private void btnUltraMsg_Click(object sender, EventArgs e)
        {
            FormUltraMsg ultmsg = new FormUltraMsg();
            ultmsg.ShowDialog();
        }

        private void btnTextMeBot_Click(object sender, EventArgs e)
        {
            FormTextMeBot txtbot = new FormTextMeBot();
            txtbot.ShowDialog();
        }
    }
}
