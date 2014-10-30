using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJTRANSFERENCIA
{
    public class Endereco
    {
        public string strLogradouro { get; set; }
        public string strNumero { get; set; }
        public string strBairro { get; set; }
        public Int32 intCodigoIbgeMunicipio { get; set; }
        public string strMunicipio { get; set; }
        public string strUF { get; set; }
        public string strCep { get; set; }
        public Int32 intCodigoPais { get; set; }
        public string strPais { get; set; }
        public string strTelefone { get; set; }
    }
    public class EnderecoColecao : List<Endereco> { }
}
