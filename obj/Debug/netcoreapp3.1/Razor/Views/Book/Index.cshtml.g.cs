#pragma checksum "C:\data\codes\.netcore\mvc\poc\samplemvcapps\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "831075ec987762e8aaf80a628ab77abc5021e6d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "C:\data\codes\.netcore\mvc\poc\samplemvcapps\Views\_ViewImports.cshtml"
using SampleMVCApps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\data\codes\.netcore\mvc\poc\samplemvcapps\Views\_ViewImports.cshtml"
using SampleMVCApps.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"831075ec987762e8aaf80a628ab77abc5021e6d5", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77134c9016bc8690ac7a329d0bbb70b4283f65", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\data\codes\.netcore\mvc\poc\samplemvcapps\Views\Book\Index.cshtml"
    
    ViewData["Title"]="Index";  

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n<h2>Index</h2>  \r\n<hr>  \r\n  \r\n<p>");
#nullable restore
#line 8 "C:\data\codes\.netcore\mvc\poc\samplemvcapps\Views\Book\Index.cshtml"
Write(ViewData["Welcome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>  ");
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
