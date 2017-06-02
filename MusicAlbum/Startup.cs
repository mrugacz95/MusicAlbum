using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicAlbum.Startup))]
namespace MusicAlbum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
