using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJTRANSFERENCIA
{
    public class Veiculo
    {
        public string strRenavam { get; set; }
        public string strPlaca { get; set; }
        public string strUf { get; set; }
        public string strRntc { get; set; }

    }

    public class VeiculoColecao : List<Veiculo> { }
}
