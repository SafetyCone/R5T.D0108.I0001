﻿using System;

using R5T.D0108.I001;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0108.I0001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="HardCodedExtensionMethodBaseRepositoryFilePathsProvider"/> implementation of <see cref="IExtensionMethodBaseRepositoryFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IExtensionMethodBaseRepositoryFilePathsProvider> AddHardCodedExtensionMethodBaseRepositoryFilePathsProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IExtensionMethodBaseRepositoryFilePathsProvider>(services => services.AddHardCodedExtensionMethodBaseRepositoryFilePathsProvider());
            return serviceAction;
        }
    }
}
