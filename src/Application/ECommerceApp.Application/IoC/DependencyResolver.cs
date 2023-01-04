using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;


namespace ECommerceApp.Application.IoC
{
    public class DependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //IoC --> Yani interface çağırdıgım zaman bana onun concrete yapısını getirmesi gerektiği işlemi burada söylüyorum

            //ÖRNEK  : builder.RegisterType<BaseRepo>().As<IBaseRepo>().InsatancePerLifeTimeScope();

            //program.cs tarafında yapacağım eklemeleri buradan yapabilirim.

            //örnek olarak automapper eklenmesi buradan yapabilirim
            base.Load(builder);
        }
    }
}
