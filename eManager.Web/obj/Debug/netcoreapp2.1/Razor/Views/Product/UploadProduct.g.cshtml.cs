#pragma checksum "C:\Users\User\source\repos\eManager\eManager\Views\Product\UploadProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1b088e4ec8faf70e5658fea095d2a3c5119a21a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_UploadProduct), @"mvc.1.0.view", @"/Views/Product/UploadProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/UploadProduct.cshtml", typeof(AspNetCore.Views_Product_UploadProduct))]
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
#line 2 "C:\Users\User\source\repos\eManager\eManager\Views\Product\UploadProduct.cshtml"
using eManager.WebModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b088e4ec8faf70e5658fea095d2a3c5119a21a", @"/Views/Product/UploadProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bce773a2e7a4e5c04545815629efd019da2764", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_UploadProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("upload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\User\source\repos\eManager\eManager\Views\Product\UploadProduct.cshtml"
  
    ViewBag.Title = "Adding product";
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(130, 300, true);
            WriteLiteral(@"

<div class=""modal fade"" id=""addProductModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">

                <h4 class=""modal-title"">Product details</h4>
            </div>
            <div class=""modal-body"">

                ");
            EndContext();
            BeginContext(430, 1362, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0ffb67584c642038f3d955f77a5a016", async() => {
                BeginContext(544, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(569, 33, false);
#line 23 "C:\Users\User\source\repos\eManager\eManager\Views\Product\UploadProduct.cshtml"
               Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(602, 75, true);
                WriteLiteral("\r\n                    <label for=\"Name\">Name:</label>\r\n                    ");
                EndContext();
                BeginContext(678, 59, false);
#line 25 "C:\Users\User\source\repos\eManager\eManager\Views\Product\UploadProduct.cshtml"
               Write(Html.TextBox("Name", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(737, 87, true);
                WriteLiteral("<br />\r\n\r\n\r\n                    <label for=\"Price\">Price:</label>\r\n                    ");
                EndContext();
                BeginContext(825, 60, false);
#line 29 "C:\Users\User\source\repos\eManager\eManager\Views\Product\UploadProduct.cshtml"
               Write(Html.TextBox("Price", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(885, 100, true);
                WriteLiteral("<br />\r\n\r\n\r\n                    <label for=\"Company\">Company (Vendor):</label>\r\n                    ");
                EndContext();
                BeginContext(986, 83, false);
#line 33 "C:\Users\User\source\repos\eManager\eManager\Views\Product\UploadProduct.cshtml"
               Write(Html.DropDownListFor(c => c.SelectedCompanyId, Model.Vendors, "--Select company--"));

#line default
#line hidden
                EndContext();
                BeginContext(1069, 500, true);
                WriteLiteral(@"
                    <br />


                    <div class=""form-group"">
                        <div class=""col-md-10"">
                            <p>Upload Image File (.png, .jpg):</p>
                            <input id=""ImageUrl"" name=""ImageUrl"" type=""hidden"" />
                            <input id=""uploadImage"" type=""file"" name=""ImageUrl"" />
                        </div>
                    </div>
                    <div class=""form-group"">
                        <span>");
                EndContext();
                BeginContext(1570, 15, false);
#line 45 "C:\Users\User\source\repos\eManager\eManager\Views\Product\UploadProduct.cshtml"
                         Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(1585, 106, true);
                WriteLiteral("</span>\r\n\r\n                    </div>\r\n\r\n                    <button class=\"btn btn-success\" role=\"button\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1691, "\"", 1751, 3);
                WriteAttributeValue("", 1701, "location.href=\'", 1701, 15, true);
#line 49 "C:\Users\User\source\repos\eManager\eManager\Views\Product\UploadProduct.cshtml"
WriteAttributeValue("", 1716, Url.Action("Products", "Product"), 1716, 34, false);

#line default
#line hidden
                WriteAttributeValue("", 1750, "\'", 1750, 1, true);
                EndWriteAttribute();
                BeginContext(1752, 33, true);
                WriteLiteral(">Add</button>\r\n\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1792, 150, true);
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-primary\" data-dismiss=\"modal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1942, "\"", 2002, 3);
            WriteAttributeValue("", 1952, "location.href=\'", 1952, 15, true);
#line 57 "C:\Users\User\source\repos\eManager\eManager\Views\Product\UploadProduct.cshtml"
WriteAttributeValue("", 1967, Url.Action("Products", "Product"), 1967, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 2001, "\'", 2001, 1, true);
            EndWriteAttribute();
            BeginContext(2003, 1145, true);
            WriteLiteral(@">Close</button>
            </div>
        </div>
    </div>
</div>



<script>


    $(function () {
        $(""#addProductModal"").modal();
    });



    $('#upload').submit(function (e) {
        e.preventDefault();

        $.ajax({
            url: this.action,
            type: this.method,
            data: new FormData(this),
            cache: false,
            contentType: false,
            processData: false,
            success: function (data) {
                console.log(data.UploadedFileCount + ' file(s) uploaded successfully');
                $(""#ImageUrl"").show();

            },
            error: function (xhr, error, status) {
                console.log(error, status);
            }
        });
    });


    $('#addProductModal').change(function (e) {
        e.preventDefault();
        var element = this;
        var formInfo = new FormData();
        var totalFiles = element.files.length;

        for (i = 0; i < totalFiles; i++) {
     ");
            WriteLiteral("       var file = element.files[i];\r\n            formInfo.append(\"ImageUrl\", file);\r\n        }\r\n    })\r\n    \r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
