#pragma checksum "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bcb48766f4264e395c9eae0a68d2f740f4b2c83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_PickEmployees), @"mvc.1.0.view", @"/Views/Employee/PickEmployees.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/PickEmployees.cshtml", typeof(AspNetCore.Views_Employee_PickEmployees))]
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
#line 1 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
using eManager.WebModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bcb48766f4264e395c9eae0a68d2f740f4b2c83", @"/Views/Employee/PickEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bce773a2e7a4e5c04545815629efd019da2764", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_PickEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActivityViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/worker.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-left w3-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Pick Employees";


#line default
#line hidden
            BeginContext(131, 39, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"container\">\r\n\r\n    ");
            EndContext();
            BeginContext(171, 41, false);
#line 16 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
Write(Html.HiddenFor(model => model.ActivityId));

#line default
#line hidden
            EndContext();
            BeginContext(212, 58, true);
            WriteLiteral("\r\n\r\n    <label for=\"Description\">Description</label>\r\n    ");
            EndContext();
            BeginContext(271, 17, false);
#line 19 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(288, 79, true);
            WriteLiteral("<br />\r\n    <label for=\"Duration\">Total working hours (duration):</label>\r\n    ");
            EndContext();
            BeginContext(368, 14, false);
#line 21 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
Write(Model.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(382, 82, true);
            WriteLiteral("<br />\r\n\r\n    <div>\r\n        <label for=\"Date\">Date of activity:</label>\r\n        ");
            EndContext();
            BeginContext(465, 10, false);
#line 25 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
   Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(475, 92, true);
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n\r\n    <div>\r\n        <label for=\"Client\">Client:</label>\r\n        ");
            EndContext();
            BeginContext(568, 17, false);
#line 31 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
   Write(Model.Client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(585, 67, true);
            WriteLiteral("<br />\r\n    </div>\r\n\r\n\r\n    <br />\r\n    <p>Available employees for ");
            EndContext();
            BeginContext(653, 17, false);
#line 36 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
                          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(670, 181, true);
            WriteLiteral("</p>\r\n    <br />\r\n    <div class=\"row pickedCatalog col-md-12\" id=\"employeesCatalog\">\r\n\r\n        <div id=\"msgRemove\" class=\"alert-danger\" style=\"display:none\">Employee removed from ");
            EndContext();
            BeginContext(852, 17, false);
#line 40 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
                                                                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(869, 123, true);
            WriteLiteral("!</div>\r\n        <div class=\"pickedForActivity\">\r\n            <p>Current employees on activity are:</p>\r\n            <ul>\r\n");
            EndContext();
#line 44 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
                 foreach (var a in Model.EmployeeActivities)
                {

#line default
#line hidden
            BeginContext(1073, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1098, 11, false);
#line 46 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
                   Write(a.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1109, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1111, 10, false);
#line 46 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
                                Write(a.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1121, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 47 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
                }

#line default
#line hidden
            BeginContext(1147, 434, true);
            WriteLiteral(@"            </ul>
            <hr />
        </div>
    </div>
    <br />
    <div class=""container"" id=""employees"">

        <div id=""msg"" class=""alert-success"" style=""display:none"">Employee Added!</div>

        <h6>Pick employees for activity</h6>
        <hr />
        <div id=""msg"" class=""alert-success"" style=""display:none"">Employee Added!</div>
        <div class=""row col-md-12 catalog"" id=""employeesCatalog"">

");
            EndContext();
#line 62 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
             foreach (var i in Model.AllEmployees)
            {
                
                    

#line default
#line hidden
            BeginContext(1758, 169, true);
            WriteLiteral("                        <div class=\"w3-card-4 col-md-3\">\r\n\r\n                            <header class=\"w3-container w3-light-grey\">\r\n                                <h3>");
            EndContext();
            BeginContext(1928, 11, false);
#line 70 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
                               Write(i.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1939, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1941, 10, false);
#line 70 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
                                            Write(i.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1951, 141, true);
            WriteLiteral("</h3>\r\n                            </header>\r\n\r\n                            <div class=\"w3-container\">\r\n                                <p># ");
            EndContext();
            BeginContext(2093, 16, false);
#line 74 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
                                Write(i.EmployeeNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2109, 76, true);
            WriteLiteral("</p>\r\n                                <hr>\r\n                                ");
            EndContext();
            BeginContext(2185, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8d9b4a12c3ee4209a236a8d365c6a4ab", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2278, 37, true);
            WriteLiteral("\r\n                                <p>");
            EndContext();
            BeginContext(2316, 13, false);
#line 77 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
                              Write(i.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(2329, 109, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div>\r\n                                ");
            EndContext();
            BeginContext(2438, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a25b076cec7473cbec8123de71072a3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 80 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => i.Id);

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
            BeginContext(2470, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2504, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "373baba9cb444ff89fed99b29193a162", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 81 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ActivityId);

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
            BeginContext(2548, 36, true);
            WriteLiteral("\r\n                                <a");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2584, "\"", 2597, 1);
#line 82 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
WriteAttributeValue("", 2592, i.Id, 2592, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2598, "\"", 2677, 4);
            WriteAttributeValue("", 2605, "../AddEmployeesToActivity/?employeeId=", 2605, 38, true);
#line 82 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
WriteAttributeValue("", 2643, i.Id, 2643, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2648, "&activityId=", 2648, 12, true);
#line 82 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
WriteAttributeValue("", 2660, Model.ActivityId, 2660, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2678, 151, true);
            WriteLiteral(" class=\"w3-button w3-block w3-dark-grey employeeCard\" role=\"button\">+Pick</a>\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n");
            EndContext();
#line 87 "C:\Users\User\source\repos\eManager\eManager\Views\Employee\PickEmployees.cshtml"
                         


                }

#line default
#line hidden
            BeginContext(2879, 1228, true);
            WriteLiteral(@"




            </div>
    </div>
</div>
        <script>
            $(function () {
                $(""#updateActivityModal"").modal();
            });




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


            $('");
            WriteLiteral(".removeEmployee\').click(function () {\r\n                setTimeout(function () {\r\n\r\n                    $(\"#msgRemove\").show().fadeOut(3000);\r\n                }, 400)\r\n            })\r\n        </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivityViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
