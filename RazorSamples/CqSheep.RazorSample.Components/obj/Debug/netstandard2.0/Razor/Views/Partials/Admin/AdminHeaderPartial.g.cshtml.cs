#pragma checksum "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Partials\Admin\AdminHeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4df0e6f327dbd54af37c56e503b85fefc9c80681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials_Admin_AdminHeaderPartial), @"mvc.1.0.view", @"/Views/Partials/Admin/AdminHeaderPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partials/Admin/AdminHeaderPartial.cshtml", typeof(AspNetCore.Views_Partials_Admin_AdminHeaderPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4df0e6f327dbd54af37c56e503b85fefc9c80681", @"/Views/Partials/Admin/AdminHeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials_Admin_AdminHeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/ComponentItems/SearchInput.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/0.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 164, true);
            WriteLiteral("<div class=\"flex-row flex-main-between flex-align-center header-banner\">\r\n    <div class=\"flex-row flex-main-center flex-align-center\" style=\"width:100%\">\r\n        ");
            EndContext();
            BeginContext(164, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4df0e6f327dbd54af37c56e503b85fefc9c806814059", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(222, 372, true);
            WriteLiteral(@"</partial>
    </div>
    <div class=""flex-row flex-main-end flex-align-center header-banner-right"">
        <div class=""header-notice"">
            <span class=""glyphicon glyphicon-knight"">
            </span>
        </div>
        <div class=""flex-row flex-main-center flex-align-center header-menu"">
            <div class=""header-headImage"">
                ");
            EndContext();
            BeginContext(594, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4df0e6f327dbd54af37c56e503b85fefc9c806815695", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(622, 3099, true);
            WriteLiteral(@"
            </div>
            <div class=""header-other"">
                <span style=""color: rgba(0,0,0,.5);"">xeekseven</span>
                <span class=""glyphicon glyphicon-triangle-bottom"" style=""margin-top:2px;cursor:pointer""></span>
                <div class=""flex-column flex-main-start flex-align-start dropdown-menu dropdown-menu-small hide"" style=""display: block;"">
                    <a class=""dropdown-item"" href=""user-profile-lite.html"">
                        <span class=""glyphicon glyphicon-user""></span> Profile
                    </a>
                    <a class=""dropdown-item"" href=""components-blog-posts.html"">
                        <span class=""glyphicon glyphicon-list""></span> Blog Posts
                    </a>
                    <a class=""dropdown-item"" href=""add-new-post.html"">
                        <span class=""glyphicon glyphicon-piggy-bank""></span> Add New Post
                    </a>
                    <div class=""dropdown-divider""></div>
                   ");
            WriteLiteral(@" <a class=""dropdown-item text-danger"" href=""#"">
                        <span class=""glyphicon glyphicon-log-out text-danger""></span>Logout
                    </a>
                </div>
            </div>
        </div>
    </div>

</div>

<style>
    .text-danger {
        color: #c4183c !important;
    }

    .dropdown-menu {
        margin-top:0;
        position: absolute;
        width: 11rem;
        right: 0;
        float: none;
        left: auto;
        top: 3.75rem;
        display: block;
        border-top-left-radius: 0;
        border-top-right-radius: 0;
        border-top: none;
        text-align: center;
    }

    .dropdown-menu-small {
    }

    .header-notice {
        width: 4rem;
        text-align: center;
    }

        .header-notice > .glyphicon {
            font-size: 1.4rem;
            color: #756e6e;
            margin: 0;
            cursor: pointer
        }

    .dropdown-divider {
        margin: .25rem 0;
        height: ");
            WriteLiteral(@"0;
        overflow: hidden;
        border-top: 1px solid #e9ecef;
    }

    .dropdown-item {
        display: block;
        text-align: start;
        padding: .375rem .875rem;
        font-size: .813rem;
        color: rgba(0,0,0,.5);
        font-weight: 300;
    }

    a[class~=""dropdown-item""]:hover {
        text-decoration: none;
        background-color: #f1f0f0;
    }

    .header-banner {
        height: 3.75rem;
        box-shadow: 0 0.125rem 0.625rem rgba(90,97,105,.12);
    }

    .header-headImage {
        width: 4rem;
        text-align: center;
    }

        .header-headImage > img {
            max-width: 2.5rem;
            border-radius: 50% !important;
        }

    .header-other {
        width: 7rem;
    }

    .header-menu {
        height: 100%;
        border-left: 1px solid #e1e5eb !important;
    }

    .header-banner-right {
        border-left: 1px solid #e1e5eb !important;
        height: 100%;
        width: 15rem;
    }
</st");
            WriteLiteral("yle>\r\n<script>\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
