using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACESSODADOS;
using System.Xml;
using OBJTRANSFERENCIA;

namespace NEGOCIOS
{
    public class NegNfe
    {
        Arquivo manipuladorArquivo = new Arquivo();
        public NfeEmitente BuscaEmitenteNFEXml(string strPathDiretorio)
        {
            try
            {
                NfeEmitente ObjnfeEmitente = new NfeEmitente();
                Endereco objEndereco = new Endereco();

                XmlDocument xml = new XmlDocument();

                xml.Load(strPathDiretorio);

                #region PREENCHE O EMITENTE
                XmlNodeList xmlListaEmitente = xml.GetElementsByTagName("emit");
                ObjnfeEmitente.strCnpj = xmlListaEmitente[0].ChildNodes[0].InnerText;
                ObjnfeEmitente.strNome = xmlListaEmitente[0].ChildNodes[1].InnerText;
                ObjnfeEmitente.strNomeFantasia = xmlListaEmitente[0].ChildNodes[2].InnerText;

                #region PREENCHE O ENDEREÇO
                objEndereco.strLogradouro = xmlListaEmitente[0].ChildNodes[3].ChildNodes[0].InnerText;
                objEndereco.strNumero = xmlListaEmitente[0].ChildNodes[3].ChildNodes[1].InnerText;
                objEndereco.strBairro = xmlListaEmitente[0].ChildNodes[3].ChildNodes[2].InnerText;
                objEndereco.intCodigoIbgeMunicipio = Convert.ToInt32(xmlListaEmitente[0].ChildNodes[3].ChildNodes[3].InnerText);
                objEndereco.strMunicipio = xmlListaEmitente[0].ChildNodes[3].ChildNodes[4].InnerText;
                objEndereco.strUF = xmlListaEmitente[0].ChildNodes[3].ChildNodes[5].InnerText;
                objEndereco.strCep = xmlListaEmitente[0].ChildNodes[3].ChildNodes[6].InnerText;
                objEndereco.intCodigoPais = Convert.ToInt32(xmlListaEmitente[0].ChildNodes[3].ChildNodes[7].InnerText);
                objEndereco.strPais = xmlListaEmitente[0].ChildNodes[3].ChildNodes[8].InnerText;
                objEndereco.strTelefone = xmlListaEmitente[0].ChildNodes[3].ChildNodes[9].InnerText;
                //seta e endereço dentro do nfeEmitente
                ObjnfeEmitente.endEndereco = objEndereco;
                #endregion

                ObjnfeEmitente.strInscricaoEstadual = ObjnfeEmitente.strNomeFantasia = xmlListaEmitente[0].ChildNodes[4].InnerText;
                ObjnfeEmitente.intCRT = Convert.ToInt32(xmlListaEmitente[0].ChildNodes[5].InnerText);


                #endregion

                return ObjnfeEmitente;
            }
            catch (Exception Erro)
            {
                //escrever em arquivo de Log
                manipuladorArquivo.EscreverArquivoLogErros(Erro.Message);
                return null;
            }
        }
        public string BuscaCnpjTransportadoraNFEXml(string strPathDiretorio)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(strPathDiretorio);

                XmlNodeList xmlListaEmitente = xml.GetElementsByTagName("transporta");
                return xmlListaEmitente[0].ChildNodes[0].InnerText;
            }
            catch (Exception Erro)
            {
                //escrever em arquivo de Log
                manipuladorArquivo.EscreverArquivoLogErros(Erro.Message);
                return null;
            }

        }
        public Veiculo BuscaVeiculoNFEXml(string strPathDiretorio)
        {
            try
            {
                XmlDocument xml = new XmlDocument();

                xml.Load(strPathDiretorio);

                Veiculo objVeiculo = new Veiculo();


                XmlNodeList xmlListaEmitente = xml.GetElementsByTagName("veicTransp");
                objVeiculo.strPlaca = xmlListaEmitente[0].ChildNodes[0].InnerText;
                objVeiculo.strUf = xmlListaEmitente[0].ChildNodes[1].InnerText;
                objVeiculo.strRntc = xmlListaEmitente[0].ChildNodes[2].InnerText;

                return objVeiculo;
            }
            catch (Exception Erro)
            {
                //escrever em arquivo de Log
                manipuladorArquivo.EscreverArquivoLogErros(Erro.Message);
                //continua processamento
                return null;
            }
        }
        
    }
}
