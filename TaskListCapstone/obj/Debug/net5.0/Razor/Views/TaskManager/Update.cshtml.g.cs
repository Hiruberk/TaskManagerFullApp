#pragma checksum "D:\Grand Circus\Grand Circus Docs\NET Core\TaskListCapstone\TaskListCapstone\Views\TaskManager\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76ff801299e02cc151afa6eccd865edae772821c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaskManager_Update), @"mvc.1.0.view", @"/Views/TaskManager/Update.cshtml")]
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
#line 1 "D:\Grand Circus\Grand Circus Docs\NET Core\TaskListCapstone\TaskListCapstone\Views\_ViewImports.cshtml"
using TaskListCapstone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Grand Circus\Grand Circus Docs\NET Core\TaskListCapstone\TaskListCapstone\Views\_ViewImports.cshtml"
using TaskListCapstone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76ff801299e02cc151afa6eccd865edae772821c", @"/Views/TaskManager/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e6bc03c0ef75621a1703d698f0942c1b40123be", @"/Views/_ViewImports.cshtml")]
    public class Views_TaskManager_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TaskManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76ff801299e02cc151afa6eccd865edae772821c4370", async() => {
                WriteLiteral("\r\n    <label>ID: </label>\r\n    <input type=\"number\" name=\"ToDoId\" id=\"ToDoId\"");
                BeginWriteAttribute("value", " value=\"", 114, "\"", 135, 1);
#nullable restore
#line 6 "D:\Grand Circus\Grand Circus Docs\NET Core\TaskListCapstone\TaskListCapstone\Views\TaskManager\Update.cshtml"
WriteAttributeValue("", 122, Model.ToDoId, 122, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n    <br />\r\n    <label>Description: </label>\r\n    <input type=\"text\" name=\"Description\"");
                BeginWriteAttribute("value", " value=\"", 237, "\"", 263, 1);
#nullable restore
#line 9 "D:\Grand Circus\Grand Circus Docs\NET Core\TaskListCapstone\TaskListCapstone\Views\TaskManager\Update.cshtml"
WriteAttributeValue("", 245, Model.Description, 245, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    <br />

    <label>Due Date</label>
    <input class=""form-control"" type=""datetime-local"" data-val=""true"" data-val-required=""The Due Date field is required."" data-val-min=""Enter a future date.""
           id=""DateTime"" name=""DueDate"" asp-format=""{0:yyyy-MM-ddTHH:mm}""");
                BeginWriteAttribute("min", " min=\"", 544, "\"", 565, 1);
#nullable restore
#line 14 "D:\Grand Circus\Grand Circus Docs\NET Core\TaskListCapstone\TaskListCapstone\Views\TaskManager\Update.cshtml"
WriteAttributeValue("", 550, DateTime.Today, 550, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 566, "\"", 588, 1);
#nullable restore
#line 14 "D:\Grand Circus\Grand Circus Docs\NET Core\TaskListCapstone\TaskListCapstone\Views\TaskManager\Update.cshtml"
WriteAttributeValue("", 574, Model.DueDate, 574, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <label>Status</label>\r\n    <br />\r\n");
#nullable restore
#line 19 "D:\Grand Circus\Grand Circus Docs\NET Core\TaskListCapstone\TaskListCapstone\Views\TaskManager\Update.cshtml"
     if (Model.Complete == true)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label>Complete:</label><input type=\"radio\" name=\"Complete\" id=\"Complete\"value=\"true\" required checked />\r\n        <label>Incomplete:</label><input type=\"radio\" name=\"Complete\" id=\"Complete\" value=\"false\" required />\r\n");
#nullable restore
#line 23 "D:\Grand Circus\Grand Circus Docs\NET Core\TaskListCapstone\TaskListCapstone\Views\TaskManager\Update.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label>Complete:</label><input type=\"radio\" name=\"Complete\" id=\"Complete\" value=\"true\" required />\r\n        <label>Incomplete:</label><input type=\"radio\" name=\"Complete\" id=\"Complete\" value=\"false\" required checked />\r\n");
#nullable restore
#line 28 "D:\Grand Circus\Grand Circus Docs\NET Core\TaskListCapstone\TaskListCapstone\Views\TaskManager\Update.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <br />\r\n    <input type=\"submit\" value=\"Save\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76ff801299e02cc151afa6eccd865edae772821c9259", async() => {
                WriteLiteral("\r\n    <button>Go Back</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDo> Html { get; private set; }
    }
}
#pragma warning restore 1591
