using System;


namespace Microsoft.Extensions.Hosting
{
    public static class HostBuilderHelper
    {
        /// <summary>
        /// The default host builder is nothing more than the <see cref="HostBuilder"/> default constructor.
        /// </summary>
        public static IHostBuilder GetDefaultHostBuilder()
        {
            // Nothing fancy.
            var hostBuilder = new HostBuilder();
            return hostBuilder;
        }
    }
}
