using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJTRANSFERENCIA
{
    public class NfeEmitente
    {
        public string strCnpj { get; set; }
        public string strNome { get; set; }
        public string strNomeFantasia { get; set; }
        public Endereco endEndereco { get; set; }
        public string strInscricaoEstadual { get; set; }
        public Int32 intCRT { get; set; }
    }
    public class NFEEmitenteColecao : List<NfeEmitente> { }
}
