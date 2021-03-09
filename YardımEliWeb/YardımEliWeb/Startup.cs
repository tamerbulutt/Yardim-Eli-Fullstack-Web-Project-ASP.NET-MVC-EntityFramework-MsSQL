using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(YardımEliWeb.Startup))]

namespace YardımEliWeb
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Uygulamanızı nasıl yapılandıracağınız hakkında daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=316888 adresini ziyaret edin
        }

     /*   public void ConfigureServices(IServiseCollection services)
        {
            services.AddMvc();
        }*/
    }
}
