#pragma checksum "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1e5edb83bd1a2f94cac96836157b2394d9146d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\_ViewImports.cshtml"
using LoginAuthenticationWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\_ViewImports.cshtml"
using LoginAuthenticationWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1e5edb83bd1a2f94cac96836157b2394d9146d4", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"423fb7695ea3f453310c528c5c660a943fdbc110", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.User>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<table class=""table table-striped"" style=""width:400px"">

    <theead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Surname
            </th>
            <th>
                Email
            </th>
            <th>
                Role
            </th>
            <th>
                Password
            </th>
            <th scope=""col"">Sil</th>
            <th scope=""col"">Güncelle</th>

        </tr>
    </theead>
    <tbody>

");
#nullable restore
#line 33 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\User\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\User\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\User\Index.cshtml"
               Write(item.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\User\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\User\Index.cshtml"
               Write(item.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\User\Index.cshtml"
               Write(item.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\User\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\User\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Burak\source\repos\LoginAuthentication\LoginAuthenticationWeb\Views\User\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
