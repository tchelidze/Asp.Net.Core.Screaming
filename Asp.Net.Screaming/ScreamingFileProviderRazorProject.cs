using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.Extensions.Options;

namespace Asp.Net.Screaming
{
    public class ScreamingFileProviderRazorProject : FileProviderRazorProject
    {
        readonly ScremaingOptions _screamingOptions;
        public ScreamingFileProviderRazorProject(
            IRazorViewEngineFileProviderAccessor accessor,
            IOptions<ScremaingOptions> screamingOptionss)
            : base(accessor) => _screamingOptions = screamingOptionss.Value;

        public override IEnumerable<RazorProjectItem> FindHierarchicalItems(string basePath, string path, string fileName)
            => base.FindHierarchicalItems(basePath, path, fileName)
                .Append(GetItem($"/{_screamingOptions.FeaturesContainerName}/Shared/Views/_ViewImports.cshtml"))
                .Append(GetItem($"/{_screamingOptions.FeaturesContainerName}/Shared/Views/_ViewStart.cshtml"));
    }
}