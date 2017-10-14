# Asp.Net  Core Screaming 

# Overview

Enables custom view location according to screaming architecture in ASP.NET Core 2.0

# [Nuget](https://www.nuget.org/packages/Asp.Net.Core.Screaming/)

```
PM> Install-Package Asp.Net.Core.Screaming
```

After installation, add following line of code into `ConfigureServices` method of `Startup` class.

```c#
services.AddScreaming();
```

Add `ScreamingRoute` as part of mvc route configuration. 

```c#
app.UseMvc(routes =>
{
     routes.MapScreamingRoute();
});
```

# Resharper support

In order resharper to recognize custom view locations and enable intellisense

* `Install-Package JetBrains.Annotations`

* Add **empty** `AssemblyAttributes.cs` file at **top level** of startup project

* Add following to `AssemblyAttributes.cs`

```c#
using JetBrains.Annotations;

[assembly: AspMvcViewLocationFormat(@"~\Features\HomePage\Views\{1}\{0}.cshtml")]
[assembly: AspMvcViewLocationFormat(@"~\Features\Membership\Views\{1}\{0}.cshtml")]
[assembly: AspMvcViewLocationFormat(@"~\Features\Shared\Views\{0}.cshtml")]
```
*Replace `Features` with your custom `FeaturesContainerName` if you have specified custom feauter name in `services.AddScreaming()`*

**Resharper [does not support area placeholders](https://resharper-support.jetbrains.com/hc/en-us/community/posts/115000351724-Asp-net-Core-MVCAreas-not-showing-up-in-asp-area-tag-helper) inside `AspMvcViewLocationFormat` attribute. So you have to explicitly add new `AspMvcViewLocationFormat` for each `Features` folder's subfolder (like `HomePage`, `Membership`, etc).**

