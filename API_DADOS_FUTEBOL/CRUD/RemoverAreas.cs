using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONSUMINDO_API_DADOS_FUTEBOL.Modelos;
using CONSUMINDO_API_DADOS_FUTEBOL.Exececoes;

namespace CONSUMINDO_API_DADOS_FUTEBOL;

public class RemoverAreas
{
   /// <summary>
   /// Metodo para fazer exlusão de item na lista de objeto
   /// </summary>
   /// <param name="areas"> terá que passar o objeto que deseja remover</param>
   /// <param name="id"> obrigatorio passar o id para identificar o objeto</param>
   /// <exception cref="ItemNaoEncontrado">É utilizado quando não e encontrado o ojeto na lista </exception>
    public static void ExcluirItem(Areas areas , int id)
    {
        AreasFilhas remover = areas.Lista_Areas_Filhas.Find(z => z.Id == id)!;
        if (remover != null)
        {
            areas.Lista_Areas_Filhas.Remove(remover);
            Console.WriteLine("Iten Removdio");
            
        }
        else
        {
            throw new ItemNaoEncontrado($"O ID {id} Não foi encontrado na nossas bases.");
        }
    }
}
