using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using ACESSODADOS;

namespace NEGOCIOS
{
    public class NegCertificado
    {
        //Reads a file.
        internal static byte[] LerCertificado(string fileName)
        {
            /*
            FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int size = (int)f.Length;
            byte[] data = new byte[size];
            size = f.Read(data, 0, size);
            f.Close();
            return data;
             */
            return new Arquivo().LerArquivoBytes(fileName);
        }
        public string getSerialCertificado(string strPathCertificado)
        {
            X509Certificate2 x509 = new X509Certificate2();

            byte[] btCertificado = LerCertificado(strPathCertificado);
            x509.Import(btCertificado);

            return x509.SerialNumber;
        }
        public DateTime getDataValidadeCertificado(string strPathCertificado)
        {
            X509Certificate2 x509 = new X509Certificate2();

            byte[] btCertificado = LerCertificado(strPathCertificado);
            x509.Import(btCertificado);

            return x509.NotBefore;
        }
        public DateTime getDataExpiracaoCertificado(string strPathCertificado)
        {
            X509Certificate2 x509 = new X509Certificate2();

            byte[] btCertificado = LerCertificado(strPathCertificado);
            x509.Import(btCertificado);

            return x509.NotAfter;
        }

    }
}
