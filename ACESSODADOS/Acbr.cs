using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACESSODADOS
{
    public class Acbr
    {
        //falta implementar tempo limite para retorno
        public string EnviarComandoAcbrTxt(string strComando, string strPathEntrada, string strPathSaida)
        {
            //escreve o comando no arquivo de entrada
            new Arquivo().EscreverArquivoTexto(strPathEntrada, strComando);

            //fica em looping até que o arquivo de saída exista
            while (!new Arquivo().ArquivoExiste(strPathSaida)) { }

            try
            {
                //retorna resposta escrita no arquivo de saída
                return new Arquivo().LerArquivoTexto(strPathSaida);

            }
            catch (System.IO.FileLoadException Erro)
            {
                //retorna erro de arquivos
                return "Erro: " + Erro.Message;
            }
            finally
            {
                //apaga o arquivo de saída
                new Arquivo().ApagarArquivo(strPathSaida);
            }

        }


    }
}
