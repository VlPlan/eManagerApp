#pragma checksum "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14fe58bf15a74c88fbcbc31a515580d31b72ce80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeInfo), @"mvc.1.0.view", @"/Views/Employee/EmployeeInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/EmployeeInfo.cshtml", typeof(AspNetCore.Views_Employee_EmployeeInfo))]
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
#line 2 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
using eManager.WebModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14fe58bf15a74c88fbcbc31a515580d31b72ce80", @"/Views/Employee/EmployeeInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bce773a2e7a4e5c04545815629efd019da2764", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowEmployees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Employee Informations";



#line default
#line hidden
            BeginContext(140, 29, true);
            WriteLiteral("<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(169, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2448d196f8e416cac6f873aef44ab33", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 12 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 170, true);
            WriteLiteral("\r\n    <h2>Employee informations:</h2>\r\n\r\n    <br />\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <h4>Employee details: <span style=\"color:blue\">");
            EndContext();
            BeginContext(376, 15, false);
#line 19 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
                                                      Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(391, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(393, 14, false);
#line 19 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
                                                                       Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(407, 175, true);
            WriteLiteral("</span></h4>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <b>Company ID:</b>\r\n        </div>\r\n        <div class=\"col-md-3\">");
            EndContext();
            BeginContext(583, 44, false);
#line 26 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
                         Write(Html.DisplayFor(item => item.EmployeeNumber));

#line default
#line hidden
            EndContext();
            BeginContext(627, 147, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <b>Name:</b>\r\n        </div>\r\n        <div class=\"col-md-3\">");
            EndContext();
            BeginContext(775, 39, false);
#line 32 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
                         Write(Html.DisplayFor(item => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(814, 150, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <b>Surname:</b>\r\n        </div>\r\n        <div class=\"col-md-3\">");
            EndContext();
            BeginContext(965, 38, false);
#line 38 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
                         Write(Html.DisplayFor(item => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 153, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <b>Department:</b>\r\n        </div>\r\n        <div class=\"col-md-3\">");
            EndContext();
            BeginContext(1157, 40, false);
#line 44 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
                         Write(Html.DisplayFor(item => item.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 152, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <b>Birthdate:</b>\r\n        </div>\r\n        <div class=\"col-md-3\">");
            EndContext();
            BeginContext(1350, 41, false);
#line 50 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
                         Write(Html.DisplayFor(item => item.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 148, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <b>Phone:</b>\r\n        </div>\r\n        <div class=\"col-md-3\">");
            EndContext();
            BeginContext(1540, 35, false);
#line 56 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
                         Write(Html.DisplayFor(item => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 149, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <b>Salary:</b>\r\n        </div>\r\n        <div class=\"col-md-3\">");
            EndContext();
            BeginContext(1725, 36, false);
#line 62 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
                         Write(Html.DisplayFor(item => item.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 119, true);
            WriteLiteral("</div>\r\n    </div>\r\n    <br />\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <b>Documents for ");
            EndContext();
            BeginContext(1881, 15, false);
#line 68 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
                        Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1896, 165, true);
            WriteLiteral(":</b>\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"card-body\">\r\n                    <p>ID card:</p>\r\n                    <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 2061, "", 2113, 1);
#line 74 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
WriteAttributeValue("", 2066, Url.Content("~/UploadedFiles/" + Model.IdCard), 2066, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2113, 198, true);
            WriteLiteral(" style=\"width: 16rem; height: 16rem;\" />\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p>M1M2 work permit:</p>\r\n                    <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 2311, "", 2361, 1);
#line 78 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
WriteAttributeValue("", 2316, Url.Content("~/UploadedFiles/" + Model.M1M2), 2316, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2361, 203, true);
            WriteLiteral(" style=\"width: 16rem; height: 16rem;\" />\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p>Medical documentation:</p>\r\n                    <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 2564, "", 2617, 1);
#line 82 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
WriteAttributeValue("", 2569, Url.Content("~/UploadedFiles/" + Model.Medical), 2569, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2617, 209, true);
            WriteLiteral(" style=\"width: 16rem; height: 16rem;\" />\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p>Health&Safety documentation:</p>\r\n                    <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 2826, "", 2879, 1);
#line 86 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\EmployeeInfo.cshtml"
WriteAttributeValue("", 2831, Url.Content("~/UploadedFiles/" + Model.HSafety), 2831, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2879, 151, true);
            WriteLiteral(" style=\"width: 16rem; height: 16rem;\" />\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <br />\r\n    <p>\r\n\r\n        ");
            EndContext();
            BeginContext(3030, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969b44ec6d6049ebab3a98928f25f4c7", async() => {
                BeginContext(3110, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3118, 4959, true);
            WriteLiteral(@"

    </p>
    </div>


    <script>

        $(function () {
            $(""#addDocumentsEmployee"").modal();
        });


        $(""#uploadImage"").change(function (e) {
            e.preventDefault();
            var element = this;
            var formInfo = new FormData();
            var totalFiles = element.files.length;

            for (i = 0; i < totalFiles; i++) {
                var file = element.files[i];
              
                formInfo.append(""IdCard"", file);
              
                
            }

            $.ajax({
                type: ""POST"",
                url: ""/Employee/UploadDocuments"",
                data: formInfo,
                dataType: ""json"",
                contentType: false,
                processData: false,
                success: function (response) {

                    console.log(response);
                    if (response) {

                        alert(""Success"");


                    }
              ");
            WriteLiteral(@"  },
                error: function () {
                    console.log(""Error"");
                }
            });
        });

        $(""#uploadMedicalDoc"").change(function (e) {
            e.preventDefault();
            var element = this;
            var formInfo = new FormData();
            var totalFiles = element.files.length;

            for (i = 0; i < totalFiles; i++) {
                
                var file = element.files[i];
      
                formInfo.append(""Medical"", file);
            }

            $.ajax({
                type: ""POST"",
                url: ""/Employee/UploadDocuments"",
                data: formInfo,
                dataType: ""json"",
                contentType: false,
                processData: false,
                success: function (response) {

                    console.log(response);
                    if (response) {

                        alert(""Success"");


                    }
                },
           ");
            WriteLiteral(@"     error: function () {
                    console.log(""Error"");
                }
            });
        });


        $(""#uploadM1M2"").change(function (e) {
            e.preventDefault();
            var element = this;
            var formInfo = new FormData();
            var totalFiles = element.files.length;

            for (i = 0; i < totalFiles; i++) {

                var file = element.files[i];

                formInfo.append(""M1M2"", file);
            }

            $.ajax({
                type: ""POST"",
                url: ""/Employee/UploadDocuments"",
                data: formInfo,
                dataType: ""json"",
                contentType: false,
                processData: false,
                success: function (response) {

                    console.log(response);
                    if (response) {

                        alert(""Success"");


                    }
                },
                error: function () {
                   ");
            WriteLiteral(@" console.log(""Error"");
                }
            });
        });


        $(""#uploadHS"").change(function (e) {
            e.preventDefault();
            var element = this;
            var formInfo = new FormData();
            var totalFiles = element.files.length;

            for (i = 0; i < totalFiles; i++) {

                var file = element.files[i];

                formInfo.append(""HSafety"", file);
            }

            $.ajax({
                type: ""POST"",
                url: ""/Employee/UploadDocuments"",
                data: formInfo,
                dataType: ""json"",
                contentType: false,
                processData: false,
                success: function (response) {

                    console.log(response);
                    if (response) {

                        alert(""Success"");


                    }
                },
                error: function () {
                    console.log(""Error"");
                }
  ");
            WriteLiteral(@"          });
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
                    $(""#IdCard"").show();
                    $(""#Medical"").show();
                    $(""#M1M2"").show();
                    $(""#HSafety"").show();
                },
                error: function (xhr, error, status) {
                    console.log(error, status);
                }
            });
        });

        
 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
