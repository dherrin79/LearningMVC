using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddressBook_ben.Startup))]
namespace AddressBook_ben
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
