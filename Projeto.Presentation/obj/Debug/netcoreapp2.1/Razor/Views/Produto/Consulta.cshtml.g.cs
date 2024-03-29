#pragma checksum "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e1002059f70ea62c9cc5127d2165f11205e682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Consulta), @"mvc.1.0.view", @"/Views/Produto/Consulta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Consulta.cshtml", typeof(AspNetCore.Views_Produto_Consulta))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e1002059f70ea62c9cc5127d2165f11205e682", @"/Views/Produto/Consulta.cshtml")]
    public class Views_Produto_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projeto.Presentation.Models.ProdutoConsultaModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
  
    ViewData["Title"] = "Consulta";
    Layout = "~/Views/Templates/Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 62, true);
            WriteLiteral("\r\n<h4>Consulta de Produtos</h4>\r\n<hr />\r\n\r\n<div>\r\n    <strong>");
            EndContext();
            BeginContext(220, 20, false);
#line 11 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
       Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(240, 417, true);
            WriteLiteral(@"</strong>
</div>

<table class=""table table-bordered table-striped table-hover"">
    <thead>
        <tr>
            <td>Código</td>
            <td>Nome do Produto</td>
            <td width=""120"">Preço</td>
            <td>Quantidade</td>
            <td width=""120"">Total</td>
            <td>Data de Cadastro</td>
            <td width=""160"">Operações</td>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(706, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(737, 14, false);
#line 30 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.IdProduto);

#line default
#line hidden
            EndContext();
            BeginContext(751, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(775, 9, false);
#line 31 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(784, 35, true);
            WriteLiteral("</td>            \r\n            <td>");
            EndContext();
            BeginContext(820, 24, false);
#line 32 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Preco.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(844, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(868, 15, false);
#line 33 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(883, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(907, 24, false);
#line 34 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Total.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(931, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(955, 40, false);
#line 35 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(995, 43, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1038, "\"", 1076, 2);
            WriteAttributeValue("", 1045, "/Produto/Edicao/", 1045, 16, true);
#line 37 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
WriteAttributeValue("", 1061, item.IdProduto, 1061, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1077, 105, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">\r\n                    Atualizar\r\n                </a>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1182, "\"", 1222, 2);
            WriteAttributeValue("", 1189, "/Produto/Exclusao/", 1189, 18, true);
#line 40 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
WriteAttributeValue("", 1207, item.IdProduto, 1207, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1223, 118, true);
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\r\n                    Excluir\r\n                </a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
        }

#line default
#line hidden
            BeginContext(1352, 94, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"7\">Quantidade de registros: ");
            EndContext();
            BeginContext(1447, 11, false);
#line 49 "C:\Users\Coti-Maq15\Desktop\Aula23\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
                                                Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1458, 44, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projeto.Presentation.Models.ProdutoConsultaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
