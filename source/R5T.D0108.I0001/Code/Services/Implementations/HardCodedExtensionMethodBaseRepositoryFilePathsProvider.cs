using System;
using System.Threading.Tasks;

using R5T.D0108.I001;
using R5T.T0064;


namespace R5T.D0108.I0001
{
    [ServiceImplementationMarker]
    public class HardCodedExtensionMethodBaseRepositoryFilePathsProvider : IExtensionMethodBaseRepositoryFilePathsProvider, IServiceImplementation
    {
        public Task<string> GetDuplicateExtensionMethodBaseNamesTextFilePath()
        {
            var output = @"C:\Temp\Extension Method Bases-Duplicate Name Selections.txt";

            return Task.FromResult(output);
        }

        public Task<string> GetExtensionMethodBaseNameSelectionsTextFilePath()
        {
            var output = @"C:\Temp\Extension Method Bases-Selected.txt";

            return Task.FromResult(output);
        }

        public Task<string> GetExtensionMethodBasesListingJsonFilePath()
        {
            var output = @"C:\Temp\Extension Method Bases-All.json";

            return Task.FromResult(output);
        }

        public Task<string> GetIgnoredExtensionMethodBaseNamesTextFilePath()
        {
            var output = @"C:\Temp\Extension Method Bases-Ignored Names.txt";

            return Task.FromResult(output);
        }

        public Task<string> GetToProjectMappingsJsonFilePath()
        {
            var output = @"C:\Temp\Extension Method Bases-To Project Mappings.json";

            return Task.FromResult(output);
        }
    }
}
