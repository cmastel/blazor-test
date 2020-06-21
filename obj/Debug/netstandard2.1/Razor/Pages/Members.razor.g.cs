#pragma checksum "/Users/chris/development/ClCalc/Pages/Members.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0697679407e41ef38b553be23c9cec80eecf3387"
// <auto-generated/>
#pragma warning disable 1591
namespace ClCalc.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/chris/development/ClCalc/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chris/development/ClCalc/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chris/development/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chris/development/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chris/development/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chris/development/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chris/development/ClCalc/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chris/development/ClCalc/_Imports.razor"
using ClCalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/chris/development/ClCalc/_Imports.razor"
using ClCalc.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/members")]
    public partial class Members : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Member Registry</h1>\n\n");
#nullable restore
#line 6 "/Users/chris/development/ClCalc/Pages/Members.razor"
 if (members == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading....</em></p>\n");
#nullable restore
#line 9 "/Users/chris/development/ClCalc/Pages/Members.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Date of Birth</th>\r\n                <th>Role</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 22 "/Users/chris/development/ClCalc/Pages/Members.razor"
             foreach (var member in members)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 25 "/Users/chris/development/ClCalc/Pages/Members.razor"
                         member.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, ", ");
            __builder.AddContent(16, 
#nullable restore
#line 25 "/Users/chris/development/ClCalc/Pages/Members.razor"
                                           member.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 26 "/Users/chris/development/ClCalc/Pages/Members.razor"
                         member.dob

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 27 "/Users/chris/development/ClCalc/Pages/Members.razor"
                         member.role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 28 "/Users/chris/development/ClCalc/Pages/Members.razor"
                         member.group

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 30 "/Users/chris/development/ClCalc/Pages/Members.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
#nullable restore
#line 33 "/Users/chris/development/ClCalc/Pages/Members.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "/Users/chris/development/ClCalc/Pages/Members.razor"
       
    private Member[] members;

    protected override async Task OnInitializedAsync()
    {
        members = await Http.GetFromJsonAsync<Member[]>("sample-data/members.json");
    }

    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dob { get; set; }
        public string role { get; set; }
        public string group { get; set; }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
