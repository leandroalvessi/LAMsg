using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMsg
{
    internal class TextMeBot
    {
        public string ApiKey { get; set; }
        public string Mensagem { get; set; }

        public string JsonSerializar(TextMeBot txtmebot)
        {
            return JsonConvert.SerializeObject(txtmebot);
        }
        public static TextMeBot JsonDesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<TextMeBot>(Json);
        }
    }
}
