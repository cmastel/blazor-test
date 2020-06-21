#pragma checksum "/Users/chris/development/ClCalc/Pages/CompoundInterest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0be27bab49c4293edfe40bb25c6080b67586cc0f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/compoundinterest")]
    public partial class CompoundInterest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "compound-interest-container");
            __builder.AddMarkupContent(2, "\n  ");
            __builder.AddMarkupContent(3, "<h1>Compound Interest</h1>\n\n  ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\n      ");
            __builder.AddMarkupContent(9, "<th>Initial Principal</th>\n      ");
            __builder.OpenElement(10, "th");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "/Users/chris/development/ClCalc/Pages/CompoundInterest.razor"
                        Principal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Principal = __value, Principal));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n    ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\n      ");
            __builder.AddMarkupContent(18, "<th>Years</th>\n      ");
            __builder.OpenElement(19, "th");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "/Users/chris/development/ClCalc/Pages/CompoundInterest.razor"
                        Years

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Years = __value, Years));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n    ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\n      ");
            __builder.AddMarkupContent(27, "<th>Annual Interest Rate (%)</th>\n      ");
            __builder.OpenElement(28, "th");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "/Users/chris/development/ClCalc/Pages/CompoundInterest.razor"
                        InterestRate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InterestRate = __value, InterestRate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n    ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "\n      ");
            __builder.AddMarkupContent(36, "<th>Total:</th>\n      ");
            __builder.OpenElement(37, "th");
            __builder.AddContent(38, 
#nullable restore
#line 21 "/Users/chris/development/ClCalc/Pages/CompoundInterest.razor"
           Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n  ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/chris/development/ClCalc/Pages/CompoundInterest.razor"
                                            Calculate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Calculate");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/Users/chris/development/ClCalc/Pages/CompoundInterest.razor"
 
  private double Principal { get; set; } = 5000;
  private double InterestRate { get; set; } = 5;
  private int Years { get; set; } = 10;
  private double total { get; set; } = 0;
  private string Total { get; set; }

  private void Calculate()
  {
    var total = Principal * Math.Pow(1 + InterestRate / (1200.0), Years * 12);
    Total = total.ToString("C");
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591