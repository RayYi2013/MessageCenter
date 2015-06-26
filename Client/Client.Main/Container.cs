using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Client.Main
{
    public class Container
    {
        private static readonly Container instance = new Container();
        private StandardKernel _kernel;
        private Container()
        {
            _kernel = new StandardKernel(new ClientModule());
        }

        public static Container Instance
        {
            get
            {
                return instance;
            }
        }

        public T Get<T>()
        {
            return _kernel.Get<T>();
        }
    }
}
