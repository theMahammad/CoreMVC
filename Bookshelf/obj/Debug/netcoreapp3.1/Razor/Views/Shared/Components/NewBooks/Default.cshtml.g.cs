#pragma checksum "C:\Users\hssjx\source\repos\CoreLesson\Bookshelf\Views\Shared\Components\NewBooks\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60c5d60dc947e4e7b986261d6a9fc05808ffb296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NewBooks_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NewBooks/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60c5d60dc947e4e7b986261d6a9fc05808ffb296", @"/Views/Shared/Components/NewBooks/Default.cshtml")]
    public class Views_Shared_Components_NewBooks_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Bookshelf.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hssjx\source\repos\CoreLesson\Bookshelf\Views\Shared\Components\NewBooks\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\hssjx\source\repos\CoreLesson\Bookshelf\Views\Shared\Components\NewBooks\Default.cshtml"
 foreach (var book in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n\r\n    <td>");
#nullable restore
#line 10 "C:\Users\hssjx\source\repos\CoreLesson\Bookshelf\Views\Shared\Components\NewBooks\Default.cshtml"
   Write(book.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 11 "C:\Users\hssjx\source\repos\CoreLesson\Bookshelf\Views\Shared\Components\NewBooks\Default.cshtml"
   Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 12 "C:\Users\hssjx\source\repos\CoreLesson\Bookshelf\Views\Shared\Components\NewBooks\Default.cshtml"
   Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 13 "C:\Users\hssjx\source\repos\CoreLesson\Bookshelf\Views\Shared\Components\NewBooks\Default.cshtml"
   Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 15 "C:\Users\hssjx\source\repos\CoreLesson\Bookshelf\Views\Shared\Components\NewBooks\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Bookshelf.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591