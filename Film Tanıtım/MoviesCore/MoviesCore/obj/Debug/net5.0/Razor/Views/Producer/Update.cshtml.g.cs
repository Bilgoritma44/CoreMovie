#pragma checksum "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91eae4533bcc9d13a94ad64852f658327e4efeac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producer_Update), @"mvc.1.0.view", @"/Views/Producer/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91eae4533bcc9d13a94ad64852f658327e4efeac", @"/Views/Producer/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b923b4f26660af4437528caad6dfa1acc868d2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Producer_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Producer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-2\">\r\n");
#nullable restore
#line 9 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml"
         using (Html.BeginForm("Update", "Producer", FormMethod.Post))
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml"
       Write(Html.HiddenFor(x => x.ProducerId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <label><b>Producer Photo</b></label>\r\n");
#nullable restore
#line 15 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml"
       Write(Html.TextBoxFor(x => x.ProducerPhoto, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml"
       Write(Html.ValidationMessageFor(x => x.ProducerPhoto, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <div class=\"form-group text-center\">\r\n                <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 717, "\"", 763, 1);
#nullable restore
#line 19 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml"
WriteAttributeValue("", 723, Html.DisplayTextFor(x=>x.ProducerPhoto), 723, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:150px;height:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 797, "\"", 803, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <br />\r\n            <label><b>Producer Name</b></label>\r\n");
#nullable restore
#line 23 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml"
       Write(Html.TextBoxFor(x => x.ProducerName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml"
       Write(Html.ValidationMessageFor(x => x.ProducerName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <label><b>Producer Bio</b></label>\r\n");
#nullable restore
#line 28 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml"
       Write(Html.TextAreaFor(x => x.ProducerBio, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml"
       Write(Html.ValidationMessageFor(x => x.ProducerBio, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <div class=\"form-group\">\r\n                <button class=\"btn btn-outline-warning float-right\">Update</button>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91eae4533bcc9d13a94ad64852f658327e4efeac7469", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 35 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Producer\Update.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Producer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
