#pragma checksum "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\ListEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7e154f9e68f024107c41a4617fc1a424514d3d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ListEmployee), @"mvc.1.0.view", @"/Views/Employee/ListEmployee.cshtml")]
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
#line 1 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\_ViewImports.cshtml"
using Northwind.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\_ViewImports.cshtml"
using Northwind.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e154f9e68f024107c41a4617fc1a424514d3d0", @"/Views/Employee/ListEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dad76091869ede8adbd28e701c0fcdceb8678800", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_ListEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h3>\r\n        List of Employee\r\n    </h3>\r\n");
            WriteLiteral("\r\n  <table class=\"table\">\r\n  <thead>\r\n            <tr>\r\n              <th scope=\"col\">#</th>\r\n              <th scope=\"col\">FullName</th>\r\n              <th scope=\"col\">Birth Date</th>\r\n            </tr>\r\n  </thead>\r\n      <tbody>\r\n");
#nullable restore
#line 28 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\ListEmployee.cshtml"
             foreach (var item in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 31 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\ListEmployee.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\ListEmployee.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\ListEmployee.cshtml"
                   Write(item.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\ListEmployee.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\r\n  </table>\r\n\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591