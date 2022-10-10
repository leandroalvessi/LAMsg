using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LAMsg
{
    internal class Campos
    {
        public string IdInstancia { get; set; }
        public string Token { get; set; }
        public string Mensagem { get; set; }

        public string JsonSerializar(Campos campos)
        {
            return JsonConvert.SerializeObject(campos);
        }
        public static Campos JsonDesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<Campos>(Json);
        }
    }
}
