#pragma checksum "C:\Users\johnn\source\repos\TestAppConfig\Views\Home\Index - WithoutDynamicAppConfig.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05d2fb6cced13e8fbc949697eedb041f1e7c9b04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index___WithoutDynamicAppConfig), @"mvc.1.0.view", @"/Views/Home/Index - WithoutDynamicAppConfig.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\johnn\source\repos\TestAppConfig\Views\_ViewImports.cshtml"
using TestAppConfig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johnn\source\repos\TestAppConfig\Views\_ViewImports.cshtml"
using TestAppConfig.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\johnn\source\repos\TestAppConfig\Views\Home\Index - WithoutDynamicAppConfig.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d2fb6cced13e8fbc949697eedb041f1e7c9b04", @"/Views/Home/Index - WithoutDynamicAppConfig.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e35e05e45b03b1e8e02889d01abe27a0f020ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index___WithoutDynamicAppConfig : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: ");
#nullable restore
#line 6 "C:\Users\johnn\source\repos\TestAppConfig\Views\Home\Index - WithoutDynamicAppConfig.cshtml"
                     Write(Configuration["TestApp:Settings:BackgroundColor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    }\r\n    h1 {\r\n        color: ");
#nullable restore
#line 9 "C:\Users\johnn\source\repos\TestAppConfig\Views\Home\Index - WithoutDynamicAppConfig.cshtml"
          Write(Configuration["TestApp:Settings:FontColor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        font-size: ");
#nullable restore
#line 10 "C:\Users\johnn\source\repos\TestAppConfig\Views\Home\Index - WithoutDynamicAppConfig.cshtml"
              Write(Configuration["TestApp:Settings:FontSize"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    }\r\n</style>\r\n\r\n<h1>\r\n    ");
#nullable restore
#line 15 "C:\Users\johnn\source\repos\TestAppConfig\Views\Home\Index - WithoutDynamicAppConfig.cshtml"
Write(Configuration["TestApp:Settings:Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    and ");
#nullable restore
#line 16 "C:\Users\johnn\source\repos\TestAppConfig\Views\Home\Index - WithoutDynamicAppConfig.cshtml"
   Write(Configuration["TestApp:Settings:KeyVaultMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
