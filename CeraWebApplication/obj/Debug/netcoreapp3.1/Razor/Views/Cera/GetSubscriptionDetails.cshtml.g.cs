#pragma checksum "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\GetSubscriptionDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa425c2f3d1c2a0be56ce03e2e8457b856e2723d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cera_GetSubscriptionDetails), @"mvc.1.0.view", @"/Views/Cera/GetSubscriptionDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa425c2f3d1c2a0be56ce03e2e8457b856e2723d", @"/Views/Cera/GetSubscriptionDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c31bb6c3a36d36b880a7a5547376c5fbff6bbb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cera_GetSubscriptionDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CeraWebApplication.Models.CeraSubscription>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Subscription List</h1>\r\n");
#nullable restore
#line 3 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\GetSubscriptionDetails.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-striped table-hover"" style=""margin-top:1%"">
    <thead>
        <tr>
            <th>
                SubscriptionId
            </th>


            <th>
                DisplayName
            </th>


            <th>
                TenantID
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\GetSubscriptionDetails.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 28 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\GetSubscriptionDetails.cshtml"
   Write(Html.DisplayFor(modelItem => item.SubscriptionId));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 31 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\GetSubscriptionDetails.cshtml"
   Write(Html.DisplayFor(modelItem => item.DisplayName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 34 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\GetSubscriptionDetails.cshtml"
   Write(Html.DisplayFor(modelItem => item.TenantID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 37 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\GetSubscriptionDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 40 "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\GetSubscriptionDetails.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CeraWebApplication.Models.CeraSubscription>> Html { get; private set; }
    }
}
#pragma warning restore 1591
