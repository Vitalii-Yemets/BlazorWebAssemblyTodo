#pragma checksum "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6599dba799f8b356fd50c3ef54efe3c8bb5d582c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebAssemblyTodo.View.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\_Imports.razor"
using BlazorWebAssemblyTodo.View;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\_Imports.razor"
using BlazorWebAssemblyTodo.View.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content px-4");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddContent(7, 
#nullable restore
#line 9 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
