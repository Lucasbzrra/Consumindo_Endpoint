using API_DADOS_FUTEBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSUMINDO_API_DADOS_FUTEBOL.Exececoes;

public class ItemNaoEncontrado : Exception
{
    public ItemNaoEncontrado(string message) : base(message)
    {

    }
}
