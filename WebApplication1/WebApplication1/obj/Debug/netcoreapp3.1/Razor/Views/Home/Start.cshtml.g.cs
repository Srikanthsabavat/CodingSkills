#pragma checksum "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Start.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "247f205b202bb0e5e3a195acfda178b904a75b08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Start), @"mvc.1.0.view", @"/Views/Home/Start.cshtml")]
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
#line 1 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247f205b202bb0e5e3a195acfda178b904a75b08", @"/Views/Home/Start.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637209e7eeedf13d00f2cccd93a350b795d01eb6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Start : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Start.cshtml"
  
    ViewData["Title"] = "Start";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n <div class=\"index-page-container\">\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <h1 class=\"my-index-title\">Welcome to BlackJack!</h1>\r\n\r\n                <h3 class=\"my-index-desc\">Start a New Game</h3>\r\n\r\n");
#nullable restore
#line 14 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Start.cshtml"
                 using (Html.BeginForm("Index", "Home", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""form-group"">
                        <input type=""hidden"" name=""start"" id=""start"" value=""true"" />
                        <input type=""submit"" value=""Start"" class=""btn btn-warning btn-lg my-wide-button"" />
                    </div>
");
#nullable restore
#line 20 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Start.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
