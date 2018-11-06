using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comic_books_gallery.Startup))]
namespace Comic_books_gallery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
