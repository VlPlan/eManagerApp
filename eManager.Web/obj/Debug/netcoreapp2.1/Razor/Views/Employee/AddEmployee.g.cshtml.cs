#pragma checksum "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29455ca28d90c537c74d8d07a36c3c26827152a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_AddEmployee), @"mvc.1.0.view", @"/Views/Employee/AddEmployee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/AddEmployee.cshtml", typeof(AspNetCore.Views_Employee_AddEmployee))]
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
#line 1 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
using eManager.WebModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29455ca28d90c537c74d8d07a36c3c26827152a8", @"/Views/Employee/AddEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bce773a2e7a4e5c04545815629efd019da2764", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_AddEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Adding new employee";


#line default
#line hidden
            BeginContext(135, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
 using (Html.BeginForm())
{




#line default
#line hidden
            BeginContext(175, 133, true);
            WriteLiteral("<div class=\"container\">\r\n    <fieldset class=\"col-md-12\">\r\n        <legend><strong>Employee Registry Form</strong></legend>\r\n        ");
            EndContext();
            BeginContext(308, 3503, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b08ec62888824237a5c9c36a95837479", async() => {
                BeginContext(379, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(394, 25, false);
#line 20 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
       Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
                EndContext();
                BeginContext(419, 185, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"input-group-prepend\">\r\n                        <span class=\"input-group-text\">");
                EndContext();
                BeginContext(605, 36, false);
#line 25 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
                                                  Write(Html.LabelFor(x => x.EmployeeNumber));

#line default
#line hidden
                EndContext();
                BeginContext(641, 57, true);
                WriteLiteral("</span>\r\n                    </div>\r\n                    ");
                EndContext();
                BeginContext(699, 69, false);
#line 27 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
               Write(Html.TextBox("EmployeeNumber", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(768, 180, true);
                WriteLiteral("\r\n                </div>\r\n\r\n\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"input-group-prepend\">\r\n                        <span class=\"input-group-text\">");
                EndContext();
                BeginContext(949, 31, false);
#line 33 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
                                                  Write(Html.LabelFor(x => x.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(980, 57, true);
                WriteLiteral("</span>\r\n                    </div>\r\n                    ");
                EndContext();
                BeginContext(1038, 64, false);
#line 35 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
               Write(Html.TextBox("FirstName", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1102, 178, true);
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"input-group-prepend\">\r\n                        <span class=\"input-group-text\">");
                EndContext();
                BeginContext(1281, 30, false);
#line 40 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
                                                  Write(Html.LabelFor(x => x.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1311, 57, true);
                WriteLiteral("</span>\r\n                    </div>\r\n                    ");
                EndContext();
                BeginContext(1369, 63, false);
#line 42 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
               Write(Html.TextBox("LastName", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1432, 231, true);
                WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"input-group-prepend\">\r\n                        <span class=\"input-group-text\">");
                EndContext();
                BeginContext(1664, 29, false);
#line 50 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
                                                  Write(Html.LabelFor(x => x.Address));

#line default
#line hidden
                EndContext();
                BeginContext(1693, 57, true);
                WriteLiteral("</span>\r\n                    </div>\r\n                    ");
                EndContext();
                BeginContext(1751, 62, false);
#line 52 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
               Write(Html.TextBox("Address", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1813, 200, true);
                WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"input-group-prepend\">\r\n                        <span class=\"input-group-text\">");
                EndContext();
                BeginContext(2014, 27, false);
#line 57 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
                                                  Write(Html.LabelFor(x => x.Phone));

#line default
#line hidden
                EndContext();
                BeginContext(2041, 57, true);
                WriteLiteral("</span>\r\n                    </div>\r\n                    ");
                EndContext();
                BeginContext(2099, 61, false);
#line 59 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
               Write(Html.TextBox($"Phone", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2160, 200, true);
                WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"input-group-prepend\">\r\n                        <span class=\"input-group-text\">");
                EndContext();
                BeginContext(2361, 32, false);
#line 64 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
                                                  Write(Html.LabelFor(x => x.Department));

#line default
#line hidden
                EndContext();
                BeginContext(2393, 57, true);
                WriteLiteral("</span>\r\n                    </div>\r\n                    ");
                EndContext();
                BeginContext(2451, 91, false);
#line 66 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
               Write(Html.DropDownListFor(x => x.Department, Html.GetEnumSelectList(Model.Department.GetType())));

#line default
#line hidden
                EndContext();
                BeginContext(2542, 200, true);
                WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"input-group-prepend\">\r\n                        <span class=\"input-group-text\">");
                EndContext();
                BeginContext(2743, 100, false);
#line 71 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
                                                  Write(Html.LabelFor(model => model.DateOfBirth, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(2843, 57, true);
                WriteLiteral("</span>\r\n                    </div>\r\n                    ");
                EndContext();
                BeginContext(2901, 149, false);
#line 73 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
               Write(Html.EditorFor(model => model.DateOfBirth, new { htmlAttributes = new { @class = "form-control",  @Value = DateTime.Today.ToString("dd/MM/yyyy") } }));

#line default
#line hidden
                EndContext();
                BeginContext(3050, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3073, 89, false);
#line 74 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
               Write(Html.ValidationMessageFor(model => model.DateOfBirth, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3162, 200, true);
                WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"input-group-prepend\">\r\n                        <span class=\"input-group-text\">");
                EndContext();
                BeginContext(3363, 28, false);
#line 79 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
                                                  Write(Html.LabelFor(x => x.Salary));

#line default
#line hidden
                EndContext();
                BeginContext(3391, 60, true);
                WriteLiteral("</span>\r\n                    </div>\r\n                    <p>");
                EndContext();
                BeginContext(3452, 62, false);
#line 81 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
                  Write(Html.TextBox($"Salary", null, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(3514, 290, true);
                WriteLiteral(@"</p>
                </div>

           
            <div class=""col-md-6"">
                <div class=""col-md-offset-4 col-md-10"">
                    <input type=""submit"" value=""Create"" class=""btn btn-success"" />
                </div>
            </div>
        </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3811, 29, true);
            WriteLiteral("\r\n    </fieldset>\r\n\r\n</div>\r\n");
            EndContext();
#line 95 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
}

#line default
#line hidden
            BeginContext(3843, 98, true);
            WriteLiteral("<br />\r\n<br />\r\n<hr />\r\n\r\n    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3941, "\"", 4007, 3);
            WriteAttributeValue("", 3951, "location.href=\'", 3951, 15, true);
#line 100 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\AddEmployee.cshtml"
WriteAttributeValue("", 3966, Url.Action("ShowEmployees", "Employee"), 3966, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 4006, "\'", 4006, 1, true);
            EndWriteAttribute();
            BeginContext(4008, 724, true);
            WriteLiteral(@">Back</button>
<script>
    let employees = document.getElementsByClassName(""catalog"")[0];
    console.log(employees);
    employees.addEventListener(""click"", function (e) {
        e.stopPropagation();
        let target = e.target;


        let targetId = target.classList.contains(""employeeCard"") ? target.value : null;
        console.log(targetId);

        if (targetId != null) {
            fetch(""/Employee/AddEmployeesToActivity?employeeId="" + targetId, {
                method: ""post"",

            })


        }


    })


    $('.employeeCard').click(function () {
        setTimeout(function () {

            $(""#msg"").show().fadeOut(3000);
        }, 400)
    })

</script>");
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
