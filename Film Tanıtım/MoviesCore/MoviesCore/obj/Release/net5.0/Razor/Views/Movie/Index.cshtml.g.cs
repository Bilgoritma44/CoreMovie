#pragma checksum "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7cf1a8279934da07868c51fb1b0adf2b6bcbcd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7cf1a8279934da07868c51fb1b0adf2b6bcbcd4", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b923b4f26660af4437528caad6dfa1acc868d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css\">\r\n");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-4 col-xs-6 border-primary mb-3"">
            <div class=""card mb-3"" style=""max-width:540px;"">
                <div class=""row g-0"">
                    <div class=""col-md-12"">
                        <div class=""card-header text-white bg-danger"">
                            <p class=""card-text"">
                                <h5 class=""card-title"">
                                    ");
#nullable restore
#line 21 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
                               Write(x.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
                                     if (User.Identity.IsAuthenticated && ViewBag.v2 == "Admin")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"text-white float-right\"");
            BeginWriteAttribute("href", " href=\"", 1084, "\"", 1115, 2);
            WriteAttributeValue("", 1091, "/Movie/Delete/", 1091, 14, true);
#nullable restore
#line 24 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 1105, x.MovieId, 1105, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-pencil-square\"></i></a>\r\n");
#nullable restore
#line 25 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
                                        
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h5>\r\n\r\n                            </p>\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1452, "\"", 1474, 1);
#nullable restore
#line 36 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 1458, x.MovieImageUrl, 1458, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 1488, "\"", 1506, 1);
#nullable restore
#line 36 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 1494, x.MovieName, 1494, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">");
#nullable restore
#line 41 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
                                            Write(x.MovieDescription.Substring(0, x.MovieDescription.Substring(0, 20).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n                            <p class=\"card-text\"><b>Cinema: </b>");
#nullable restore
#line 42 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
                                                           Write(x.Cinema.CinemaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Category: </b>");
#nullable restore
#line 43 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
                                                             Write(x.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Date: </b>");
#nullable restore
#line 44 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
                                                          Write(((DateTime)x.MovieCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Status:</b><span class=\"badge bg-success text-white\">");
#nullable restore
#line 45 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
                                                                                                    Write(x.MovieStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>

                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <div class=""card-footer"">
                            <p class=""card-text"">
                                <a class=""btn btn-outline-primary float-right""");
            BeginWriteAttribute("href", " href=\"", 2508, "\"", 2539, 2);
            WriteAttributeValue("", 2515, "/Movie/Detail/", 2515, 14, true);
#nullable restore
#line 52 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
WriteAttributeValue("", 2529, x.MovieId, 2529, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"bi bi-eye-fill\"></i>Show Details\r\n                                </a>\r\n                                \r\n                            </p>\r\n");
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 69 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
     if (User.Identity.IsAuthenticated && ViewBag.v2 == "Admin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"position: fixed; right: 25px; bottom: 25px;\" class=\"text-white\">\r\n            <a href=\"/Movie/Add\" class=\"btn btn-success\">\r\n                <i class=\"bi bi-plus-circle\"></i> Add New\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 78 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n  ");
#nullable restore
#line 80 "C:\Users\Erkan Çalışkan\source\repos\MoviesCore\MoviesCore\Views\Movie\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index",new {page})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
