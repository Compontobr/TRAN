using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace NEGOCIOS
{
    public class Certificado
    {
        public X509Certificate2Collection ObterListaCertificados()
        {
            X509Store stores = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            try
            {
                // Abre o Store
                stores.Open(OpenFlags.ReadOnly);

                // Obtém a coleção dos certificados da Store
                X509Certificate2Collection certificados = stores.Certificates;

                /*
                // percorre a coleção de certificados
                foreach (X509Certificate2 certificado in certificados)
                {
                    // faz algo com o certificado
                }
                 */

                return certificados;
            }
            finally
            {
                stores.Close();
            }
        }

        public void teste() 
        {
            
        }
    }
}
