using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TkClothesStore_Web.Startup))]
namespace TkClothesStore_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
