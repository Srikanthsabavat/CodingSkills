#pragma checksum "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6911ba9277eafc74c9cb84bf8f35aa3b97e86cb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6911ba9277eafc74c9cb84bf8f35aa3b97e86cb2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637209e7eeedf13d00f2cccd93a350b795d01eb6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Game>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6911ba9277eafc74c9cb84bf8f35aa3b97e86cb23188", async() => {
                WriteLiteral(@"
  
         <div class=""row my-game-rows"">
                <div class=""col-xs-12 col-sm-3 h3 my-vertical-center"">
                    <p>Dealer</p>
                </div>
           
    <div class=""col-xs-12 col-sm-5 my-dealer-cards"" id=""my-dealer-cards"">
                    <div class=""my-cards-container"">
               

");
#nullable restore
#line 15 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
         foreach (var dealer in ViewBag.Dealer)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(dealer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 20 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        </div>\r\n        <br />\r\n        <h4>Dealer Score = ");
#nullable restore
#line 24 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                      Write(ViewBag.SumDealer);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h4>\r\n        <br />\r\n        </div>\r\n");
                WriteLiteral("\r\n");
                WriteLiteral(@"         <div class=""row my-game-rows"">
                <div class=""col-xs-12 col-sm-3 h3 my-vertical-center"">
                    <p>Player</p>
                </div>
           
    <div class=""col-xs-12 col-sm-5 my-dealer-cards"" id=""my-dealer-cards"">
                    <div class=""my-cards-container"">
        
");
#nullable restore
#line 39 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
         foreach (var player in ViewBag.Player)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                <td>");
#nullable restore
#line 42 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(player);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("       </div>\r\n        </div>\r\n        <br />\r\n         <h4>Player Score = ");
#nullable restore
#line 48 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                       Write(ViewBag.SumPlayer);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h4>\r\n         \r\n        <br />\r\n        </div>\r\n\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n\r\n\r\n\r\n            <div class=\"row my-game-rows\">\r\n\r\n                <div class=\"col-xs-12 col-sm-3 h3 my-vertical-center\">\r\n\r\n");
#nullable restore
#line 64 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
        using (Html.BeginForm("HitButton", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                   <div>
                                 <input type=""hidden"" name=""Hit"" id=""hit"" value=""Hit"" />
                                <input type=""submit"" value="" Hit "" class=""btn btn-success btn-lg my-wide-button"" />
                               
                                   </div>
");
#nullable restore
#line 71 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"

                                   
                                 
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        </div>\r\n\r\n        \r\n\r\n");
                WriteLiteral("            \r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 85 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
           using (Html.BeginForm("Playagain", "Home", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""col-xs-12 col-sm-3 h3 my-vertical-center form-group"">
                        <input type=""hidden"" name=""Playagain"" id=""Playagain"" value=""true"" />
                        <input type=""submit"" value=""Playagain"" class=""btn btn-warning btn-lg my-wide-button"" />
                    </div>
");
#nullable restore
#line 91 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("        \r\n}\r\n<div class=\"col-xs-12 col-sm-5 d-flex flex-row justify-content-end my-dealer-cards pr-5\" id=\"my-dealer-cards\">\r\n                    <div class=\"my-cards-container pr-3\">\r\n");
#nullable restore
#line 98 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                         using (Html.BeginForm("HitButton", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div>    <input type=""hidden"" name=""Stand"" id=""Stand"" value=""Stand"" />
                                <input type=""submit"" value=""Stand"" class=""btn btn-success btn-lg my-wide-button"" />
                                </div>
");
#nullable restore
#line 103 "D:\MyFirstProject\BlackJack-master\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                               
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("     </div>\r\n                                        </div>\r\n                                                 ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Game> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
