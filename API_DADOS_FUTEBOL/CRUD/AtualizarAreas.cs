using CONSUMINDO_API_DADOS_FUTEBOL.Modelos;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONSUMINDO_API_DADOS_FUTEBOL.Exececoes;

namespace CONSUMINDO_API_DADOS_FUTEBOL;

public class AtualizarAreas 
{
    /// <summary>
    /// Metodo para fazer atualização de objeto 
    /// </summary>
    /// <param name="areas"> Obrigatorio informar o novo nome </param>
    /// <param name="id"> Obrigatorio informar o id para localizar</param>
    /// <exception cref="ItemNaoEncontrado"> É utilizado quando não é encontrado id na lista</exception>
    public static void AtualizarItem(List<AreasFilhas> areas, int id)
    {
        AreasFilhas areasFilhasAtualizada = areas.Find(z => z.Id == id)!;
        if (areasFilhasAtualizada != null)
        {
            Console.WriteLine("Coloque o nome atualizado");
            areasFilhasAtualizada.Nome = Console.ReadLine()!;

        }
        else
        {
            throw new ItemNaoEncontrado($"O ID {id} Não foi encontrado na nossas bases.");
        }
    }
}

