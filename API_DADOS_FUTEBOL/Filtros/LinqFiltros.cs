using CONSUMINDO_API_DADOS_FUTEBOL.Modelos;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSUMINDO_API_DADOS_FUTEBOL.Filtros;

internal class LinqFiltros 
{
    /// <summary>
    ///Filtra e exibe informações de áreas filhas cujo atributo 'Flag' não é igual a "Vazio"
    /// </summary>
    /// <param name="areas1"> Coleção de áreas filhas a serem filtradas.</param>
    public static  void FiltragemPorItemDiferentesDeNulo(IEnumerable<AreasFilhas> areas1)
    {
        // Filtra as áreas filhas cujo atributo 'Flag' não é igual a "Vazio" e projeta somente os atributos 'Id' e 'Nome'.
        var Deu = areas1.Where(x => x.Flag != "Vazio").Select(x => new { Id = x.Id, Name = x.Nome }).ToList();
        Console.WriteLine("LISTA DE AREAS QUE PREENCHEU O FLAG\n");
        foreach (var x in Deu)
        {
            Console.WriteLine($"ID :{x.Id}");
            Console.WriteLine($"Nome :{x.Name}");
            Console.WriteLine("----------------\n");
        }
    }
}
