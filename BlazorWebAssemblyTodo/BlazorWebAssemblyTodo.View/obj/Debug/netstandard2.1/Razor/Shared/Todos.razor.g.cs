#pragma checksum "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\Shared\Todos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94dc78141ef3d5e89105baacdbc7a65b579bf49f"
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
#nullable restore
#line 10 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\_Imports.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class Todos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Todos</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\Shared\Todos.razor"
                  OnCreateTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Create new todo");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 7 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\Shared\Todos.razor"
 foreach (var todo in todoService)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "div");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddContent(9, 
#nullable restore
#line 10 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\Shared\Todos.razor"
              todo.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddContent(12, 
#nullable restore
#line 11 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\Shared\Todos.razor"
              todo.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddContent(15, 
#nullable restore
#line 12 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\Shared\Todos.razor"
              todo.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 14 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\Shared\Todos.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, ";\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\projects\webassembly\BlazorWebAssemblyTodo\BlazorWebAssemblyTodo.View\Shared\Todos.razor"
       

    void OnCreateTodo()
    {
        todoService.Add(new TodoItem("First todo", "Do something"));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodoService todoService { get; set; }
    }
}
#pragma warning restore 1591