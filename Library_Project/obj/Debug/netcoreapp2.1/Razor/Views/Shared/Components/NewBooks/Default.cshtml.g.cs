#pragma checksum "C:\Users\zlhbs\Desktop\Library_Project\Library_Project\Views\Shared\Components\NewBooks\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d9ca425a9d34b2126e218fcf94fde1b53579de1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NewBooks_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NewBooks/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/NewBooks/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_NewBooks_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d9ca425a9d34b2126e218fcf94fde1b53579de1", @"/Views/Shared/Components/NewBooks/Default.cshtml")]
    public class Views_Shared_Components_NewBooks_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library_Project.Models.Books>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(170, 135, true);
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Book Name</th>\r\n        <th>Author</th>\r\n    </tr>\r\n");
            EndContext();
#line 11 "C:\Users\zlhbs\Desktop\Library_Project\Library_Project\Views\Shared\Components\NewBooks\Default.cshtml"
     foreach(var b in Model)
    {

#line default
#line hidden
            BeginContext(342, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(373, 4, false);
#line 14 "C:\Users\zlhbs\Desktop\Library_Project\Library_Project\Views\Shared\Components\NewBooks\Default.cshtml"
           Write(b.ID);

#line default
#line hidden
            EndContext();
            BeginContext(377, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(401, 10, false);
#line 15 "C:\Users\zlhbs\Desktop\Library_Project\Library_Project\Views\Shared\Components\NewBooks\Default.cshtml"
           Write(b.BookName);

#line default
#line hidden
            EndContext();
            BeginContext(411, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(435, 8, false);
#line 16 "C:\Users\zlhbs\Desktop\Library_Project\Library_Project\Views\Shared\Components\NewBooks\Default.cshtml"
           Write(b.Author);

#line default
#line hidden
            EndContext();
            BeginContext(443, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 18 "C:\Users\zlhbs\Desktop\Library_Project\Library_Project\Views\Shared\Components\NewBooks\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(472, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library_Project.Models.Books>> Html { get; private set; }
    }
}
#pragma warning restore 1591
