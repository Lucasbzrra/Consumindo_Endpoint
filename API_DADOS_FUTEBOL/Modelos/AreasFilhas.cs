using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CONSUMINDO_API_DADOS_FUTEBOL.Modelos
{
    public class AreasFilhas
    {
        [JsonPropertyName("id")]

        public int Id { get; set; }

        [JsonPropertyName("name")]

        public string Nome { get; set; }

        private string _FLag;
        [JsonPropertyName("flag")]
        public string Flag
        {
            get { return _FLag; }
            set
            {
                if (value == null)
                {
                    _FLag = "Vazio";
                }
                else
                {
                    _FLag = value;
                }
            }
        }



    }
}
