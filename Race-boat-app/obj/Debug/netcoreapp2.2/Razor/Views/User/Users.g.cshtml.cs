#pragma checksum "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\User\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c5bd3af247c068f4466d8c3ff32227636df9112"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Users), @"mvc.1.0.view", @"/Views/User/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Users.cshtml", typeof(AspNetCore.Views_User_Users))]
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
#line 1 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\_ViewImports.cshtml"
using Race_boat_app;

#line default
#line hidden
#line 2 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\_ViewImports.cshtml"
using Race_boat_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c5bd3af247c068f4466d8c3ff32227636df9112", @"/Views/User/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5a3f5aabc245a5c220e2b6dae0dc8c7387a054", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/profile.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
  
    ViewData["Title"] = "User";
    var users = ViewData.Model;

#line default
#line hidden
            BeginContext(70, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(849, 4, true);
            WriteLiteral("\n\n\n\n");
            EndContext();
            BeginContext(985, 56, true);
            WriteLiteral("\n\n    <div class=\"container\">\n        <div class=\"row\">\n");
            EndContext();
#line 45 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
             foreach (var user in users)
            {

#line default
#line hidden
            BeginContext(1096, 112, true);
            WriteLiteral("                <div class=\"col-sm-4\">\n                    <div class=\"card user-card\">\n                        ");
            EndContext();
            BeginContext(1208, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8c5bd3af247c068f4466d8c3ff32227636df91125328", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1282, 127, true);
            WriteLiteral("\n                        <div class=\"card-body user-card-body text-center\">\n                            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1410, 14, false);
#line 51 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                              Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1424, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(1431, 13, false);
#line 51 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                                                   Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 94, true);
            WriteLiteral("</h5>\n                            <p class=\"card-text\">\n                                <span>");
            EndContext();
            BeginContext(1539, 10, false);
#line 53 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                 Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1549, 58, true);
            WriteLiteral("</span><br />\n                                <span>Team: ");
            EndContext();
            BeginContext(1608, 9, false);
#line 54 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                       Write(user.Team);

#line default
#line hidden
            EndContext();
            BeginContext(1617, 59, true);
            WriteLiteral("</span><br />\n                                <span>Phone: ");
            EndContext();
            BeginContext(1677, 16, false);
#line 55 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                        Write(user.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1693, 430, true);
            WriteLiteral(@"</span>
                            </p>
                            <div>
                                <a href=""#""><i class=""fab fa-dribbble""></i></a>
                                <a href=""#""><i class=""fab fa-twitter""></i></a>
                                <a href=""#""><i class=""fab fa-linkedin""></i></a>
                                <a href=""#""><i class=""fab fa-facebook""></i></a>
                            </div>

");
            EndContext();
            BeginContext(2219, 148, true);
            WriteLiteral("                        </div>\n                        <p style=\"margin:0px;\">\n                            <button class=\"user-card-button\">Contact ");
            EndContext();
            BeginContext(2368, 14, false);
#line 67 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                                                Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2382, 89, true);
            WriteLiteral("</button>\n                        </p>\n                    </div>\n                </div>\n");
            EndContext();
#line 71 "C:\Users\patri\Downloads\Full_racing_code-master\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
            }

#line default
#line hidden
            BeginContext(2485, 31, true);
            WriteLiteral("            </div>\n    </div>\n\n");
            EndContext();
        }
        #pragma warning restore 1998
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
