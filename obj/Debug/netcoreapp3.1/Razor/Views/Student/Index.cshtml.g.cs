#pragma checksum "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e5d2fa074d019882659b67857e4c7f863898c6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "C:\CodeSource\Crud_MVC_MongoDB\Views\_ViewImports.cshtml"
using Crud_MVC_MongoDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodeSource\Crud_MVC_MongoDB\Views\_ViewImports.cshtml"
using Crud_MVC_MongoDB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e5d2fa074d019882659b67857e4c7f863898c6e", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afba96948e1be2b363d1bcfa043af6e7cff0f979", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Crud_MVC_MongoDB.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n\t<div class=\"container-fluid\">\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e5d2fa074d019882659b67857e4c7f863898c6e5254", async() => {
                WriteLiteral(" \r\n\t\t\t<div class=\"form-inline\">\r\n\t\t\t\t<div class=\"form-inline\">\r\n\t\t\t\t\t<label for=\"firstName\">");
#nullable restore
#line 14 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
                                      Write(Html.DisplayNameFor(model => model.firstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n\t\t\t\t\t<input type=\"text\" class=\"form-control\" name=\"firstName\"");
                BeginWriteAttribute("value", " value=", 479, "", 508, 1);
#nullable restore
#line 15 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
WriteAttributeValue("", 486, ViewData["firstName"], 486, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"form-inline\">\r\n\t\t\t\t\t<label for=\"lastName\">");
#nullable restore
#line 18 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
                                     Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n\t\t\t\t\t<input type=\"text\" class=\"form-control\" name=\"lastName\"");
                BeginWriteAttribute("value", " value=", 696, "", 724, 1);
#nullable restore
#line 19 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
WriteAttributeValue("", 703, ViewData["lastName"], 703, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"form-inline\">\r\n\t\t\t\t\t<label for=\"maxDate\">");
#nullable restore
#line 22 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
                                    Write(Html.DisplayNameFor(model => model.emailAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n\t\t\t\t\t<input type=\"text\" class=\"form-control\" name=\"emailAddress\"");
                BeginWriteAttribute("value", " value=", 919, "", 951, 1);
#nullable restore
#line 23 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
WriteAttributeValue("", 926, ViewData["emailAddress"], 926, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t</div>\r\n</nav>\r\n<hr />\r\n<p>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e5d2fa074d019882659b67857e4c7f863898c6e9640", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 38 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 41 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 44 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.emailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 50 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 54 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 57 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 60 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.emailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 63 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item._id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\t\t\t\t\t");
#nullable restore
#line 64 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item._id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\t\t\t\t\t");
#nullable restore
#line 65 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item._id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 68 "C:\CodeSource\Crud_MVC_MongoDB\Views\Student\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Crud_MVC_MongoDB.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591