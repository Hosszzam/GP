#pragma checksum "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb1aa3a600cad7ce10a271fa363197f4e6d298e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb1aa3a600cad7ce10a271fa363197f4e6d298e4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9a6723a2fae6e9a4b0aec2ec8d7725884122d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/webhelpdeskoutline.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:430px;height:320px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card-counter {
        box-shadow: 2px 2px 10px #DADADA;
        margin: 5px;
        padding: 20px 10px;
        background-color: #fff;
        height: 100px;
        border-radius: 5px;
        transition: .3s linear all;
    }

    .card-counter:hover {
        box-shadow: 4px 4px 20px #DADADA;
        transition: .3s linear all;
    }

    .card-counter.primary {
        background-color: #007bff;
        color: #FFF;
    }

    .card-counter.danger {
        background-color: #ef5350;
        color: #FFF;
    }

    .card-counter.success {
        background-color: #66bb6a;
        color: #FFF;
    }

    .card-counter.info {
        background-color: #26c6da;
        color: #FFF;
    }

    .card-counter i {
        font-size: 5em;
        opacity: 0.2;
    }

    .card-counter .count-numbers {
        position: absolute;
        right: 35px;
        top: 20px;
        font-size: 32px;
        display: block;
    }

    .card-counter .coun");
            WriteLiteral("t-name {\r\n        position: absolute;\r\n        right: 35px;\r\n        top: 65px;\r\n        text-transform: capitalize;\r\n        opacity: 0.8;\r\n        display: block;\r\n        font-size: 18px;\r\n    }\r\n</style>\r\n\r\n");
#nullable restore
#line 65 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Home\Index.cshtml"
 if (!User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-7"">
                <h1 class=""display-4"">Welcome to<br /> Web Help Desk <br />Website</h1>
            </div>
            <div class=""col-md-5"" style=""padding:0px;"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb1aa3a600cad7ce10a271fa363197f4e6d298e45832", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 77 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n");
#nullable restore
#line 81 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Home\Index.cshtml"
     if (User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container"">
            <div class=""row"">
                <span class=""badge badge-danger"">&bull; Admin Account</span>
            </div>
            <div class=""row"">
                <div class=""col-md-3"">
                    <div class=""card-counter primary"">
                        <i class=""fas fa-user-tie""></i>
                        <span class=""count-numbers"" id=""managers""></span>
                        <span class=""count-name"">Managers</span>
                    </div>
                </div>

                <div class=""col-md-2"">
                    <div class=""card-counter danger"">
                        <i class=""fas fa-users""></i>
                        <span class=""count-numbers"" id=""employees""></span>
                        <span class=""count-name"">Employees</span>
                    </div>
                </div>

                

                <div class=""col-md-2"">
                    <div class=""card-counter info"">
                        ");
            WriteLiteral(@"<i class=""fas fa-tasks""></i>
                        <span class=""count-numbers"" id=""tasks""></span>
                        <span class=""count-name"">Total Tasks</span>
                    </div>
                </div>

                <div class=""col-md-2"">
                    <div class=""card-counter info"">
                        <i class=""fas fa-archive""></i>
                        <span class=""count-numbers"" id=""archivedtasks""></span>
                        <span class=""count-name"">Archived Tasks</span>
                    </div>
                </div>

                <div class=""col-md-3"">
                    <div class=""card-counter info"">
                        <i class=""fas fa-tasks""></i>
                        <span class=""count-numbers"" id=""todayTasks""></span>
                        <span class=""count-name"">Today's Tasks</span>
                    </div>
                </div>
            </div>
");
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-6"">

                    <div id=""container"">

                    </div>
                </div>
                <div class=""col-md-6"">

                </div>
            </div>

        </div>
");
#nullable restore
#line 144 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Home\Index.cshtml"
    }
    else if (User.IsInRole("Manager"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container"">
            <div class=""row"">
                <span class=""badge badge-danger"">&bull; Manager Account</span>
            </div>
            <div class=""row"">  
                <div class=""col-md-3"">
                    <div class=""card-counter danger"">
                        <i class=""fas fa-users""></i>
                        <span class=""count-numbers"" id=""employees""></span>
                        <span class=""count-name"">Employees</span>
                    </div>
                </div>

                <div class=""col-md-3"">
                    <div class=""card-counter info"">
                        <i class=""fas fa-tasks""></i>
                        <span class=""count-numbers"" id=""tasks""></span>
                        <span class=""count-name"">Total Tasks</span>
                    </div>
                </div>

                <div class=""col-md-3"">
                    <div class=""card-counter info"">
                        <i class=""fas fa-archi");
            WriteLiteral(@"ve""></i>
                        <span class=""count-numbers"" id=""archivedtasks""></span>
                        <span class=""count-name"">Archived Tasks</span>
                    </div>
                </div>

                <div class=""col-md-3"">
                    <div class=""card-counter info"">
                        <i class=""fas fa-tasks""></i>
                        <span class=""count-numbers"" id=""todayTasks""></span>
                        <span class=""count-name"">Today's Tasks</span>
                    </div>
                </div>
            </div>
");
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-6"">

                    <div id=""container"">

                    </div>
                </div>
                <div class=""col-md-6"">

                </div>
            </div>

        </div>
");
#nullable restore
#line 198 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Home\Index.cshtml"
    }
    else if (User.IsInRole("Employee"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container"">
            <div class=""row"">
                <span class=""badge badge-info"">&bull; Employee Account</span>
            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""card-counter primary"">
                        <i class=""fas fa-tasks""></i>
                        <span class=""count-numbers"" id=""mytotaltasks""></span>
                        <span class=""count-name"">My Total Tasks</span>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""card-counter success"">
                        <i class=""fas fa-tasks""></i>
                        <span class=""count-numbers"" id=""myopentasks""></span>
                        <span class=""count-name"">My Open Tasks</span>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""card-counter danger"">
                        <i clas");
            WriteLiteral(@"s=""fas fa-tasks""></i>
                        <span class=""count-numbers"" id=""myclosetasks""></span>
                        <span class=""count-name"">My Closed Tasks</span>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 229 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 231 "C:\Users\Necsir\Downloads\Work\GP2\Rep\WebHelpDeskApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    $(document).ready(function () {
        $.post(""/Admin/AdminDashboardData"", function (data) {
            var realdata = data.split(""::"");
            //debugger
            if (realdata.length == 4) {
                $(""#employees"").text(realdata[0]);
                $(""#tasks"").text(realdata[1]);
                $(""#archivedtasks"").text(realdata[2]);
                $(""#todayTasks"").text(realdata[3]);
            } else if (realdata.length == 3) {
                $(""#mytotaltasks"").text(realdata[0]);
                $(""#myopentasks"").text(realdata[1]);
                $(""#myclosetasks"").text(realdata[2]);
            } else {
                $(""#managers"").text(realdata[0]);
                $(""#employees"").text(realdata[1]);
                $(""#tasks"").text(realdata[2]);
                $(""#archivedtasks"").text(realdata[3]);
                $(""#todayTasks"").text(realdata[4]);
            }
        });

        $.post(""/Admin/TasksChartData"", function (data) {
       ");
            WriteLiteral(@"     var realdata = data.split(""::"");
            //This is the pie chart 
            Highcharts.chart('container', {
                chart: {
                    plotBackgroundColor: null,
                    plotBorderWidth: null,
                    plotShadow: null,
                    type: 'pie'
                },
                legend: {
                    align: 'right',
                    layout: 'vertical',
                    verticalAlign: 'middle',
                    labelFormatter: function () {
                        return this.name + ' - ' + this.y;
                    }
                },
                title: {
                    text: null
                },
                tooltip: {
                    useHTML: true,
                    formatter: function () {
                        return '<div>Status : ' + this.point.name + '</div><div style=""text-align:center;"">Count : ' + this.point.y + '</div>';
                    }
                },
           ");
            WriteLiteral(@"     plotOptions: {
                    pie: {
                        allowPointSelect: true,
                        cursor: 'pointer',
                        dataLabels: {
                            enabled: false,
                            format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                            style: {
                                color: Highcharts.theme && Highcharts.theme.contrastTextColor || 'black'
                            }
                        },
                        showInLegend: true
                    }
                },
                credits: {
                    enabled: false
                },
                series: [{
                    colorByPoint: true,
                    allowPointSelect: true,

                    data: [{
                        name: 'Open',
                        y: parseInt(realdata[0]),
                        color: '#32AE47'
                    }, {
                        name: 'Clo");
            WriteLiteral(@"se',
                        y: parseInt(realdata[1]),
                        color: '#DB4D4D'
                    }, {
                        name: 'Pending',
                        y: parseInt(realdata[2])
                    }, {
                        name: 'Reject',
                        y: parseInt(realdata[3])
                    }]
                }]
            });
        });
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591