// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "input");
            builder.AddAttribute(1, "type", "text");
            builder.AddAttribute(2, "data-slider-min", 
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                     Min

#line default
#line hidden
#nullable disable
            );
            builder.SetKey(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                someObject

#line default
#line hidden
#nullable disable
            );
            builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
            
        private object someObject = new object();

        [Parameter] protected int Min { get; set; }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
