using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace ACESSODADOS
{
    public class Arquivo
    {

        public void EscreverArquivoTexto(string strPathArquivo, string strTextoConteudo)
        {
            File.WriteAllText(strPathArquivo, strTextoConteudo);
        }
        public void ConcatenarArquivoTexto(string strPathArquivo, string strTextoConteudo)
        {
            File.AppendAllText(strPathArquivo, strTextoConteudo);
        }
        public void EscreverArquivoBytes(string strPathArquivo, byte[] btTextoConteudo)
        {
            File.WriteAllBytes(strPathArquivo, btTextoConteudo);
        }
        public string LerArquivoTexto(string strPathArquivo)
        {
            return File.ReadAllText(strPathArquivo);
        }
        public byte[] LerArquivoBytes(string strPathArquivo)
        {
            return File.ReadAllBytes(strPathArquivo);
        }
        public Boolean ArquivoExiste(string strPathArquivo)
        {
            return File.Exists(strPathArquivo);
        }
        public Boolean DiretorioExiste(string strPathDiretorio)
        {
            return Directory.Exists(strPathDiretorio);
        }
        public void ApagarArquivo(string strPathArquivo)
        {
            File.Delete(strPathArquivo);
        }
        public void MoverArquivo(string strPathArquivo, string strPathDiretorioDestino)
        {
            File.Move(strPathArquivo, strPathDiretorioDestino);
        }
        public XmlDocument LerArquivoXml(string strPathArquivo)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(strPathArquivo);
            return xmlDoc;
        }
        public void EscreverArquivoXml(string strPathArquivo, XmlDocument xmlDoc)
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Save(strPathArquivo);
        }
        public void CriarDiretorio(string strPath)
        {
            Directory.CreateDirectory(strPath);
        }
        public void EscreverArquivoLogErros(string strMensagem)
        {
            string strPathDiretorioLogCombrTran = @"C://CombrTran";
            string strPathArquivo = strPathDiretorioLogCombrTran + @"//" + "LogErros.txt";

            if (!DiretorioExiste(strPathDiretorioLogCombrTran))
            {
                CriarDiretorio(strPathDiretorioLogCombrTran);

            }
            else
            {
                if (!ArquivoExiste(strPathArquivo))
                {
                    EscreverArquivoTexto(strPathArquivo, strMensagem);
                }
                else
                {
                    ConcatenarArquivoTexto(
                        strPathArquivo,
                        Environment.NewLine +
                        Environment.NewLine +
                        "###############################" +
                        Environment.NewLine +
                        Environment.NewLine +
                        strMensagem);

                }
            }
        }

    }
}
