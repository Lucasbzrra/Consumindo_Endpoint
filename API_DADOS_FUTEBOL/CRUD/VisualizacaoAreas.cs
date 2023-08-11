using CONSUMINDO_API_DADOS_FUTEBOL;
using CONSUMINDO_API_DADOS_FUTEBOL.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DADOS_FUTEBOL.CRUD;

public class VisualizacaoAreas 
{
    /// <summary>
    /// Realiza a visualização das informações das áreas filhas contidas em uma instância de 'Areas'.
    /// </summary>
    /// <param name="Areas">Instância de 'Areas' que contém a lista de áreas filhas a serem visualizadas.</param>
    public static void visualizacao(Areas Areas )
    {
        //IEnumerable<AreasFilhas> areasFilhas;
        //areasFilhas = Areas;
        foreach (var item in Areas.Lista_Areas_Filhas)
        {
            Console.WriteLine($"id: {item.Id}");
            Console.WriteLine($"nome: {item.Nome}");
            Console.WriteLine($"flag: {item.Flag}");
            Console.WriteLine("\n---------------------");
        }
    }
  
}
