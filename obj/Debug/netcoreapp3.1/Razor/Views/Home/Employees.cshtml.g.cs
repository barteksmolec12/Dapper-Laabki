#pragma checksum "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d48e042ee53062ece7769681a828f2bf91607450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employees), @"mvc.1.0.view", @"/Views/Home/Employees.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\_ViewImports.cshtml"
using AppSqlReadOnly.Lab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\_ViewImports.cshtml"
using AppSqlReadOnly.Lab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d48e042ee53062ece7769681a828f2bf91607450", @"/Views/Home/Employees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd7caca48e2aaed4af76850499b7b3b011c7dd85", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Employees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppSqlReadOnly.Lab.Dal.EmployeeDao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
  
    ViewData["Title"] = "Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Employees</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 45 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 46 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Dell\Desktop\Zadanie LAB\AppSqlReadOnly.Lab\Views\Home\Employees.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppSqlReadOnly.Lab.Dal.EmployeeDao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
