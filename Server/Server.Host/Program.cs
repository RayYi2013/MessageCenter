using System;
using System.ServiceModel;
using Ninject;
using Ninject.Extensions.Wcf;
using Server.Service;

namespace Server.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new ServiceModule());
            var host = kernel.Get<ServiceHost>();
            try
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now);
                Console.ReadLine();
            }
            finally
            {
                host.Close();
            }
        }

        

        
    }
}
