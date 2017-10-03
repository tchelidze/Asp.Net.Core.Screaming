﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Asp.Net.Screaming
{
    public static class IRouteBuilderScreamingExtensions
    {
        public static IRouteBuilder MapScreamingRoute(this IRouteBuilder routeBuilder, string defaultFeature = "HomePage", string defaultController = "Home", string defaultAction = "Index")
        {
            routeBuilder.MapRoute(
                "area-route",
                $"{{area:exists={defaultFeature}}}/{{controller={defaultController}}}/{{action={defaultAction}}}");
            return routeBuilder;
        }
    }
}