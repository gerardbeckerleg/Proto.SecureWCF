using System;

namespace SecureClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Service1Client();

            //System.Net.ServicePointManager.ServerCertificateValidationCallback +=
            //    (se, cert, chain, sslerror) =>
            //    {
            //        return true;
            //    };

            var result = client.GetData(1);

            Console.WriteLine(result);
        }
    }
}

