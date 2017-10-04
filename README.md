# Asp.Net.Core.Screaming

# Overview

Screaming architecture implmentation for ASP.NET Core 2.0

# Installation

```
PM> Install-Package Asp.Net.Screaming
```

After installation, add following line of code into `ConfigureServices` method of `Startup` class.

```c#
services.AddScreaming();
```

Add `ScreamingRout` `AddMvc` method parameter inside `Cofigure` method of `Statup.

```c#
app.UseMvc(routes =>
{
     routes.MapScreamingRoute();
});
```

# Resharper support

In order resharper to recognize custom view locations and enable intellisense

* Install JetBrains.Annotation nuget package

* Add empty `AssemblyAttributes.cs` file at top level of startup project

* Add following to `AssemblyAttributes.cs`

```c#
using JetBrains.Annotations;

[assembly: AspMvcViewLocationFormat(@"~\Features\HomePage\Views\{1}\{0}.cshtml")]
[assembly: AspMvcViewLocationFormat(@"~\Features\Membership\Views\{1}\{0}.cshtml")]
[assembly: AspMvcViewLocationFormat(@"~\Features\Shared\Views\{0}.cshtml")]
```
*Replace `Features` with your custom `FeaturesContainerName` if you have one*

**Resharper [does not support area placeholders](https://resharper-support.jetbrains.com/hc/en-us/community/posts/115000351724-Asp-net-Core-MVCAreas-not-showing-up-in-asp-area-tag-helper) inside `AspMvcViewLocationFormat` attribute. So you have to explicitly add new `AspMvcViewLocationFormat` for each feature folder you add.**

