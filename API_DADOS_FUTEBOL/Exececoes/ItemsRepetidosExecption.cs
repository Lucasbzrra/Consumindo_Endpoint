using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSUMINDO_API_DADOS_FUTEBOL.Exececoes;

public class ItemsRepetidosExecption : Exception
{
    public ItemsRepetidosExecption(string message) : base(message)
    {

    }
}
