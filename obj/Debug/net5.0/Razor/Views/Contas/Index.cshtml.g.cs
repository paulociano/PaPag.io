#pragma checksum "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fe3a84423444595c4c89927f7ea51e09456a314"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contas_Index), @"mvc.1.0.view", @"/Views/Contas/Index.cshtml")]
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
#line 1 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\_ViewImports.cshtml"
using papagio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\_ViewImports.cshtml"
using papagio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe3a84423444595c4c89927f7ea51e09456a314", @"/Views/Contas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"137254c63bac5e9ef4729a12552b6f43d4d264e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Contas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<papagio.Models.Conta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-novaConta"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Detalhes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Remover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml"
  
    ViewData["Title"] = "Contas";
    Layout = "~/Views/Shared/_LayoutLogged.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"headConta\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe3a84423444595c4c89927f7ea51e09456a3146538", async() => {
                WriteLiteral("Nova Conta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <table>
        <thead>
            <tr>
                <th scope=""col"">
                    <label>Categoria</label><div class=""th-pesquisar""><i class=""bi bi-search""></i><input id=""pesquisaCategoria"" type=""search"" placeholder=""Pesquisar...""/></div>
                </th>
                <th>
                    <label>Despesa</label><div class=""th-pesquisar""><i class=""bi bi-search""><input id=""pesquisaDespesa"" type=""search"" placeholder=""Pesquisar..."" /></i></div>
                </th>
                <th>
                    <label>Data</label><div class=""th-pesquisar""><i class=""bi bi-search""><input id=""pesquisaData"" type=""search"" placeholder=""Pesquisar..."" /></i></div>
                </th>
                <th>
                    <label>Valor</label><div class=""th-pesquisar""><i class=""bi bi-search""><input id=""pesquisaValor"" type=""search"" placeholder=""Pesquisar..."" /></i></div>
                </th>
            </tr>
        </thead>
    </table>
</div>
   

<div id=""listaContas"" c");
            WriteLiteral("lass=\"listaContas flex-container\">\r\n");
#nullable restore
#line 32 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"cardConta\">\r\n            <div class=\"conteudoConta\">\r\n\r\n                <div class=\"contaHeader\">\r\n                    <span id=\"categoriaDespesaConta\"");
            BeginWriteAttribute("class", " class=", 1498, "", 1571, 1);
#nullable restore
#line 38 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml"
WriteAttributeValue("", 1505, Html.DisplayFor(model => item.Despesa.CategoriaDespesa.Descricao), 1505, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml"
                                                                                                                         Write(Html.DisplayFor(model => item.Despesa.CategoriaDespesa.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <hr />\r\n                    <div id=\"despesaConta\"><h4>");
#nullable restore
#line 40 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml"
                                          Write(Html.DisplayFor(model => item.Despesa.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n                    <div id=\"valorConta\">R$");
#nullable restore
#line 41 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml"
                                      Write(Html.DisplayFor(model => item.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <hr />\r\n                </div>\r\n\r\n                <div class=\"contaBody\">\r\n                    <div class=\"botoesConta\">\r\n                        <ul>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe3a84423444595c4c89927f7ea51e09456a31411103", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe3a84423444595c4c89927f7ea51e09456a31413423", async() => {
                WriteLiteral("<i class=\"bi bi-receipt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe3a84423444595c4c89927f7ea51e09456a31415740", async() => {
                WriteLiteral("<i class=\"bi bi-x-circle-fill\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n                <div class=\"contaFooter\">\r\n                    <div id=\"dateConta\" class=\"dateConta\">");
#nullable restore
#line 55 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml"
                                                     Write(Html.DisplayFor(model => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    \r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 61 "C:\Users\WIN10\Desktop\P2 - PROGRAMAÇÃO PARA WEB\papagio\Views\Contas\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fe3a84423444595c4c89927f7ea51e09456a31418837", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    /*Tornar Link da Página Atual Ativo*/
    document.getElementById('contas').className += ' menu-active';

    /*Filtro por Categoria*/
    $('#pesquisaCategoria').keyup(function (e) {
        var termo = $('#pesquisaCategoria').val().toUpperCase();
        $('#listaContas .cardConta #categoriaDespesaConta').each(function () {
            if ($(this).html().toUpperCase().indexOf(termo) === -1) {
                $(this).parent().parent().parent().hide();
            } else {
                $(this).parent().parent().parent().show();
            }
        });
    });

    /*Filtro por Despesa*/
    $('#pesquisaDespesa').keyup(function (e) {
        var termo = $('#pesquisaDespesa').val().toUpperCase();
        $('#listaContas .cardConta #despesaConta').each(function () {
            if ($(this).html().toUpperCase().indexOf(termo) === -1) {
                $(this).parent().parent().parent().hide();
            } else {
                $(this).parent().parent().parent().show()");
            WriteLiteral(@";
            }
        });
    });

    /*Filtro por Valor*/
    $('#pesquisaValor').keyup(function (e) {
        var termo = $('#pesquisaValor').val().toUpperCase();
        $('#listaContas .cardConta #valorConta').each(function () {
            if ($(this).html().toUpperCase().indexOf(termo) === -1) {
                $(this).parent().parent().parent().hide();
            } else {
                $(this).parent().parent().parent().show();
            }
        });
    });

    /*Filtro por Data*/
    $('#pesquisaData').keyup(function (e) {
        var termo = $('#pesquisaData').val().toUpperCase();
        $('#listaContas .cardConta #dateConta').each(function () {
            if ($(this).html().toUpperCase().indexOf(termo) === -1) {
                $(this).parent().parent().parent().hide();
            } else {
                $(this).parent().parent().parent().show();
            }
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<papagio.Models.Conta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
