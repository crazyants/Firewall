using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Builder;

namespace Firewall
{
    /// <summary>
    /// Extension methods for registering Firewall middleware.
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Adds the <see cref="FirewallMiddleware"/> to the ASP.NET Core pipeline.
        /// <para>The Firewall should be registered after global error handling and before any other middleware.</para>
        /// </summary>
        /// <param name="builder">The application builder which is used to register all ASP.NET Core middleware.</param>
        /// <param name="rulesEngine">The Firewall rules which should be used for request filtering.</param>
        public static IApplicationBuilder UseFirewall(
            this IApplicationBuilder builder, IFirewallRule rulesEngine) =>
                builder.UseMiddleware<FirewallMiddleware>(rulesEngine);
    }
}