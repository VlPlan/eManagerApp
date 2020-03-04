#pragma checksum "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\PickServices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e47ae74108d0873a9b69414e7556441d300c914"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_PickServices), @"mvc.1.0.view", @"/Views/Invoice/PickServices.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/PickServices.cshtml", typeof(AspNetCore.Views_Invoice_PickServices))]
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
#line 2 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\PickServices.cshtml"
using eManager.WebModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e47ae74108d0873a9b69414e7556441d300c914", @"/Views/Invoice/PickServices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bce773a2e7a4e5c04545815629efd019da2764", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_PickServices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ServiceViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\PickServices.cshtml"
  
    ViewBag.Title = "Pick services for invoice";
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(147, 686, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""pickServices"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            
                <div class=""modal-body"" style=""height:600px;overflow-y:scroll"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Service</th>
                                <th>Price (without VAT)</th>
                                <th>Currency</th>
                                <th></th>

                            </tr>
                        </thead>
                        <tbody class=""row"">
");
            EndContext();
#line 28 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\PickServices.cshtml"
                             foreach (var service in Model)
                            {


#line default
#line hidden
            BeginContext(927, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1006, 17, false);
#line 32 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\PickServices.cshtml"
                                   Write(service.ServiceId);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1071, 12, false);
#line 33 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\PickServices.cshtml"
                                   Write(service.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1083, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1131, 13, false);
#line 34 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\PickServices.cshtml"
                                   Write(service.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1192, 16, false);
#line 35 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\PickServices.cshtml"
                                   Write(service.Currency);

#line default
#line hidden
            EndContext();
            BeginContext(1208, 96, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <button");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1304, "\"", 1330, 1);
#line 37 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\PickServices.cshtml"
WriteAttributeValue("", 1312, service.ServiceId, 1312, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1331, 176, true);
            WriteLiteral(" class=\"btn btn-primary serviceItem\" role=\"button\" type=\"submit\">Add To Invoice</button>\r\n\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 42 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\PickServices.cshtml"
                            }

#line default
#line hidden
            BeginContext(1538, 1154, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>

                <script>

                    $(function () {
                        $(""#pickServices"").modal();
                    });

                    let services = document.getElementsByClassName(""row"")[0];
                    console.log(services);
                    services.addEventListener(""click"", function (e) {
                      
                        e.stopPropagation();
                        let target = e.target;


                        let targetId = target.classList.contains(""serviceItem"") ? target.value : null;
                        console.log(targetId);
                        console.log(targetId);
                        if (targetId != null) {
                            fetch(""/Invoice/AddDetailsToInvoice?serviceId="" + targetId, {
                                method: ""post"",
                                
  ");
            WriteLiteral("                          })\r\n\r\n        \r\n\r\n\r\n                        }\r\n\r\n\r\n                    })\r\n\r\n                </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ServiceViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
