#pragma checksum "C:\Users\alena\source\repos\Module35\AwesomeNetwork\Views\AccountManager\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a14080ca26026f04717171baf45475b0831da3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManager_UserList), @"mvc.1.0.view", @"/Views/AccountManager/UserList.cshtml")]
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
#line 1 "C:\Users\alena\source\repos\Module35\AwesomeNetwork\Views\_ViewImports.cshtml"
using AwesomeNetwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alena\source\repos\Module35\AwesomeNetwork\Views\_ViewImports.cshtml"
using AwesomeNetwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a14080ca26026f04717171baf45475b0831da3d", @"/Views/AccountManager/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c48efb0771131872a114818af4b8ac385d11b68d", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManager_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AwesomeNetwork.ViewModels.Account.SearchViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"block-reg background-white\">\r\n");
#nullable restore
#line 5 "C:\Users\alena\source\repos\Module35\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
     foreach (var user in @Model.UserList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <label>");
#nullable restore
#line 8 "C:\Users\alena\source\repos\Module35\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
              Write(user.GetFullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 10 "C:\Users\alena\source\repos\Module35\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AwesomeNetwork.ViewModels.Account.SearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591