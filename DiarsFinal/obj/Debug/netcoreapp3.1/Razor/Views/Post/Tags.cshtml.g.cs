#pragma checksum "C:\Users\joshu\Downloads\DiarsFinal\DiarsFinal\Views\Post\Tags.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83d98867802c8b97c4f6d3edd6fede90dd4eaa5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Tags), @"mvc.1.0.view", @"/Views/Post/Tags.cshtml")]
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
#line 1 "C:\Users\joshu\Downloads\DiarsFinal\DiarsFinal\Views\_ViewImports.cshtml"
using DiarsFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joshu\Downloads\DiarsFinal\DiarsFinal\Views\_ViewImports.cshtml"
using DiarsFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83d98867802c8b97c4f6d3edd6fede90dd4eaa5d", @"/Views/Post/Tags.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"818bdeb2067aaa6b787dc9c0b7dc3c5fba904915", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Tags : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\joshu\Downloads\DiarsFinal\DiarsFinal\Views\Post\Tags.cshtml"
  
    ViewData["Title"] = "Tags";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Tags</h1>\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\joshu\Downloads\DiarsFinal\DiarsFinal\Views\Post\Tags.cshtml"
 foreach (var item in ViewBag.Tags)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\joshu\Downloads\DiarsFinal\DiarsFinal\Views\Post\Tags.cshtml"
     foreach (var detalle in ViewBag.Detalles)
    {
        if (detalle.IdPost == item.Id)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul>\r\n\r\n                <li style=\"color:dimgray\">");
#nullable restore
#line 18 "C:\Users\joshu\Downloads\DiarsFinal\DiarsFinal\Views\Post\Tags.cshtml"
                                     Write(ViewBag.Tags[detalle.IdTags].Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n             ");
#nullable restore
#line 19 "C:\Users\joshu\Downloads\DiarsFinal\DiarsFinal\Views\Post\Tags.cshtml"
        Write(detalle.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n");
#nullable restore
#line 21 "C:\Users\joshu\Downloads\DiarsFinal\DiarsFinal\Views\Post\Tags.cshtml"

        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\joshu\Downloads\DiarsFinal\DiarsFinal\Views\Post\Tags.cshtml"
     

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
