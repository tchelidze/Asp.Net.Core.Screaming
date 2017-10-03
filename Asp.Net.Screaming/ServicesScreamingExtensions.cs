using System;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.Extensions.DependencyInjection;

namespace Asp.Net.Screaming
{
    public static class ServicesScreamingExtensions
    {
        public static void AddScreaming(this IServiceCollection services)
            => AddScreaming(services, opts => { });

        public static void AddScreaming(this IServiceCollection services, Action<ScremaingOptions> configureScreamingOptions)
        {
            var screamingOptions = new ScremaingOptions();
            configureScreamingOptions(screamingOptions);
            services.Configure(configureScreamingOptions);
            AddScreaming(services, screamingOptions);
        }

        static void AddScreaming(this IServiceCollection services, ScremaingOptions scremaingOptions)
        {
            services.AddSingleton<RazorProject, ScreamingFileProviderRazorProject>();
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add($"{scremaingOptions.FeaturesContainerName}/{{2}}/Views/{{1}}/{{0}}.cshtml");
                options.AreaViewLocationFormats.Add($"{scremaingOptions.FeaturesContainerName}/Shared/Views/{{0}}.cshtml");
            });
        }
    }
}