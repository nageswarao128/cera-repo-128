#pragma checksum "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\ManageUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1fb28101d60a9e7e0080e85ed4b0aef69313260"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cera_ManageUsers), @"mvc.1.0.view", @"/Views/Cera/ManageUsers.cshtml")]
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
#line 1 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\_ViewImports.cshtml"
using CeraWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\_ViewImports.cshtml"
using CeraWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1fb28101d60a9e7e0080e85ed4b0aef69313260", @"/Views/Cera/ManageUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c31bb6c3a36d36b880a7a5547376c5fbff6bbb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cera_ManageUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CeraWebApplication.Models.CeraUsers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cera", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Adduser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\ManageUsers.cshtml"
  
    ViewData["Title"] = "ManageUsers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cera Users</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1fb28101d60a9e7e0080e85ed4b0aef693132604194", async() => {
                WriteLiteral("+Add User");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                User ID
            </th>
            <th>
                User Name
            </th>
            <th>
                Email ID
            </th>
            <th>
                Actions
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\ManageUsers.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\ManageUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\ManageUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.userName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\ManageUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.emailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\ManageUsers.cshtml"
           Write(Html.ActionLink("Update", "UpdateUser","Cera", new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                \r\n                ");
#nullable restore
#line 44 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\ManageUsers.cshtml"
           Write(Html.ActionLink("Delete", "DeleteUser","Cera" ,new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\ManageUsers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CeraWebApplication.Models.CeraUsers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
