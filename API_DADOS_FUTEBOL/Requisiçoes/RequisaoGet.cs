using CONSUMINDO_API_DADOS_FUTEBOL.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DADOS_FUTEBOL.Requisiçoes
{
    public class RequisaoGet
    {
        /// <summary>
        /// Realiza uma chamada à API para obter informações de uma área específica.
        /// </summary>
        /// <returns>Instância da classe 'Areas' contendo as informações obtidas da API.</returns>
        public static Areas Chamado()
        {
            // Cria uma instância do HttpClient para realizar a chamada à API.
            HttpClient client = new HttpClient();
            // Cria uma requisição para a API com a URL da área desejada.
            var request = new HttpRequestMessage
            {

                RequestUri = new Uri("http://api.football-data.org/v4/areas/2267"),
                Method = HttpMethod.Get
            };
            // Adiciona o token de autenticação aos cabeçalhos da requisição.
            request.Headers.Add("X-Auth-Token", "ColoqueSuaSenha");
            // Envia a requisição à API e aguarda a resposta.
            var response = client.SendAsync(request).Result;
            // Lê o conteúdo da resposta como uma string.
            var responseBody = response.Content.ReadAsStringAsync().Result;
            // Desserializa o JSON obtido em uma instância da classe 'Areas'.
            Areas DadosDeTimes = System.Text.Json.JsonSerializer.Deserialize<Areas>(responseBody)!;
            return DadosDeTimes;
        }
    }
}
