#pragma checksum "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "456ae4069ee36e8301c0eb39b27c58c035871891"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Index), @"mvc.1.0.view", @"/Views/Actors/Index.cshtml")]
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
#line 1 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\_ViewImports.cshtml"
using OnlineTicketsMovieManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\_ViewImports.cshtml"
using OnlineTicketsMovieManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"456ae4069ee36e8301c0eb39b27c58c035871891", @"/Views/Actors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b25191ba79aca2eb3c4273d216a7c10c7963ac3c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Actors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Actor>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
  
    ViewData["Title"] = "List of Actors";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-8 offset-md-2\">\n        <table class=\"table\">\n            <thead>\n                <tr class=\"text-center\">\n                    <th>");
#nullable restore
#line 14 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProfilePictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>\n                        Full Name\n");
            WriteLiteral("                    </th>\n                    <th>");
#nullable restore
#line 20 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n");
#nullable restore
#line 21 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>Actions</th>\n");
#nullable restore
#line 24 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 29 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
                  
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td class=\"align-middle\">\n                                <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 1086, "\"", 1115, 1);
#nullable restore
#line 34 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
WriteAttributeValue("", 1092, item.ProfilePictureURL, 1092, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1116, "\"", 1146, 2);
#nullable restore
#line 34 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
WriteAttributeValue("", 1122, item.Name, 1122, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
WriteAttributeValue(" ", 1132, item.Surname, 1133, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\n                            </td>\n                            <td class=\"align-middle\">\n                                ");
#nullable restore
#line 37 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 38 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td class=\"align-middle\">\n                                ");
#nullable restore
#line 41 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n");
#nullable restore
#line 43 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
                             if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"align-middle\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456ae4069ee36e8301c0eb39b27c58c03587189110376", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>Edit");
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
#line 46 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
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
            WriteLiteral(" |\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456ae4069ee36e8301c0eb39b27c58c03587189112742", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-eye\"></i>Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
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
            WriteLiteral(" |\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "456ae4069ee36e8301c0eb39b27c58c03587189115108", async() => {
                WriteLiteral("<i class=\"bi bi-trash\"></i>Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
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
            WriteLiteral("\n\n                                </td>\n");
#nullable restore
#line 51 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\n");
#nullable restore
#line 53 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n\n\n");
            WriteLiteral("\n");
#nullable restore
#line 67 "D:\ASP.net-CORE_MVC\GIT\Repository\OnlineTicketsMovieManagement\Views\Actors\Index.cshtml"
Write(await Html.PartialAsync("_CreateItem", "Actors"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Actor>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
