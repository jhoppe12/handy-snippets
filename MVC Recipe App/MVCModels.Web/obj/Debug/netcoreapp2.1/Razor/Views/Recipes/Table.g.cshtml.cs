#pragma checksum "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29237ad9bb6200ab2492593d4fb9c1f8af22178b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Table), @"mvc.1.0.view", @"/Views/Recipes/Table.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipes/Table.cshtml", typeof(AspNetCore.Views_Recipes_Table))]
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
#line 1 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\_ViewImports.cshtml"
using MVCModels.Web;

#line default
#line hidden
#line 2 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\_ViewImports.cshtml"
using MVCModels.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29237ad9bb6200ab2492593d4fb9c1f8af22178b", @"/Views/Recipes/Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baed38cd1fe7e90ae4c16f8cab34854d69aa394e", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipes_Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCModels.Web.Models.Recipe>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("clickPicture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Dish"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("star-rating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
  
    ViewData["Title"] = "Recipe Listing";

#line default
#line hidden
            BeginContext(101, 47, true);
            WriteLiteral("\r\n<h2>All Recipes</h2>\r\n<div class=\"table\">\r\n\r\n");
            EndContext();
#line 10 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
      double stars = 0;
        int count = 0;

#line default
#line hidden
            BeginContext(198, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(241, 26, true);
            WriteLiteral("        <div id=\"label\">\r\n");
            EndContext();
#line 16 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
             if (count == 0)
            {

#line default
#line hidden
            BeginContext(312, 233, true);
            WriteLiteral("                <p id=\"label\">\r\n                    Name <br />\r\n                    Type <br />\r\n                    Cook Time <br />\r\n                    Ingredients <br />\r\n                    Rating <br />\r\n                </p>\r\n");
            EndContext();
#line 25 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"

            }

#line default
#line hidden
            BeginContext(562, 59, true);
            WriteLiteral("        </div>\r\n        <div id=\"table_name\">\r\n            ");
            EndContext();
            BeginContext(621, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faede7b0cc2c4a8d9592452debde698e", async() => {
                BeginContext(693, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(711, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fc2975dbdcb5435e8bb36d41d66b57d0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 739, "~/images/", 739, 9, true);
#line 30 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
AddHtmlAttributeValue("", 748, item.ImageName, 748, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(778, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(796, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
              stars = Math.Ceiling(item.AverageRating);

#line default
#line hidden
            BeginContext(856, 61, true);
            WriteLiteral("\r\n            <table>\r\n                <tr id=\"overflow\"><td>");
            EndContext();
            BeginContext(918, 39, false);
#line 35 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(957, 84, true);
            WriteLiteral("</td></tr>\r\n                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1042, 45, false);
#line 38 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RecipeType));

#line default
#line hidden
            EndContext();
            BeginContext(1087, 124, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1212, 52, false);
#line 43 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CookTimeInMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 128, true);
            WriteLiteral(" min\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1393, 52, false);
#line 48 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ingredients.Count));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 136, true);
            WriteLiteral(" ingredients\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1581, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ab3ea4d962e4b5089352d8df6b46c0f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1611, "~/images/", 1611, 9, true);
#line 53 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
AddHtmlAttributeValue("", 1620, stars, 1620, 6, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1626, "-star.png", 1626, 9, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1639, 90, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
#line 58 "C:\Users\jhoppe\team0-c-sharp-week7-pair-exercise\m3-04-views-part2-exercises-pair\MVCModels.Web\Views\Recipes\Table.cshtml"
        count++;
    }

#line default
#line hidden
            BeginContext(1754, 32, true);
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCModels.Web.Models.Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591