#pragma checksum "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48a9b059107e41c9d8777d5ed176ec737e71cb78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BeverageGet), @"mvc.1.0.view", @"/Views/Admin/BeverageGet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a9b059107e41c9d8777d5ed176ec737e71cb78", @"/Views/Admin/BeverageGet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e336dcb36f7f390778fb3b0ecebbe76fa099ddb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_BeverageGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E_Commence.Models.Data.Beverage>
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
#line 2 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
  
    ViewData["Title"] = "UpdateBeverage";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48a9b059107e41c9d8777d5ed176ec737e71cb784080", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
Write(Html.BeginForm("UpdateBeverage", "Admin", FormMethod.Post));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
Write(Html.Label("Beverage Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
Write(Html.TextBoxFor(x => x.BeverageId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
Write(Html.Label("Food Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
Write(Html.TextBoxFor(x => x.BeverageName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
Write(Html.Label("Food Price"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
Write(Html.TextBoxFor(x => x.BeveragePrice, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
Write(Html.Label("Food Photo Link"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
Write(Html.TextBoxFor(x => x.BeveragePhotoLink, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
Write(Html.Label("Alchol?"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\dbrepeat\E-Commence\Views\Admin\BeverageGet.cshtml"
Write(Html.TextBoxFor(x => x.Alcohol, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<button type=\"submit\" class=\"btn btn-success\">Update</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Commence.Models.Data.Beverage> Html { get; private set; }
    }
}
#pragma warning restore 1591
