#pragma checksum "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\User\ProductByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71c45e38fde5af4fd46a551b36db2074c5642593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ProductByCategory), @"mvc.1.0.view", @"/Views/User/ProductByCategory.cshtml")]
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
#line 1 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\_ViewImports.cshtml"
using WebApplication6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\_ViewImports.cshtml"
using WebApplication6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c45e38fde5af4fd46a551b36db2074c5642593", @"/Views/User/ProductByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"865b2ca0dedbd6d16882aa8f14a3148527d098b0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_ProductByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication6.Models.Entity.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mPurpose-master/img/product1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Item Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\User\ProductByCategory.cshtml"
  
    ViewData["Title"] = "ProductByCategory";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""section section-breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                 <a href=""/User/Index""><h1>??R??NLER</h1> </a>  
            </div>
        </div>
    </div>
</div>
<div class=""section"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 20 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\User\ProductByCategory.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-4\">\r\n                    <div class=\"shop-item\">\r\n                        <div class=\"image\">\r\n                            <a href=\"page-product-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71c45e38fde5af4fd46a551b36db2074c56425935087", async() => {
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
            WriteLiteral("</a>\r\n                        </div>\r\n                        <div class=\"title\">\r\n                            <h3><a href=\"page-product-details.html\">");
#nullable restore
#line 29 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\User\ProductByCategory.cshtml"
                                                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                        </div>
                        <div class=""colors"">
                            <span class=""color-white""></span>
                            <span class=""color-black""></span>
                            <span class=""color-blue""></span>
                            <span class=""color-orange""></span>
                            <span class=""color-green""></span>
                        </div>
                        <!-- Product Price-->
                        <div class=""price"">
                            <p> $");
#nullable restore
#line 40 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\User\ProductByCategory.cshtml"
                            Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <!-- Product Description-->\r\n                        <div class=\"description\">\r\n                            <p>");
#nullable restore
#line 44 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\User\ProductByCategory.cshtml"
                          Write(item.ProductDescripton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <!-- Add to Cart Button -->\r\n                        <div class=\"actions\">\r\n");
#nullable restore
#line 48 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\User\ProductByCategory.cshtml"
                             if(@item.ProductQuantity>0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2021, "\"", 2059, 3);
            WriteAttributeValue("", 2028, "/User/AddOrder/", 2028, 15, true);
#nullable restore
#line 50 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\User\ProductByCategory.cshtml"
WriteAttributeValue("", 2043, item.ProductId, 2043, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2058, "/", 2058, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\"><i class=\"icon-shopping-cart icon-white\"></i> Sat??n Al</a>\r\n");
#nullable restore
#line 51 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\User\ProductByCategory.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <a href=\"#\"><i class=\"icon-shopping-cart icon-white\"></i> Stokta Yok</a>\r\n");
#nullable restore
#line 55 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\User\ProductByCategory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                           \r\n                        </div>\r\n                    </div>\r\n                    <!-- End Product -->\r\n                </div>\r\n");
#nullable restore
#line 61 "C:\Users\aggun\source\repos\WebApplication6\WebApplication6\Views\User\ProductByCategory.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication6.Models.Entity.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
