#pragma checksum "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "062374c3104a31d4bc42a94e8af0470218926033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BeverageIndex), @"mvc.1.0.view", @"/Views/Admin/BeverageIndex.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\_ViewImports.cshtml"
using E_Commence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\_ViewImports.cshtml"
using E_Commence.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"062374c3104a31d4bc42a94e8af0470218926033", @"/Views/Admin/BeverageIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e336dcb36f7f390778fb3b0ecebbe76fa099ddb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_BeverageIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<E_Commence.Models.Data.Beverage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageIndex.cshtml"
  
    ViewData["Title"] = "BeverageIndex";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "062374c3104a31d4bc42a94e8af04702189260334097", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""table table-bordered"">
    <tr>
        <td>BeverageId</td>
        <td>Beverage Price</td>
        <td>Beverage Price</td>
        <td>Alchol?</td>
        <td>Delete</td>
        <td>Update</td>
        <td>Beverage Photo</td>
    </tr>
");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageIndex.cshtml"
     foreach (var x in Model)
    {

    

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageIndex.cshtml"
   Write(x.BeverageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageIndex.cshtml"
   Write(x.BeverageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageIndex.cshtml"
   Write(x.BeveragePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageIndex.cshtml"
   Write(x.Alcohol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 659, "\"", 701, 2);
            WriteAttributeValue("", 666, "/Admin/DeleteBeverage/", 666, 22, true);
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageIndex.cshtml"
WriteAttributeValue("", 688, x.BeverageId, 688, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 748, "\"", 787, 2);
            WriteAttributeValue("", 755, "/Admin/BeverageGet/", 755, 19, true);
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageIndex.cshtml"
WriteAttributeValue("", 774, x.BeverageId, 774, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageIndex.cshtml"
   Write(x.BeveragePhotoLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 30 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<E_Commence.Models.Data.Beverage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
