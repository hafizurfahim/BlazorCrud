#pragma checksum "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08b90cd13061ea01ed784f5b146cb1a7882983bd"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Pages.StudentPages.MatBlazorPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blazor\BlazorCrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blazor\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blazor\BlazorCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blazor\BlazorCrud\_Imports.razor"
using BlazorCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blazor\BlazorCrud\_Imports.razor"
using BlazorCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
using BlazorCrud.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
using BdLocation.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/StudentPages/MatBlazorPages/MatPages")]
    public partial class MatPages : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>MatPages</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    ");
            __Blazor.BlazorCrud.Pages.StudentPages.MatBlazorPages.MatPages.TypeInference.CreateMatSelect_0(__builder, 3, 4, "Division Name", 5, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
                                                                          LaodOut

#line default
#line hidden
#nullable disable
            ), 6, 
#nullable restore
#line 9 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
                                                   DivisionId

#line default
#line hidden
#nullable disable
            , 7, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DivisionId = __value, DivisionId)), 8, () => DivisionId, 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n");
#nullable restore
#line 10 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
       foreach(var div in divisions) { 

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "        ");
                __builder2.OpenComponent<MatBlazor.MatOption<int>>(12);
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 11 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
                                        div.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(15, 
#nullable restore
#line 11 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
                                                 div.DivisionName

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n");
#nullable restore
#line 12 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(17, "    ");
            }
            );
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenElement(20, "p");
            __builder.AddMarkupContent(21, "\r\n    ");
            __Blazor.BlazorCrud.Pages.StudentPages.MatBlazorPages.MatPages.TypeInference.CreateMatSelect_1(__builder, 22, 23, "Division Name", 24, 
#nullable restore
#line 17 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
                                                   DistrictId

#line default
#line hidden
#nullable disable
            , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DistrictId = __value, DistrictId)), 26, () => DistrictId, 27, (__builder2) => {
                __builder2.AddMarkupContent(28, "\r\n");
#nullable restore
#line 18 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
         foreach (var district in districts)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(29, "            ");
                __builder2.OpenComponent<MatBlazor.MatOption<int>>(30);
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 20 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
                                            district.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(33, 
#nullable restore
#line 20 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
                                                          district.DistrictName

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n");
#nullable restore
#line 21 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(35, "    ");
            }
            );
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.OpenElement(38, "p");
            __builder.AddMarkupContent(39, "\r\n    ");
            __Blazor.BlazorCrud.Pages.StudentPages.MatBlazorPages.MatPages.TypeInference.CreateMatSelect_2(__builder, 40, 41, "Thana Name", 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
                                                                    ThanaLoad

#line default
#line hidden
#nullable disable
            ), 43, 
#nullable restore
#line 25 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
                                                ThanaId

#line default
#line hidden
#nullable disable
            , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ThanaId = __value, ThanaId)), 45, () => ThanaId, 46, (__builder2) => {
                __builder2.AddMarkupContent(47, "\r\n");
#nullable restore
#line 26 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
         foreach (var thana in thanas)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(48, "            ");
                __builder2.OpenComponent<MatBlazor.MatOption<int>>(49);
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 28 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
                                            thana.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(52, 
#nullable restore
#line 28 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
                                                       thana.ThanaName

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n");
#nullable restore
#line 29 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(54, "    ");
            }
            );
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "E:\Blazor\BlazorCrud\Pages\StudentPages\MatBlazorPages\MatPages.razor"
      

    int DivisionId;
    int ThanaId;
    int DistrictId;
    List<Division> divisions =Location.GetAllDivision();

    List<District> districts = Location.GetAllDistrict();
    List<Thana> thanas = Location.GetAllThana();

    public void LaodOut(ChangeEventArgs e)
    {
        int id = Convert.ToInt32(e.Value.ToString());
        districts = Location.GetAllDistrictByDivisionId(id);

    }
    public void ThanaLoad(ChangeEventArgs e)
    {
        int districtID = Convert.ToInt32(e.Value.ToString());
        thanas = Location.GetAllThanaByDistrictId(districtID);

    }



#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorCrud.Pages.StudentPages.MatBlazorPages.MatPages
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "onchange", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMatSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "onchange", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
