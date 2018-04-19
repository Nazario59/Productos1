using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Products1.BacKend.Startup))]
namespace Products1.BacKend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
