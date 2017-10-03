# Asp.Net.Core.Screaming

# Overview

Screaming architecture implmentation for ASP.NET Core 2.0

# Installation

```
PM> Install-Package Asp.Net.Screaming
```

After installation, add following line of code into `ConfigureServices` method of `Startup` class.

```
services.AddScreaming();
```

Add `ScreamingRout` `AddMvc` method parameter inside `Cofigure` method of `Statup.

```
app.UseMvc(routes =>
{
     routes.MapScreamingRoute();
});
```
