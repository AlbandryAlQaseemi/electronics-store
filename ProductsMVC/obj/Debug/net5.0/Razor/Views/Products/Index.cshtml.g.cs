#pragma checksum "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f269df90d7326dc9521afb2def60003643ceca5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\_ViewImports.cshtml"
using ProductsMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\_ViewImports.cshtml"
using ProductsMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f269df90d7326dc9521afb2def60003643ceca5b", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88ac3449f45faf1fc75884d7c881a399eeaf46aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" background-color: oldlace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Products</h1>\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\Products\Index.cshtml"
  
    var IList = (List<Product>)ViewData["IList"];
    var color = ViewData["color"];



#line default
#line hidden
#nullable disable
            WriteLiteral("<style type=\"text/css\">\r\n    .grey {\r\n        background-color: grey;\r\n    }\r\n\r\n    .moccasin {\r\n        background-color: moccasin;\r\n    }\r\n\r\n    .lavender {\r\n        background-color: lavender;\r\n    }\r\n\r\n   \r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f269df90d7326dc9521afb2def60003643ceca5b4015", async() => {
                WriteLiteral("\r\n    <div><b>Table Products</b><br /></div>\r\n    <table class=\" table\"");
                BeginWriteAttribute("style", " style=\"", 454, "\"", 485, 2);
                WriteAttributeValue("", 462, "background-color:", 462, 17, true);
#nullable restore
#line 27 "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 479, color, 479, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
        <thead class=""thead-dark "">
            <tr>
                <th scope=""col"">Product Id </th>
                <th scope=""col"">Product Name </th>
                <th scope=""col"">Product Price </th>
                <th scope=""col"">Product Image</th>
                <th scope=""col"">Show</th>

            </tr>
        </thead>
");
#nullable restore
#line 38 "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\Products\Index.cshtml"
         foreach (var product in IList)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr  class=\"alert-dark\" >\r\n                <td> ");
#nullable restore
#line 42 "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\Products\Index.cshtml"
                Write(product.id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\Products\Index.cshtml"
               Write(product.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\Products\Index.cshtml"
               Write(product.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td><img");
                BeginWriteAttribute("src", " src=\"", 1071, "\"", 1091, 1);
#nullable restore
#line 45 "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 1077, product.image, 1077, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1092, "\"", 1098, 0);
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                <td><button class=\"btn btn-secondary\"><a");
                BeginWriteAttribute("href", " href=\"", 1165, "\"", 1201, 2);
                WriteAttributeValue("", 1172, "/Products/Details/", 1172, 18, true);
#nullable restore
#line 46 "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 1190, product.id, 1190, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"color:whitesmoke\">Show</button></td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Alban\source\repos\ProductsMVC\ProductsMVC\Views\Products\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </table>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
