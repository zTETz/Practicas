#pragma checksum "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee02679b1d57fc392ed00c119279d99218bcf199"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Index), @"mvc.1.0.view", @"/Views/Clientes/Index.cshtml")]
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
#line 1 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\_ViewImports.cshtml"
using MVC_02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\_ViewImports.cshtml"
using MVC_02.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee02679b1d57fc392ed00c119279d99218bcf199", @"/Views/Clientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eddbf465f1b669bafd3a799aab94d54bc5f552a", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
  
    ViewData["Title"] = "Tarea Alex";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"card-header\">\r\n        <h1>Listado de Clientes</h1>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n \r\n<div class=\"row mt-3\">\r\n");
#nullable restore
#line 19 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 24 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 25 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.NombreCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 26 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 27 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.DireccionExacta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 28 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 29 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n");
#nullable restore
#line 34 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
             foreach (var i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"m-3\">\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(i.NombreCliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(i.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(i.DireccionExacta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(i.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
                   Write(i.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </table>\r\n");
#nullable restore
#line 50 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No existen datos para mostrar</p>\r\n");
#nullable restore
#line 54 "C:\Users\alequ\Downloads\Tarea_MVC\MVC_02_Solucion\MVC_02\Views\Clientes\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
