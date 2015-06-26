using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Wcf;
using Ninject.Modules;
using Ninject.Parameters;
using Server.Common;
using Server.Data.QueryProcessors;
using Server.Data.SqlServer.QueryProcessors;
using Server.Service;

namespace Server.Host
{
    class ServiceModule : NinjectModule
    {

        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            this.Bind<IAddMessageQueryProcessor>().To<AddMessageQueryProcessor>();
            this.Bind<IGetAllMessagesQueryProcessor>().To<GetAllMessagesQueryProcessor>();
            this.Bind<IMessageRepo>().To<MessageRepo>();

            this.Bind<IMessageService>().To<MessageService>();

            //this.Bind<ServiceHost>().To<NinjectServiceHost>();

            this.Bind<ServiceHost>().ToMethod(ctx => ctx.Kernel.Get<NinjectServiceHost>(new ConstructorArgument("singletonInstance", c => c.Kernel.Get<IMessageService>())));
 
        }
    }
}
