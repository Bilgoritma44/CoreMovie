#pragma checksum "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ff5a118ad94fcc2c7c8253fa9ad9e2bbd8524bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Update2), @"mvc.1.0.view", @"/Views/User/Update2.cshtml")]
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
#line 1 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\_ViewImports.cshtml"
using MoviesCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\_ViewImports.cshtml"
using MoviesCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff5a118ad94fcc2c7c8253fa9ad9e2bbd8524bc", @"/Views/User/Update2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b923b4f26660af4437528caad6dfa1acc868d2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Update2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.ApplicationUser>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
  
    ViewData["Title"] = "Update2";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-2\">\r\n");
#nullable restore
#line 9 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
         using (Html.BeginForm("Update2", "User", FormMethod.Post))
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.HiddenFor(x => x.UserId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <label><b>First Name</b></label>\r\n");
#nullable restore
#line 15 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.TextBoxFor(x => x.FirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.ValidationMessageFor(x => x.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br /><label><b>Last Name</b></label>\r\n");
#nullable restore
#line 18 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.TextBoxFor(x => x.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.ValidationMessageFor(x => x.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br /><label><b>User Name</b></label>\r\n");
#nullable restore
#line 21 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.TextBoxFor(x => x.UserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.ValidationMessageFor(x => x.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br /><label><b>E-mail</b></label>\r\n");
#nullable restore
#line 24 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.ValidationMessageFor(x => x.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br /><label><b>Password</b></label>\r\n");
#nullable restore
#line 27 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.TextBoxFor(x => x.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.ValidationMessageFor(x => x.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br /><label><b>User Role</b></label>\r\n");
#nullable restore
#line 30 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
       Write(Html.TextBoxFor(x => x.UserRole, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <div class=\"form-group\">\r\n                <button class=\"btn btn-outline-warning float-right\">Update</button>\r\n                <a class=\"btn btn-outline-secondary\" href=\"/User/Index\">Cancel</a>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\User\Update2.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.ApplicationUser> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
