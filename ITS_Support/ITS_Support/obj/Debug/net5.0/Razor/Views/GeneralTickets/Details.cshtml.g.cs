#pragma checksum "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a46af46f3c34cb22678973edf1884979856c84a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GeneralTickets_Details), @"mvc.1.0.view", @"/Views/GeneralTickets/Details.cshtml")]
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
#line 1 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\_ViewImports.cshtml"
using ITS_Support;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\_ViewImports.cshtml"
using ITS_Support.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a46af46f3c34cb22678973edf1884979856c84a5", @"/Views/GeneralTickets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52452de915ad46a45ca1925d9532893dc1b81273", @"/Views/_ViewImports.cshtml")]
    public class Views_GeneralTickets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ITS_Support.Models.GeneralTicketViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UpdateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
  
    ViewData["Title"] = "Details";
    string status = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row button-row\">\r\n    <div class=\"col-md-4\">\r\n        <h1>Ticket Details</h1>\r\n    </div>\r\n    <div class=\"col-md-3 offset-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a46af46f3c34cb22678973edf1884979856c84a55876", async() => {
                WriteLiteral("Return to Tickets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6 offset-3\">\r\n            <dl class=\"row ticket-details\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.GeneralTicket.Issue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dt class=\"col-sm-2\"></dt>\r\n                <dd class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
               Write(Html.DisplayFor(model => model.GeneralTicket.Issue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.GeneralTicket.ExtraDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dt class=\"col-sm-2\"></dt>\r\n                <dd class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
               Write(Html.DisplayFor(model => model.GeneralTicket.ExtraDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.GeneralTicket.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dt class=\"col-sm-2\"></dt>\r\n                <dd class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
               Write(Html.DisplayFor(model => model.GeneralTicket.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.GeneralTicket.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dt class=\"col-sm-2\"></dt>\r\n                <dd class=\"col-sm-8\">\r\n                    ");
#nullable restore
#line 48 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
               Write(Html.DisplayFor(model => model.GeneralTicket.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-md-6 offset-5 update-title\">\r\n        <h2 class=\"align-items-center\">Updates</h2>\r\n    </div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 58 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
         foreach (UpdateModel update in Model.GeneralTicket.Updates)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6 offset-3 update\">\r\n                <div class=\"col-md-12\">\r\n                    <h5>");
#nullable restore
#line 62 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
                   Write(update.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 62 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
                                    Write(update.Update);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <p class=\"update-author\">");
#nullable restore
#line 65 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
                                        Write(update.CreatedAt.ToString().Substring(0, 8));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - <b>");
#nullable restore
#line 65 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
                                                                                          Write(update.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 68 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"col-md-6 offset-4 update-title\">\r\n        <h2 class=\"align-items-center\">Create an Update</h2>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6 offset-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a46af46f3c34cb22678973edf1884979856c84a513056", async() => {
                WriteLiteral("\r\n                <input name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2789, "\"", 2820, 1);
#nullable restore
#line 77 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
WriteAttributeValue("", 2797, Model.GeneralTicket.Id, 2797, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" />\r\n                ");
#nullable restore
#line 78 "C:\Users\bradl\Documents\GitHub\SCDT51-CW2\ITS_Support\ITS_Support\Views\GeneralTickets\Details.cshtml"
           Write(Html.DropDownList("status", new SelectList(Enum.GetValues(typeof(StatusOptions))), "Status", new { @class = "form-select btn btn-dark btn-block col-md-4" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input class=\"form-control col-md-8\" type=\"text\" placeholder=\"Details\" name=\"update\" />\r\n                <button type=\"submit\" class=\"btn btn-dark w-100 mt-2\">Submit</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ITS_Support.Models.GeneralTicketViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
