#pragma checksum "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb2dec272cbbeebff35ed25370d198ac2b35ce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_InvoiceDetails), @"mvc.1.0.view", @"/Views/Invoice/InvoiceDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/InvoiceDetails.cshtml", typeof(AspNetCore.Views_Invoice_InvoiceDetails))]
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
#line 1 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
using eManager.WebModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb2dec272cbbeebff35ed25370d198ac2b35ce0", @"/Views/Invoice/InvoiceDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bce773a2e7a4e5c04545815629efd019da2764", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_InvoiceDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoiceViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Invoice details";
    var counter = 0;
    double totalVal=0;
    string eur = " euro";

    string mkd = " денари";

#line default
#line hidden
            BeginContext(231, 138, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\" id=\"invoiceContent\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\" id=\"logoImg\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 369, "", 407, 1);
#line 20 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
WriteAttributeValue("", 374, Url.Content("~/images/logo.png"), 374, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(407, 924, true);
            WriteLiteral(@" width=""120"" height=""80"" />
        </div>
        

    </div>
    <div class=""row"" style=""font-family:Impact"">
        <div class=""col-md-12"">
            <hr />
            <h3>ОГНООТПОРНО д.о.о. <small>ТРГОВСКО ДРУШТВО ЗА ПРОИЗВОДСТВО,ТРГОВИЈА И УСЛУГИ ИЗВОЗ-УВОЗ</small></h3>
            <h6>Скопје ул. “16 Македонска бригада” бр. 18  тел/фах 3287 801/3287 806</h6>
            <h6><small>жиро сметка 300000000202572 Комерцијална банка</small></h6>
            <h6><small>е.д.б. МК4030995187257</small></h6><br />
            <hr />
        </div>
    </div>
    <br /><br />
          <div class=""row"">
              <div class=""col-md-3"">
                  <div class=""input-group-prepend"" >
                      <span class=""input-group-text"">Client:</span>
                  </div>
                  <div style=""border:1px solid black"">
                      <div>
                          ");
            EndContext();
            BeginContext(1332, 35, false);
#line 43 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                     Write(Html.DisplayFor(x => x.Client.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 87, true);
            WriteLiteral("\r\n                      </div>\r\n                      <div>\r\n                          ");
            EndContext();
            BeginContext(1455, 38, false);
#line 46 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                     Write(Html.DisplayFor(x => x.Client.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 265, true);
            WriteLiteral(@"
                      </div>
                  </div>
              </div>
              <div class=""col-md-5""></div>
              <div class=""col-md-3"" style=""border:1px solid black"">
                  <label for=""InvoiceNumber"">Invoice No.: </label><span>");
            EndContext();
            BeginContext(1759, 37, false);
#line 52 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                                                   Write(Html.DisplayFor(x => x.InvoiceNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 78, true);
            WriteLiteral("</span><br />\r\n                  <label for=\"InvoiceDate\">Date: </label><span>");
            EndContext();
            BeginContext(1875, 35, false);
#line 53 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                                          Write(Html.DisplayFor(x => x.InvoiceDate));

#line default
#line hidden
            EndContext();
            BeginContext(1910, 97, true);
            WriteLiteral("</span><br />\r\n                  <label for=\"PaymentPeriod\">Payment period (days): </label><span>");
            EndContext();
            BeginContext(2008, 37, false);
#line 54 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                                                             Write(Html.DisplayFor(x => x.PaymentPeriod));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 78, true);
            WriteLiteral("</span><br />\r\n                  <label for=\"DueDate\">Due Date: </label><span>");
            EndContext();
            BeginContext(2124, 31, false);
#line 55 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                                          Write(Html.DisplayFor(x => x.DueDate));

#line default
#line hidden
            EndContext();
            BeginContext(2155, 172, true);
            WriteLiteral("</span>\r\n              </div>\r\n              <div class=\"col-md-1\"></div>\r\n          </div>\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            ");
            EndContext();
            BeginContext(2328, 35, false);
#line 62 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
       Write(Html.DisplayFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2363, 348, true);
            WriteLiteral(@"
        </div>
    </div>


    <table class=""table"">
        <thead>
            <tr>
                <th>#</th>
                <th>Description</th>
                <th>Quantity</th>
                <th>Unit Price</th>
                <th>Total</th>
            </tr>
        </thead>
        <tbody class=""invoiceServices"">


");
            EndContext();
#line 80 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
             foreach (var item in Model.InvoiceServices)
            {


#line default
#line hidden
            BeginContext(2786, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(2834, 12, false);
#line 84 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                    Write(counter += 1);

#line default
#line hidden
            EndContext();
            BeginContext(2847, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2879, 9, false);
#line 85 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2888, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2920, 28, false);
#line 86 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(item.Quantity.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(2948, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2980, 10, false);
#line 87 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2990, 35, true);
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n");
            EndContext();
#line 90 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                          
                     
                            var totalNoVAT = item.Price * item.Quantity;
                        

#line default
#line hidden
            BeginContext(3177, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3204, 25, false);
#line 95 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(totalNoVAT.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(3229, 54, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 99 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"

            }

#line default
#line hidden
            BeginContext(3300, 201, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n                <td>TOTAL (VAT Excl.):</td>\r\n                <td>\r\n");
            EndContext();
#line 109 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                      var sumVAT = Model.InvoiceServices.Sum(x => x.Price * x.Quantity); var resultVAT = sumVAT * 0.18;

#line default
#line hidden
            BeginContext(3623, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 110 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                      var sumTOTAL = Model.InvoiceServices.Sum(x => x.Price * x.Quantity); var sumWithVAT = sumTOTAL + resultVAT; 

#line default
#line hidden
            BeginContext(3756, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 111 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                     if (Model.InvoiceServices.Any(x => x.CurrencyRate == 1 && x.Currency == CurrencyView.EUR))
                    {
                        

#line default
#line hidden
            BeginContext(3917, 23, false);
#line 113 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(sumTOTAL.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(3942, 3, false);
#line 113 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                            Write(eur);

#line default
#line hidden
            EndContext();
#line 113 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                                     
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(4044, 23, false);
#line 117 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(sumTOTAL.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(4069, 3, false);
#line 117 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                            Write(mkd);

#line default
#line hidden
            EndContext();
#line 117 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                                     
                    }

#line default
#line hidden
            BeginContext(4097, 198, true);
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n                <td>VAT:</td>\r\n                <td>\r\n");
            EndContext();
#line 129 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                       string mitalVatMsg = "Напомена: Пренесување на даночна обврска согласно чл.32-а став 1,точка 2 и член 53, став 6 од Закон за ДДВ.";

#line default
#line hidden
            BeginContext(4452, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 130 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                       var nullVat = 0;

#line default
#line hidden
            BeginContext(4494, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 131 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                     if (Model.InvoiceServices.Any(x => x.CurrencyRate == 1 && x.Currency == CurrencyView.EUR))
                    {
                        

#line default
#line hidden
            BeginContext(4655, 7, false);
#line 133 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(nullVat);

#line default
#line hidden
            EndContext();
#line 133 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                
                    }

#line default
#line hidden
            BeginContext(4687, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 135 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                     if (Model.ClientName.ToLower().Contains("arcelor") || Model.ClientName.ToLower().Contains("aрцелор") || Model.ClientName.ToLower().Contains("Liberty") || Model.ClientName.ToLower().Contains("Либерти"))
                    {

                        

#line default
#line hidden
            BeginContext(4961, 11, false);
#line 138 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(mitalVatMsg);

#line default
#line hidden
            EndContext();
#line 138 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                    

                    }

#line default
#line hidden
            BeginContext(4999, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 141 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                     if (Model.InvoiceServices.Any(x => x.Currency == CurrencyView.MKD))
                    {

                        

#line default
#line hidden
            BeginContext(5139, 24, false);
#line 144 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(resultVAT.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(5165, 3, false);
#line 144 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                             Write(mkd);

#line default
#line hidden
            EndContext();
#line 144 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                                      
                    }

#line default
#line hidden
            BeginContext(5193, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 146 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                     if (Model.InvoiceServices.Any(x => x.CurrencyRate != 1 && x.Currency == CurrencyView.EUR))
                    {
                        

#line default
#line hidden
            BeginContext(5354, 24, false);
#line 148 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(resultVAT.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(5380, 3, false);
#line 148 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                             Write(mkd);

#line default
#line hidden
            EndContext();
#line 148 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                                      
                    }

#line default
#line hidden
            BeginContext(5408, 231, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n                <td><bold>TOTAL:</bold></td>\r\n                <td id=\"totalValue\">\r\n\r\n");
            EndContext();
#line 161 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                     if (Model.InvoiceServices.Any(x => x.Currency == CurrencyView.EUR && x.CurrencyRate == 1) || Model.ClientName.ToLower().Contains("aрцелор") || Model.ClientName.ToLower().Contains("arcelor") || Model.ClientName.ToLower().Contains("Liberty") || Model.ClientName.ToLower().Contains("Либерти"))
                    {
                        totalVal = sumTOTAL;

                        

#line default
#line hidden
            BeginContext(6048, 23, false);
#line 165 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(totalVal.ToString("N0"));

#line default
#line hidden
            EndContext();
#line 165 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                                
                    }
                    else
                    {
                        totalVal = sumWithVAT;
                        

#line default
#line hidden
            BeginContext(6218, 23, false);
#line 170 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                   Write(totalVal.ToString("N0"));

#line default
#line hidden
            EndContext();
#line 170 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                                
                    }

#line default
#line hidden
            BeginContext(6266, 782, true);
            WriteLiteral(@"

                </td>

            </tr>
            <tr>
                <td colspan=""5"">
                    Total amount is:
                    <span id=""amount"">

                    </span>
                </td>
            </tr>

        </tfoot>
    </table>

    <br />
    <div class=""row col-md-12"">
        <div class=""col-md-6"">
            <p>Authorized employee for invoicing:</p>
            <p>Name:</p>
            <p>Signature: <hr /></p>
        </div>
        <div class=""col-md-6"">
            <p>OGNOOTPORNO d.o.o.</p>
            <p>Manager</p>
            <p>Signature: <hr /></p>
        </div>
    </div>
</div>
<br />


<div id=""footerInvoice"">
    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 7048, "\"", 7108, 3);
            WriteAttributeValue("", 7058, "location.href=\'", 7058, 15, true);
#line 207 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
WriteAttributeValue("", 7073, Url.Action("Invoices", "Invoice"), 7073, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 7107, "\'", 7107, 1, true);
            EndWriteAttribute();
            BeginContext(7109, 135, true);
            WriteLiteral(">Back</button>\r\n    <button class=\"btn btn-success\" onclick=\"printInvoice()\">PRINT</button>\r\n</div>\r\n    <script type=\"text/javascript\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 7244, "", 7323, 1);
#line 210 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
WriteAttributeValue("", 7249, Url.Content("//ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js"), 7249, 74, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7323, 1978, true);
            WriteLiteral(@"></script>

<script>

    function numToWord(num) {


        let oneDigit = ['', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
        let tens = ['', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];
        let twoDigits = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];


        function trillion(num) {
            if (num >= 1000000000000) {
                return trillion(Math.floor(num / 1000000000000)) + ""trillion"" + million(num % 1000000000000);
            }
            else {
                return million(num);
            }
        }

        function million(num) {
            if (num >= 1000000) {
                return million(Math.floor(num / 1000000)) + ""million"" + thousand(num % 1000000);
            }
            else {
                return thousand(num);
            }
        }

        function thousand(num) {
            if (num >= ");
            WriteLiteral(@"1000) {
                return hundred(Math.floor(num / 1000)) + ""thousand"" + hundred(num % 1000);
            }
            else {
                return hundred(num);
            }
        }

        function hundred(num) {
            if (num > 99) {
                return oneDigit[Math.floor(num / 100)] + ""hundred"" + tensToWord(num % 100);
            }
            else {
                return tensToWord(num);
            }
        }

        function tensToWord(num) {
            if (num < 10) return oneDigit[num];
            else if (num >= 10 && num < 20) return twoDigits[num - 10];
            else {
                return tens[Math.floor(num / 10)] + oneDigit[num % 10];
            }
        }

        function convert(num) {
            if (num === 0) return ""zero"";
            else return trillion(num);
        }


        return convert(num);
    }


            $('#amount').append(numToWord(");
            EndContext();
            BeginContext(9302, 8, false);
#line 276 "C:\Users\User\source\repos\eManager\eManager\Views\Invoice\InvoiceDetails.cshtml"
                                     Write(totalVal);

#line default
#line hidden
            EndContext();
            BeginContext(9310, 428, true);
            WriteLiteral(@"));


    function printInvoice() {

     
        //var printContents = document.getElementById('invoiceContent').innerHTML;


        //var originalContents = document.body.innerHTML;
      
        //document.body.innerHTML = printContents;
        $('#footerInvoice').hide();
        window.print();
        $('#footerInvoice').show();
        //document.body.innerHTML = originalContents;
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
