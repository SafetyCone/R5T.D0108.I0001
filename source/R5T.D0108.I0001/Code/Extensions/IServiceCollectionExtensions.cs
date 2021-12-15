using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0108.I001;
using R5T.T0063;


namespace R5T.D0108.I0001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="HardCodedExtensionMethodBaseRepositoryFilePathsProvider"/> implementation of <see cref="IExtensionMethodBaseRepositoryFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddHardCodedExtensionMethodBaseRepositoryFilePathsProvider(this IServiceCollection services)
        {
            services.AddSingleton<IExtensionMethodBaseRepositoryFilePathsProvider, HardCodedExtensionMethodBaseRepositoryFilePathsProvider>();

            return services;
        }
    }
}
