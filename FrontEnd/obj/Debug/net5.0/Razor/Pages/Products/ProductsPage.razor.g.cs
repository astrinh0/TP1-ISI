#pragma checksum "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2111f8ae94edb598c72a6f298d0590c4dfae67e"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontEnd.Pages.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class ProductsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudContainer>(0);
            __builder.AddAttribute(1, "Class", "mt-16");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(3);
                __builder2.AddAttribute(4, "Justify", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Justify>(
#nullable restore
#line 4 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                      Justify.FlexEnd

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudBadge>(6);
                    __builder3.AddAttribute(7, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                           numberOfProductsInCart

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                            showCartBadge

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 5 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                                                  Color.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudFab>(12);
                        __builder4.AddAttribute(13, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                           Icons.Material.Filled.ShoppingCart

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 6 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                                     Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudText>(16);
                __builder2.AddAttribute(17, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 9 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                   Typo.h3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 9 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                   Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(21, "Tipo de Produto");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudText>(23);
                __builder2.AddAttribute(24, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 10 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                    Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(26, "Some long pricing text should go here maybe? who knows what text you would want here, i guess i cant fill it in for you.");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(28);
                __builder2.AddAttribute(29, "Class", "mt-8");
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 13 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
         foreach (var product in listOfProducts)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudItem>(31);
                    __builder3.AddAttribute(32, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                 6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                        4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCard>(36);
                        __builder4.AddAttribute(37, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                    25

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "Class", "rounded-lg pb-4");
                        __builder4.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudCardHeader>(40);
                            __builder5.AddAttribute(41, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudText>(42);
                                __builder6.AddAttribute(43, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 19 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                           Typo.h5

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(44, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 19 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                           Align.Center

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(46, "Beginner");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(47, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(48);
                            __builder5.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(50, "div");
                                __builder6.AddAttribute(51, "class", "d-flex justify-center");
                                __builder6.OpenComponent<MudBlazor.MudText>(52);
                                __builder6.AddAttribute(53, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 24 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                           Typo.h3

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(55, "$5");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(56, "\r\n                            ");
                                __builder6.OpenComponent<MudBlazor.MudText>(57);
                                __builder6.AddAttribute(58, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 25 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                           Typo.h5

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(59, "Class", "ml-1 mt-5");
                                __builder6.AddAttribute(60, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                                             Color.Secondary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(62, "/Monthly");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(63, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudList>(64);
                                __builder6.AddAttribute(65, "Class", "mx-auto mt-4");
                                __builder6.AddAttribute(66, "Style", "width:300px;");
                                __builder6.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudListItem>(68);
                                    __builder7.AddAttribute(69, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                Icons.Material.Filled.LiveHelp

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(71, "\r\n                                Unlimited something\r\n                            ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(72, "\r\n                            ");
                                    __builder7.OpenComponent<MudBlazor.MudListItem>(73);
                                    __builder7.AddAttribute(74, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                Icons.Material.Filled.LiveHelp

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(76, "\r\n                                10 something\r\n                            ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(77, "\r\n                            ");
                                    __builder7.OpenComponent<MudBlazor.MudListItem>(78);
                                    __builder7.AddAttribute(79, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                Icons.Material.Filled.LiveHelp

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(81, "\r\n                                No something\r\n                            ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(82, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudCardActions>(83);
                            __builder5.AddAttribute(84, "Class", "d-flex justify-center");
                            __builder5.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudGrid>(86);
                                __builder6.AddAttribute(87, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                          3

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(88, "Justify", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Justify>(
#nullable restore
#line 40 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                      Justify.Center

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudItem>(90);
                                    __builder7.AddAttribute(91, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                         12

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(92, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                 6

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(93, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                        4

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __Blazor.FrontEnd.Pages.Products.ProductsPage.TypeInference.CreateMudNumericField_0(__builder8, 95, 96, 
#nullable restore
#line 42 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                                                 Variant.Text

#line default
#line hidden
#nullable disable
                                        , 97, 
#nullable restore
#line 42 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                                                                    0

#line default
#line hidden
#nullable disable
                                        , 98, 
#nullable restore
#line 42 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                              quantity

#line default
#line hidden
#nullable disable
                                        , 99, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => quantity = __value, quantity)));
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(100, "\r\n                            ");
                                    __builder7.OpenComponent<MudBlazor.MudItem>(101);
                                    __builder7.AddAttribute(102, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 44 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                         12

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(103, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 44 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                 6

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(104, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 44 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                        4

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(105, "Style", "align-self: flex-end;");
                                    __builder7.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<MudBlazor.MudButton>(107);
                                        __builder8.AddAttribute(108, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                       Icons.Material.Filled.AddShoppingCart

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(109, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 45 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                                                                     Color.Inherit

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(110, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 45 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                                                                                          Size.Medium

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(111, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
                                                                                                                                                AddToCart

#line default
#line hidden
#nullable disable
                                        )));
                                        __builder8.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(113, "Add");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 51 "D:\Escola\ISI\FrontEnd\Pages\Products\ProductsPage.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
namespace __Blazor.FrontEnd.Pages.Products.ProductsPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudNumericField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, T __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudNumericField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Min", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
