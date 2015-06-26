using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Common;
using Client.Proxy;
using Ninject.Modules;

namespace Client.Main
{
    public class ClientModule : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            this.Bind<Client.Proxy.IMessageService>().To<Client.Proxy.MessageService>();
            this.Bind<Client.Common.IMessageRepo>().To<IMessageRepo>();

        }
    }
}
