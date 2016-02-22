using System;
using Owin;
using Umbraco.Web;

namespace Umbraco741Hangfire
{
    public class OwinStartup : UmbracoDefaultOwinStartup
    {
        public override void Configuration(IAppBuilder app)
        {
            base.Configuration(app);

            Console.WriteLine("Setting up Hangfire...");
        }
    }
}