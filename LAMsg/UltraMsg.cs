using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LAMsg
{
    internal class UltraMsg
    {
        public string IdInstancia { get; set; }
        public string Token { get; set; }
        public string Mensagem { get; set; }

        public string JsonSerializar(UltraMsg ultmsg)
        {
            return JsonConvert.SerializeObject(ultmsg);
        }
        public static UltraMsg JsonDesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<UltraMsg>(Json);
        }
    }
}
