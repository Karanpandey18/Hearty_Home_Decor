#pragma checksum "D:\DOT NET COre MVC project for learning\HomeDecorProject\HeartyHomeDecor\HeartyHomeDecor\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98761ce1d8eaea1fb0457f078e196c73d11faf2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 1 "D:\DOT NET COre MVC project for learning\HomeDecorProject\HeartyHomeDecor\HeartyHomeDecor\Views\_ViewImports.cshtml"
using HeartyHomeDecor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DOT NET COre MVC project for learning\HomeDecorProject\HeartyHomeDecor\HeartyHomeDecor\Views\_ViewImports.cshtml"
using HeartyHomeDecor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98761ce1d8eaea1fb0457f078e196c73d11faf2d", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"964148f29e6c02ca4adb1e5f9fcb0efc1e7a9902", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <h3>Login</h3>\r\n");
#nullable restore
#line 5 "D:\DOT NET COre MVC project for learning\HomeDecorProject\HeartyHomeDecor\HeartyHomeDecor\Views\Account\Login.cshtml"
             using (Html.BeginForm("Login", "Account", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-group"">
                    <label>UserName</label>
                    <input type=""text"" class=""form-control"" id=""username"" name=""username"" />
                </div>
                <div class=""form-group"">
                    <label>Password</label>
                    <input type=""password"" class=""form-control"" id=""password"" name=""password"" />
                </div>
                <div class=""form-group"">
                    <label></label>
                    <input type=""submit"" class=""btn btn-primary"" value=""Login"" />
                </div>
");
#nullable restore
#line 19 "D:\DOT NET COre MVC project for learning\HomeDecorProject\HeartyHomeDecor\HeartyHomeDecor\Views\Account\Login.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
