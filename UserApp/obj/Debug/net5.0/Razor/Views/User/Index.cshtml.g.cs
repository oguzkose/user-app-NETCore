#pragma checksum "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705def18bb31dcdc5d884f2db4cd6edb66b19ba7"
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
#line 1 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\_ViewImports.cshtml"
using UserApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\_ViewImports.cshtml"
using UserApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705def18bb31dcdc5d884f2db4cd6edb66b19ba7", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e34c925b69d60b81f4781e86e696c35aaaca0e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-1""><h3>Sıra No</h3></div>
        <div class=""col-md-2""><h3>Adı</h3></div>
        <div class=""col-md-2""><h3>Soyadı</h3></div>
        <div class=""col-md-2""><h3>Doğum Tarihi</h3></div>
        <div class=""col-md-3""><h3>GitHub Hesabı</h3></div>
        <div class=""col-md-2""><a class=""btn btn-primary"" href=""User/Add"">Yeni kullanıcı</a></div>
    </div>
    <br />
");
#nullable restore
#line 17 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Index.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-1\"><p>");
#nullable restore
#line 20 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Index.cshtml"
                                Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n            <div class=\"col-md-2\"><p>");
#nullable restore
#line 21 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Index.cshtml"
                                Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n            <div class=\"col-md-2\"><p>");
#nullable restore
#line 22 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Index.cshtml"
                                Write(user.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n            <div class=\"col-md-2\"><p>");
#nullable restore
#line 23 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Index.cshtml"
                                Write(user.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n            <div class=\"col-md-3\"><p>");
#nullable restore
#line 24 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Index.cshtml"
                                Write(user.GitHubAccountUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n            <div class=\"col-md-1\"><a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 972, "\"", 1003, 2);
            WriteAttributeValue("", 979, "User/GetUser?id=", 979, 16, true);
#nullable restore
#line 25 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Index.cshtml"
WriteAttributeValue("", 995, user.Id, 995, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detay</a></div>\r\n            <div class=\"col-md-1\"><a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1079, "\"", 1107, 2);
            WriteAttributeValue("", 1086, "User/Edit?id=", 1086, 13, true);
#nullable restore
#line 26 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Index.cshtml"
WriteAttributeValue("", 1099, user.Id, 1099, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Düzenle</a></div>\r\n        </div>\r\n        <br />\r\n");
#nullable restore
#line 29 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591