using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ACESSODADOS
{
    public class Acbr
    {
        //falta implementar tempo limite para retorno
        public string EnviarComandoAcbrTxt(string strComando, string strPathEntrada, string strPathSaida)
        {
            //escreve o comando no arquivo de entrada
            System.IO.File.WriteAllText(strPathEntrada, strComando);

            //fica em looping até que o arquivo de saída exista
            while (!System.IO.File.Exists(strPathSaida)) { }

            try
            {
                //retorna resposta escrita no arquivo de saída
                return System.IO.File.ReadAllText(strPathSaida, Encoding.UTF8);

            }
            catch (System.IO.FileLoadException Erro)
            {
                //retorna erro de arquivos
                return "Erro: " + Erro.Message;
            }
            finally
            {
                //apaga o arquivo de saída
                System.IO.File.Delete(strPathSaida);
            }

        }
        

    }
}
