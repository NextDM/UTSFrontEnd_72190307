#pragma checksum "E:\Semester 5\Pemrograman Frontend\Program\UTS\Pages\DepartmentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0392c2908a9555f322bc7012ccb598408271abc"
// <auto-generated/>
#pragma warning disable 1591
namespace UTS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Semester 5\Pemrograman Frontend\Program\UTS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Semester 5\Pemrograman Frontend\Program\UTS\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Semester 5\Pemrograman Frontend\Program\UTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Semester 5\Pemrograman Frontend\Program\UTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Semester 5\Pemrograman Frontend\Program\UTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Semester 5\Pemrograman Frontend\Program\UTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Semester 5\Pemrograman Frontend\Program\UTS\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Semester 5\Pemrograman Frontend\Program\UTS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Semester 5\Pemrograman Frontend\Program\UTS\_Imports.razor"
using UTS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Semester 5\Pemrograman Frontend\Program\UTS\_Imports.razor"
using UTS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/departmentpage")]
    public partial class DepartmentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Daftar Department</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "<thead><tr><th>Department ID</th>\r\n            <th>Department Name</th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 14 "E:\Semester 5\Pemrograman Frontend\Program\UTS\Pages\DepartmentPage.razor"
         foreach (var dept in Departments)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 17 "E:\Semester 5\Pemrograman Frontend\Program\UTS\Pages\DepartmentPage.razor"
                     dept.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 18 "E:\Semester 5\Pemrograman Frontend\Program\UTS\Pages\DepartmentPage.razor"
                     dept.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", 
#nullable restore
#line 19 "E:\Semester 5\Pemrograman Frontend\Program\UTS\Pages\DepartmentPage.razor"
                               $"departmentdetail/{dept.DepartmentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddContent(16, "Detail");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "E:\Semester 5\Pemrograman Frontend\Program\UTS\Pages\DepartmentPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
