#pragma checksum "C:\Users\v-vetam\source\repos\Cloud Enablement And Risk Assessment (CERA)2\CeraWebApplication\Views\Cera\LandingPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb928a1f1d29a7ad4e2725036deb24011018459f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cera_LandingPage), @"mvc.1.0.view", @"/Views/Cera/LandingPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb928a1f1d29a7ad4e2725036deb24011018459f", @"/Views/Cera/LandingPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c31bb6c3a36d36b880a7a5547376c5fbff6bbb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cera_LandingPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb928a1f1d29a7ad4e2725036deb24011018459f3241", async() => {
                WriteLiteral(@"
    <h2 class=""row d-flex align-items-center justify-content-center h-100"">Sync Calls</h2>

    <div class=""row d-flex align-items-center justify-content-center h-100"" style=""margin-top:1%"">
        <a href=""/Cera/GetCloudSubscriptionDetails"" class=""btn btn-info"" style=""margin-right:1%"">AzureSubscriptions </a>
        <a href=""/Cera/GetCloudResourceGroupDetails"" class=""btn btn-info"" style=""margin-right:1%"">AzureResourceGroups</a>
        <a href=""/Cera/GetCloudStorageAccountDetails"" class=""btn btn-info"" style=""margin-right:1%"">AzureStorageAccounts</a>
        <a href=""/Cera/GetCloudResourceDetails"" class=""btn btn-info"" style=""margin-right:1%"">AzureResources</a>
        <a href=""/Cera/GetCloudVMDetails"" class=""btn btn-info"" style=""margin-right:1%"">AzureVMS</a>
        <a href=""/Cera/GetCloudSqlServerDetails"" class=""btn btn-info"" style=""margin-right:1%"">AzureSqlServer</a>
        <a href=""/Cera/GetCloudTenantDetails"" class=""btn btn-info"" style=""margin-right:1%"">AzureTenants</a>
    </div>
    <div ");
                WriteLiteral(@"style=""margin-top:1%"" class=""row d-flex align-items-center justify-content-center h-100"">
        <a href=""/Cera/GetCloudWebAppsDetails"" class=""btn btn-info"" style=""margin-right:1%"">AzureWebApps</a>
        <a href=""/Cera/GetCloudAppServicePlansDetails"" class=""btn btn-info"" style=""margin-right:1%"">AzureAppServicePlans</a>
        <a href=""/Cera/GetCloudDisksDetails"" class=""btn btn-info"" style=""margin-right:1%"">AzureDisks</a>
    </div>
    <hr />
    <h2 class=""row d-flex align-items-center justify-content-center h-100"">Get Calls </h2>
    <div class=""row d-flex align-items-center justify-content-center h-100"" style=""margin-top:1%"">
        <a href=""/Cera/GetSubscriptionDetails"" class=""btn btn-primary"" style=""margin-right:1%"">GetSubscriptions </a>
        <a href=""/Cera/GetResourceGroupDetails"" class=""btn btn-primary"" style=""margin-right:1%"">Get ResourceGroups </a>
        <a href=""/Cera/GetStorageAccountsDetails"" class=""btn btn-primary"" style=""margin-right:1%"">GetStorageAccounts</a>
        <a hre");
                WriteLiteral(@"f=""/Cera/GetResourceDetails"" class=""btn btn-primary"" style=""margin-right:1%"">GetResources</a>
        <a href=""/Cera/GetVMDetails"" class=""btn btn-primary"" style=""margin-right:1%"">GetVMS</a>
        <a href=""/Cera/GetSqlServerDetails"" class=""btn btn-primary"" style=""margin-right:1%"">GetSqlServers</a>
        <a href=""/Cera/GetTenantDetails"" class=""btn btn-primary"" style=""margin-right:1%"">GetTenants</a>
        <a href=""/Cera/GetWebAppsDetails"" class=""btn btn-primary"" style=""margin-right:1%"">GetWebApps</a>
    </div>
    <div style=""margin-top:1%"" class=""row d-flex align-items-center justify-content-center h-100"">
        <a href=""/Cera/GetAppServicePlansDetails"" class=""btn btn-primary"" style=""margin-right:1%"">GetAppServicePlans</a>
        <a href=""/Cera/GetDisksDetails"" class=""btn btn-primary"" style=""margin-right:1%"">GetDisks</a>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
