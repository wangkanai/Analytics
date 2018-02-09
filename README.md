## [Wangkanai Analytics](http://analytics.wangkanai.org/)

[![Build status](https://ci.appveyor.com/api/projects/status/t46adtm386rxiqam?svg=true)](https://ci.appveyor.com/project/wangkanai/analytics) 
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/Wangkanai.Analytics.svg?maxAge=3600)](https://www.nuget.org/packages/Wangkanai.Analytics/)

### What is Wangkanai Analytics?
Wangkanai Analytics is a [.NET Core](https://dotnet.github.io/) lightweight server-side code that generator library that JavaScript client-side on the fly for [Google Analytics **analytics.js**](https://developers.google.com/analytics/devguides/collection/analyticsjs/). The goal of the framework is to stay out of the way as much as possible and provide a super interaction with Google all from C#.

### Installation

Add the NuGet package to your project.

```
PM> install-package Wangkanai.Analytics -pre
```

Add the service to your web app.

```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Add application services.
    services.AddAnalytics("UA-XXXX-Y");

    // Add framework services.
    services.AddMvc();    
}
```

#### Using IntelliSense

![AddAnalytics IntelliSense](wiki/images/AddAnalytics-Intellisense.png)

![AddAnalytics TrackerId](wiki/images/AddAnalytics-trackerId.png)

#### Official Plugins extensions
- [Display Features](https://developers.google.com/analytics/devguides/collection/analyticsjs/display-features)
- [Enhanced link attribution](https://developers.google.com/analytics/devguides/collection/analyticsjs/enhanced-link-attribution)
- [Linker](https://developers.google.com/analytics/devguides/collection/analyticsjs/linker)
```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Add application services.
    services.AddAnalytics("UA-XXXX-Y")
        .AddDisplayFeatures()
        .AddLinkAttribution()
        .AddLinker(); 

    // Add framework services.
    services.AddMvc();       
}
```
- [Ecommerce](https://developers.google.com/analytics/devguides/collection/analyticsjs/ecommerce)
```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Add application services.
    services.AddAnalytics("UA-XXXX-Y")
        .AddEcommerce();        

    // Add framework services.
    services.AddMvc();
}
```
- [Enhanced Ecommerce](https://developers.google.com/analytics/devguides/collection/analyticsjs/enhanced-ecommerce)
```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Add application services.
    services.AddAnalytics("UA-XXXX-Y")
        .AddEcommerceEnhanced(); 

    // Add framework services.
    services.AddMvc();       
}
```

#### Where it originated from?
This original library that was introduced in [CodePlex](https://archive.codeplex.com/?p=universalanalytics). The library was for .NET Framework web application to render **analytics.js** javascript client-side to interact with Google API from .NET language web application within the server-side code environment. Both ASP.NET WebForm and ASP.NET MVC. Its was good, but we would like to see a much more extensible and ambust platform, so we are rewriting the entire framework.

#### How do i contribute?
Universal Analytics is a powerful and continuous improving platform. We would like to invite developers to help maintain and add features so that this library is keep aligned with most of the popular web analytics out there. 


![mvc showcase](https://raw.githubusercontent.com/wangkanai/analytics/master/Analytics/wiki/Universal-Analytics-Mvc.png)
