using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACESSODADOS;

namespace NEGOCIOS
{
    public class NegAcbr
    {
        public string strPathArquivEntradaAcbr;
        public string strPathArquivSaidaAcbr;
        private Acbr ConexaoAcbr = new Acbr();


        public string CTe_StatusServico()
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.StatusServico",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_ValidaCTe(string cArquivo)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.ValidaCTe( " + cArquivo + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_AssinarCTe(string cArquivo)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.AssinarCTe(" + cArquivo + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_ConsultarCTe(string cChaveCTe)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.ConsultarCTe(" + cChaveCTe + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_CancelarCTe(string cChaveCTe, string cJustificativa)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.CancelarCTe(" + cChaveCTe + "," + cJustificativa + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_ImprimirDacte(string cArquivo)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.ImprimirDacte(" + cArquivo + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_ImprimirDactePDF(string cArquivo)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.ImprimirDactePDF(" + cArquivo + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_InutilizarCTe(string cCNPJ, string cJustificativa, int nAno, int nModelo, int nSerie, int nNumInicial, int nNumFinal)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.InutilizarCTe(" + cCNPJ + "," + cJustificativa + "," + nAno + "," + nModelo + "," + nSerie + "," + nNumInicial + "," + nNumFinal + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_EnviarCTe(string cArquivo, int nLote/*,[ nAssina, nImprime ]*/ )
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.EnviarCTe(" + cArquivo + "," + nLote/*,[ nAssina, nImprime ] */+ ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_ReciboCTe(int nRecibo)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.ReciboCTe(" + nRecibo + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_ConsultaCadastro(string cUF, int nDocumento/*, [nIE]*/)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.ConsultaCadastro(cUF, nDocumento, [nIE])",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_CriarCTe(string cTextoIni/*,[ nRetornaXML]*/)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.CriarCTe(" + cTextoIni/*,[ nRetornaXML]*/+ ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_CriarEnviarCTe(string cTextoIni, int nNumLote/*, [ nImprimirDacte ]*/)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.CriarEnviarCTe(" + cTextoIni + "," + nNumLote/*+"," [ nImprimirDacte ]*/+ ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_EnviarLoteCTe(int nLote)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.EnviarLoteCTe(" + nLote + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_EnviarEmail(string cEmailDestino, string cArqXML, string cEnviaPDF/*,[cAssunto],[cEmailsCopias]*/)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.EnviarEmail(" + cEmailDestino + "," + cArqXML + "," + cEnviaPDF/*,[cAssunto],[cEmailsCopias]*/+ ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_SetCertificado(Int32 cNumCertificado)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.SetCertificado(" + cNumCertificado + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_SetAmbiente(Int32 nNumAmbiente)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.SetAmbiente(" + nNumAmbiente + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_SetFormaEmissao(Int32 nFormaEmissao)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.SetFormaEmissao(" + nFormaEmissao + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_LerCTe(string cArqXML)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.LerCTe(" + cArqXML + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_CTeToTXT(string cArqXML, string cNomeArqTXT)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.CTeToTXT(" + cArqXML + "," + cNomeArqTXT + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_SavetoFile(string cNomeArq, string cConteudoArq)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.SavetoFile(" + cNomeArq + "," + cConteudoArq + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }


        public string CTe_LoadfromFile(string cNomeArq, Int32 nSegundos)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.LoadfromFile(" + cNomeArq + "," + nSegundos + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_FileExists(string cNomeArq)
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.FileExists(" + cNomeArq + ")",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_LerIni()
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.LerIni",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_Ocultar()
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.Ocultar",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_EncerrarMonitor()
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.EncerrarMonitor",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }

        public string CTe_Ativo()
        {
            return
            ConexaoAcbr.EnviarComandoAcbrTxt("CTe.Ativo",
            strPathArquivEntradaAcbr,
            strPathArquivSaidaAcbr
            );
        }


    }
}
