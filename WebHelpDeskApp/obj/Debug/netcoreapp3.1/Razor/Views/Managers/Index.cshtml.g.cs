#pragma checksum "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f48da33637c7b5527f9a68bd8c931374ba196577"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Managers_Index), @"mvc.1.0.view", @"/Views/Managers/Index.cshtml")]
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
#line 1 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\_ViewImports.cshtml"
using WebHelpDeskApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\_ViewImports.cshtml"
using WebHelpDeskApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f48da33637c7b5527f9a68bd8c931374ba196577", @"/Views/Managers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9a6723a2fae6e9a4b0aec2ec8d7725884122d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Managers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebHelpDeskApp.Models.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
  
    ViewData["Title"] = "Managers List";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
   int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Managers List</h1>

<p>
    <a href=""/Identity/Account/ManagerRegister"" class=""btn btn-primary"">Add Manager</a>
</p>

<table class=""table"">
    <thead>
        <tr>
            <th>Sr. No</th>
            <th>Full Name</th>
            <th>Email</th>
            <th>Phone No.</th>
            <th>D-O-B</th>
            <th>Job</th>
            <th>Salary</th>
            <th>Role</th>
            <th>Department</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
               Write(Convert.ToDateTime(item.DateOfBirth).ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <span class=\"badge badge-warning\">Manager</span>\r\n                </td>\r\n");
#nullable restore
#line 53 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
                 if (item.DepartmentID == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <span class=\"badge badge-success\">None</span>\r\n                    </td>\r\n");
#nullable restore
#line 58 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <span class=\"badge badge-success\">");
#nullable restore
#line 62 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
                                                     Write(item.Department.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n");
#nullable restore
#line 64 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f48da33637c7b5527f9a68bd8c931374ba1965778669", async() => {
                WriteLiteral("<i class=\"fa fa-edit\" title=\"Update Manager\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <button class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2172, "\"", 2204, 3);
            WriteAttributeValue("", 2182, "DeleteUser(\'", 2182, 12, true);
#nullable restore
#line 67 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
WriteAttributeValue("", 2194, item.Id, 2194, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2202, "\')", 2202, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\" title=\"Delete Manager\"></i></button>\r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 70 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Managers\Index.cshtml"
            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<script>
    var popover = new bootstrap.Popover(document.querySelector('.popover-dismiss'), {
        trigger: 'focus'
    });

    function DeleteUser(id) {
        debugger
        if (confirm(""Do you want to Delete this User?"")) {
            $.post(""/Admin/DeleteUserbyAdmin"", { userid : id }, function () {
                alert(""User has been deleted successfully!"");
            });
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebHelpDeskApp.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
