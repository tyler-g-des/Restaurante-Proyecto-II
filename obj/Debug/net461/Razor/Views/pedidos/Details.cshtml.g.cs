#pragma checksum "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b3d92925185b3479ae34841802533da153c12cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_pedidos_Details), @"mvc.1.0.view", @"/Views/pedidos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/pedidos/Details.cshtml", typeof(AspNetCore.Views_pedidos_Details))]
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
#line 1 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\_ViewImports.cshtml"
using PrimerParcial;

#line default
#line hidden
#line 2 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\_ViewImports.cshtml"
using PrimerParcial.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3d92925185b3479ae34841802533da153c12cf", @"/Views/pedidos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"531aaafa2fd7595fba3c4c70c34008b9c7fe1c76", @"/Views/_ViewImports.cshtml")]
    public class Views_pedidos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurantee.ViewModel.pedidoView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "idPrecio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "id Compra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "borrarDetalleConfirmacion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "pedidoDetalles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ValidarImprimir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var id = Model.pedido.idPedido;

#line default
#line hidden
            BeginContext(124, 547, true);
            WriteLiteral(@"
<h2>Details</h2>

<div class=""modal fade"" id=""adicionarArticulo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""gridSystemModalLabel"">
<div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
            <h4 class=""modal-title"" id=""gridSystemModalLabel"">Adicionar Artículo</h4>
        </div>
        <div class=""modal-body"">
            ");
            EndContext();
            BeginContext(672, 148, false);
#line 18 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(await Html.PartialAsync("AddArticulos", Model.pedidoDetalle, new ViewDataDictionary(ViewData)
            {
             {"id",id}
            }));

#line default
#line hidden
            EndContext();
            BeginContext(820, 360, true);
            WriteLiteral(@"
        </div>
        <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Cerrar</button>
        </div>
    </div><!-- /.modal-content -->
</div><!-- /.modal-dialog -->
</div><!-- /.modal -->



<div>
    <h4>pedido</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            ");
            EndContext();
            BeginContext(1181, 50, false);
#line 37 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.pedido.persona));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1275, 46, false);
#line 40 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.pedido.persona));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1365, 54, false);
#line 43 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.pedido.fechaPedido));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1463, 50, false);
#line 46 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.pedido.fechaPedido));

#line default
#line hidden
            EndContext();
            BeginContext(1513, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1557, 51, false);
#line 49 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.pedido.subTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1608, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1652, 47, false);
#line 52 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.pedido.subTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1743, 51, false);
#line 55 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.pedido.impuesto));

#line default
#line hidden
            EndContext();
            BeginContext(1794, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1838, 47, false);
#line 58 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.pedido.impuesto));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1929, 48, false);
#line 61 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.pedido.total));

#line default
#line hidden
            EndContext();
            BeginContext(1977, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2021, 44, false);
#line 64 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.pedido.total));

#line default
#line hidden
            EndContext();
            BeginContext(2065, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2109, 56, false);
#line 67 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.pedido.observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(2165, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2209, 52, false);
#line 70 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.pedido.observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(2261, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2305, 47, false);
#line 73 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.pedido.mesa));

#line default
#line hidden
            EndContext();
            BeginContext(2352, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2396, 50, false);
#line 76 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.pedido.mesa.idMesa));

#line default
#line hidden
            EndContext();
            BeginContext(2446, 859, true);
            WriteLiteral(@"
        </dd>
    </dl>
</div>

<div class=""form-group"">
    <!-- modal -->
    <button type=""button"" class=""btn btn-success btn-large"" data-toggle=""modal"" data-target=""#adicionarArticulo"">Adicionar Artículo</button>
</div>

<div class=""x_content"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card-box table-responsive"">
                <table id=""grid"" name=""grid"" class=""table table-striped table-bordered"">
                    <thead>
                        <tr>
                            <th>Codigo</th>
                            <th>Nombre</th>
                            <th>Precio</th>
                            <th>Cantidad</th>
                            <th>Precio Total</th>
                        </tr>
                    </thead>

                    <tbody class=""data"">

");
            EndContext();
#line 103 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                         foreach (var item in Model.pedidos)
                        {

#line default
#line hidden
            BeginContext(3394, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3503, 50, false);
#line 107 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.pedido.idPedido));

#line default
#line hidden
            EndContext();
            BeginContext(3553, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3669, 49, false);
#line 110 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.pedido.persona));

#line default
#line hidden
            EndContext();
            BeginContext(3718, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3834, 41, false);
#line 113 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.precio));

#line default
#line hidden
            EndContext();
            BeginContext(3875, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3991, 43, false);
#line 116 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(4034, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4152, 50, false);
#line 120 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.pedido.subTotal));

#line default
#line hidden
            EndContext();
            BeginContext(4202, 119, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n\r\n                                    ");
            EndContext();
            BeginContext(4321, 640, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1ec79140814dc4920270e5bab47b03", async() => {
                BeginContext(4366, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 126 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                                         using (Html.BeginForm())
                                        {

#line default
#line hidden
                BeginContext(4478, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(4522, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa04a14e3cb04345a31017d092ca074f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#line 128 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                                                                            WriteLiteral(item.pedido.idPedido);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 128 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.pedido.idPedido);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4623, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(4669, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3152d87d7b424a4b9db0ea2595e53e1a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#line 129 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                                                                             WriteLiteral(item.idPedido);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 129 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.pedido.idPedido);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4764, 109, true);
                WriteLiteral("\r\n                                            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n");
                EndContext();
#line 131 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"

                                        }

#line default
#line hidden
                BeginContext(4918, 36, true);
                WriteLiteral("                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4961, 80, true);
            WriteLiteral("\r\n\r\n                                </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 138 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"

                        }

#line default
#line hidden
            BeginContext(5070, 181, true);
            WriteLiteral("                    </tbody>\r\n\r\n                    <tbody class=\"data\">\r\n                        <tr>\r\n                            <td>\r\n                                SubTotal:  ");
            EndContext();
            BeginContext(5252, 51, false);
#line 145 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                                      Write(Html.DisplayFor(modelItem => Model.pedido.subTotal));

#line default
#line hidden
            EndContext();
            BeginContext(5303, 177, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td>\r\n                                Impuesto:  ");
            EndContext();
            BeginContext(5481, 51, false);
#line 151 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                                      Write(Html.DisplayFor(modelItem => Model.pedido.impuesto));

#line default
#line hidden
            EndContext();
            BeginContext(5532, 175, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td>\r\n                                Total:   ");
            EndContext();
            BeginContext(5708, 48, false);
#line 157 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                                    Write(Html.DisplayFor(modelItem => Model.pedido.total));

#line default
#line hidden
            EndContext();
            BeginContext(5756, 201, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n\r\n\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(5957, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd156307db0c4918b2c03b4624323f44", async() => {
                BeginContext(6064, 14, true);
                WriteLiteral("Imprimir Orden");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 172 "C:\Users\tyler.diaz\Desktop\Restaurantee\Views\pedidos\Details.cshtml"
                                                                                              WriteLiteral(id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6082, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(6088, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5f9f4df89c74bc48487a66297e115e2", async() => {
                BeginContext(6134, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6150, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurantee.ViewModel.pedidoView> Html { get; private set; }
    }
}
#pragma warning restore 1591