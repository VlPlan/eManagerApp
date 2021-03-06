#pragma checksum "C:\Users\User\source\repos\eManager\eManager\Views\Company\CompanyInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19bf442af25b3966157146ba27341a177028fc30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_CompanyInfo), @"mvc.1.0.view", @"/Views/Company/CompanyInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/CompanyInfo.cshtml", typeof(AspNetCore.Views_Company_CompanyInfo))]
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
#line 1 "C:\Users\User\source\repos\eManager\eManager\Views\_ViewImports.cshtml"
using eManager;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\eManager\eManager\Views\_ViewImports.cshtml"
using eManager.Models;

#line default
#line hidden
#line 1 "C:\Users\User\source\repos\eManager\eManager\Views\Company\CompanyInfo.cshtml"
using eManager.WebModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19bf442af25b3966157146ba27341a177028fc30", @"/Views/Company/CompanyInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bce773a2e7a4e5c04545815629efd019da2764", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_CompanyInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCompanyInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCompany", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("removeBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\User\source\repos\eManager\eManager\Views\Company\CompanyInfo.cshtml"
  
    ViewBag.Title = "Company info";


#line default
#line hidden
            BeginContext(101, 320, true);
            WriteLiteral(@"
<div class=""container"" id=""listCompanyProducts"">
    <h2>Company products information</h2>

    
    <table class=""table"">
        <thead>
            <tr>
                <th>#</th>
                <th>Product name</th>
                <th>Price</th>

            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 23 "C:\Users\User\source\repos\eManager\eManager\Views\Company\CompanyInfo.cshtml"
             foreach (var product in Model.CompanyProducts)
            {

#line default
#line hidden
            BeginContext(497, 48, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(546, 10, false);
#line 27 "C:\Users\User\source\repos\eManager\eManager\Views\Company\CompanyInfo.cshtml"
                   Write(product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(556, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(588, 12, false);
#line 28 "C:\Users\User\source\repos\eManager\eManager\Views\Company\CompanyInfo.cshtml"
                   Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(600, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(632, 13, false);
#line 29 "C:\Users\User\source\repos\eManager\eManager\Views\Company\CompanyInfo.cshtml"
                   Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(645, 59, true);
            WriteLiteral("</td>\r\n                    <td>\r\n\r\n                        ");
            EndContext();
            BeginContext(704, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f9a414e36b4d74ab5c333539012bca", async() => {
                BeginContext(827, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\Users\User\source\repos\eManager\eManager\Views\Company\CompanyInfo.cshtml"
                                                                                     WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(835, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(863, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84536ca87df642a5a3293d4aa70f0ad9", async() => {
                BeginContext(983, 6, true);
                WriteLiteral("Remove");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\User\source\repos\eManager\eManager\Views\Company\CompanyInfo.cshtml"
                                                                                 WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(993, 56, true);
            WriteLiteral("\r\n\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 38 "C:\Users\User\source\repos\eManager\eManager\Views\Company\CompanyInfo.cshtml"
            }

#line default
#line hidden
            BeginContext(1064, 118, true);
            WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1182, "\"", 1247, 3);
            WriteAttributeValue("", 1192, "location.href=\'", 1192, 15, true);
#line 47 "C:\Users\User\source\repos\eManager\eManager\Views\Company\CompanyInfo.cshtml"
WriteAttributeValue("", 1207, Url.Action("ShowCompanies", "Company"), 1207, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 1246, "\'", 1246, 1, true);
            EndWriteAttribute();
            BeginContext(1248, 571, true);
            WriteLiteral(@">Back</button>
<div id=""modalWrapper"">

</div>


<script>

   //$(function () {
   //     $(""#editModal"").modal();
   // });



   // $(function () {
   //     $(""#editModal"").modal();
   // });

   // function editEmployeeInfo(employeeId) {
   //     $.ajax({
   //         url: ""/Company//"" + employeeId,
   //         data: {
   //             Id: $(this).attr('data-id')
   //         },

   //         success: function (emp) {
   //             $(""#modalWrap"").html(emp);
   //         }
   //     });
   // }






</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
