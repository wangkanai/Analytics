## [Universal Analytics](http://wangkanai.github.io/analytics/)

[![Build status](https://ci.appveyor.com/api/projects/status/t46adtm386rxiqam?svg=true)](https://ci.appveyor.com/project/wangkanai/analytics)

### What is Universal Analytics?
Universal Analytics is a [.NET Core](https://dotnet.github.io/) lightweight server-side code that generator library that JavaScript client-side on the fly for Google Analytics Web API. The goal of the framework is to stay out of the way as much as possible and provide a super interaction with Google all from C#.

Write your application

```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Add framework services.
    services.AddUniversalAnalytics("UA-XXXX-Y");
            
    services.AddMvc();
}
```

### Where it originated from?
This original library that was introduced in [CodePlex](http://universalanalytics.codeplex.com). The library was for .NET Framework web application to render **analytics.js** javascript client-side to interact with Google API from .NET language web application within the server-side code environment. Both ASP.NET WebForm and ASP.NET MVC. Its was good, but we would like to see a much more extensible and ambust platform, so we are rewriting the entire framework.

### How do i contribute?
Universal Analytics is a powerful and continuous improving platform. We would like to invite developers to help maintain and add features so that this library is keep aligned with most of the popular web analytics out there. 


![mvc showcase](https://raw.githubusercontent.com/wangkanai/analytics/master/Analytics/wiki/Universal-Analytics-Mvc.png)
