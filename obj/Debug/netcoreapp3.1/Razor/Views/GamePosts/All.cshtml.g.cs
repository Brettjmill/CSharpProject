#pragma checksum "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38bbde27f241d7ffe20474888b0e98161568989f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GamePosts_All), @"mvc.1.0.view", @"/Views/GamePosts/All.cshtml")]
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
#line 1 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\_ViewImports.cshtml"
using CSharpProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\_ViewImports.cshtml"
using CSharpProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38bbde27f241d7ffe20474888b0e98161568989f", @"/Views/GamePosts/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d822ae380dac6388ac464769e46b807940c1bd", @"/Views/_ViewImports.cshtml")]
    public class Views_GamePosts_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GamePost>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_createForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GamePosts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2 class=\"text-center\">All Posts</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
  
  GamePost newGamePost = new GamePost();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "38bbde27f241d7ffe20474888b0e98161568989f4400", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 8 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = newGamePost;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</partial>\r\n\r\n<hr>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
 foreach (GamePost post in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"card shadow rounded mx-auto w-75 mb-3\">\r\n    <h4 class=\"card-title text-center bg-dark text-light py-2 rounded-top\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38bbde27f241d7ffe20474888b0e98161568989f6383", async() => {
#nullable restore
#line 16 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
                                                                                        Write(post.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
                                                               WriteLiteral(post.GamePostId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </h4>\r\n\r\n    <div class=\"card-body\">\r\n      <p class=\"card-text\">\r\n        ");
#nullable restore
#line 21 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
   Write(post.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </p>\r\n      <small class=\"text-muted\">\r\n        Submited by ");
#nullable restore
#line 24 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
               Write(post.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" on: ");
#nullable restore
#line 24 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
                                     Write(post.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </small>\r\n    </div>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
     if (post.ImgUrl != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <img");
            BeginWriteAttribute("src", " src=\"", 748, "\"", 766, 1);
#nullable restore
#line 30 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
WriteAttributeValue("", 754, post.ImgUrl, 754, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"related to post.\" class=\"card-img-bottom\">\r\n");
#nullable restore
#line 31 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </div>\r\n");
#nullable restore
#line 34 "C:\Users\speed\Desktop\Coding_Dojo\c_stack\CSharpProject\Views\GamePosts\All.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GamePost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
