using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CONSUMINDO_API_DADOS_FUTEBOL.Modelos;

public class Areas
{

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("childAreas")]
    public List<AreasFilhas> Lista_Areas_Filhas { get; set; }

    public Areas()
    {
        Lista_Areas_Filhas= new List<AreasFilhas>();
       
    }

    
}
