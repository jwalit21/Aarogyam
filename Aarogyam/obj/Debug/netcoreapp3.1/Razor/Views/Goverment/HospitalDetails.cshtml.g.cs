#pragma checksum "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b14188d3d80bf0344b1ebbd31cdee79bb5f37e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Goverment_HospitalDetails), @"mvc.1.0.view", @"/Views/Goverment/HospitalDetails.cshtml")]
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
#line 1 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\_ViewImports.cshtml"
using Aarogyam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\_ViewImports.cshtml"
using Aarogyam.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\_ViewImports.cshtml"
using Aarogyam.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b14188d3d80bf0344b1ebbd31cdee79bb5f37e2", @"/Views/Goverment/HospitalDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1061ec7970fa85a6cac9c3c4a13fe7fc9c27fead", @"/Views/_ViewImports.cshtml")]
    public class Views_Goverment_HospitalDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aarogyam.Models.ViewModels.RegisterHospital>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HospitalList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
  
    ViewData["Title"] = "HospitalDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-6 shadow-sm my-1 p-3 mt-5\" style=\"border-radius:10px;  background-color: rgba(228, 244, 242, 0.83)\">\r\n    <h4>Hospital Details</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 12 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 15 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 18 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 21 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayFor(model => model.OwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 24 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 27 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 30 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 33 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 36 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 39 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayFor(model => model.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 42 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 45 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 48 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 51 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 54 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 57 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 60 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxBeds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 63 "D:\Semester5\WDDN\lab\Project_CE118\Aarogyam\Views\Goverment\HospitalDetails.cshtml"
       Write(Html.DisplayFor(model => model.MaxBeds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b14188d3d80bf0344b1ebbd31cdee79bb5f37e210447", async() => {
                WriteLiteral("Back to Hospital List");
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
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aarogyam.Models.ViewModels.RegisterHospital> Html { get; private set; }
    }
}
#pragma warning restore 1591
