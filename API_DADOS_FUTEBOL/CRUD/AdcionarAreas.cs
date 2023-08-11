using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONSUMINDO_API_DADOS_FUTEBOL.Modelos;
using CONSUMINDO_API_DADOS_FUTEBOL.Exececoes;

namespace CONSUMINDO_API_DADOS_FUTEBOL;

public class AdcionarAreas
{
    /// <summary>
    /// Adiciona um novo item à lista de áreas filhas, verificando se o ID ou o nome já existem na lista.
    /// </summary>
    /// <param name="areasFilhas"> Obrigatorio ser do tipo objeto</param>
    /// <param name="id"> ID do novo item  </param>
    /// <param name="nome"> Nome do novo item</param>
    /// <param name="flag"> Flag e opcional</param>
    /// <exception cref="ItemsRepetidosExecption"></exception>
    public static void AdcionandoItem(List<AreasFilhas> areasFilhas, int id, string nome, string? flag)
    {
        bool foiencontrado = false;
        foreach (var item in areasFilhas)
        {
            if (item.Id.Equals(id) || item.Nome.Contains(nome))
            {
                foiencontrado = true;
                throw new ItemsRepetidosExecption($"O ID {id} e {nome} está repitido.");
                break;
            }

        }
        if (foiencontrado == false)
        {
            AreasFilhas areasfilhas = new AreasFilhas()
            {
                Id = id,
                Nome = nome,
                Flag = flag
            };
            areasFilhas.Add(areasfilhas);

        }
    }
}