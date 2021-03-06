#pragma checksum "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65fb18036ece244b512ce2a370d2b33bffdbe241"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Favourite_Favourite), @"mvc.1.0.view", @"/Views/Favourite/Favourite.cshtml")]
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
#line 1 "E:\repoAPI\repoAPI\Views\_ViewImports.cshtml"
using repoAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\repoAPI\repoAPI\Views\_ViewImports.cshtml"
using repoAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65fb18036ece244b512ce2a370d2b33bffdbe241", @"/Views/Favourite/Favourite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afa801ef1c3b044428bb784c31e64873fb6f994", @"/Views/_ViewImports.cshtml")]
    public class Views_Favourite_Favourite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Repository>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
  
    ViewData["Title"] = "Favoritos - ";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 101, "\"", 144, 1);
#nullable restore
#line 6 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
WriteAttributeValue("", 108, Url.Content("~/css/repository.css"), 108, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n");
            }
            );
            WriteLiteral("    <div class=\"repositories\">\r\n");
#nullable restore
#line 9 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
           int i = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
         foreach (var repository in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <div class=\"title\">\r\n                    <button class=\"name\" id=\"namebtn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 420, "\"", 463, 3);
            WriteAttributeValue("", 430, "more_information(", 430, 17, true);
#nullable restore
#line 14 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
WriteAttributeValue("", 447, i.ToString(), 447, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 462, ")", 462, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                                                                                             Write(repository.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("id", " id=\"", 533, "\"", 567, 1);
#nullable restore
#line 15 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
WriteAttributeValue("", 538, "starbtn-" + repository.Id, 538, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"starbtn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 584, "\"", 639, 3);
            WriteAttributeValue("", 594, "add_favourite(", 594, 14, true);
#nullable restore
#line 15 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
WriteAttributeValue("", 608, "\'" + repository.Id + "\'", 608, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 638, ")", 638, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 16 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                         if (repository.Favourite)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("id", " id=\"", 754, "\"", 785, 1);
#nullable restore
#line 18 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
WriteAttributeValue("", 759, "star-" + repository.Id, 759, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"star-true\" />\r\n");
#nullable restore
#line 19 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("id", " id=\"", 925, "\"", 956, 1);
#nullable restore
#line 22 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
WriteAttributeValue("", 930, "star-" + repository.Id, 930, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"star-false\" />\r\n");
#nullable restore
#line 23 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </button>\r\n                </div>\r\n                <text class=\"fullname\">");
#nullable restore
#line 26 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                                  Write(repository.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n\r\n                <div class=\"description\"");
            BeginWriteAttribute("id", " id=\"", 1173, "\"", 1209, 1);
#nullable restore
#line 28 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
WriteAttributeValue("", 1178, "description" + i.ToString(), 1178, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"line\"></div>\r\n                    <text class=\"desc\">");
#nullable restore
#line 30 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                                  Write(repository.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n                    <div class=\"details\">\r\n                        <div class=\"lastupdate\">\r\n                            <text class=\"title\">Última atualização:</text>\r\n                            <text class=\"info\">");
#nullable restore
#line 34 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                                          Write(repository.Lastupdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n                        </div>\r\n                        <div class=\"language\">\r\n                            <text class=\"title\">Linguagem:</text>\r\n                            <text class=\"info\">");
#nullable restore
#line 38 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                                          Write(repository.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n                        </div>\r\n                        <div class=\"owner\">\r\n                            <text class=\"title\">Dono do Repositório:</text>\r\n                            <text class=\"info\">");
#nullable restore
#line 42 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                                          Write(repository.Owner.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"contributors\">\r\n                        <text class=\"title\">Contribuidores:</text>\r\n                        <ul>\r\n");
#nullable restore
#line 48 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                             foreach (var contributor in repository.Contribuitors)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 50 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                               Write(contributor.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 51 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 56 "E:\repoAPI\repoAPI\Views\Favourite\Favourite.cshtml"
            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Repository>> Html { get; private set; }
    }
}
#pragma warning restore 1591
