#pragma checksum "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8474c5355efa23a625e4f981f8c95d5d3d358ad7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Add), @"mvc.1.0.view", @"/Views/User/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8474c5355efa23a625e4f981f8c95d5d3d358ad7", @"/Views/User/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e34c925b69d60b81f4781e86e696c35aaaca0e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
  
    ViewData["Title"] = "Add";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Add</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
 using (Html.BeginForm(FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" container\">\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.LabelFor(x => x.Id, null, new { @class = "col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 12 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Id, null, new { @class = "col-md-3", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.ValidationMessageFor(x => x.Id, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.LabelFor(x => x.Name, null, new { @class = "col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Name, null, new { @class = "col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.ValidationMessageFor(x => x.Name, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.LabelFor(x => x.Surname, null, new { @class = "col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Surname, null, new { @class = "col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.ValidationMessageFor(x => x.Surname, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.LabelFor(x => x.BirthDate, null, new { @class = "col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.TextBoxFor(x => x.BirthDate, null, new { @class = "col-md-3 ", type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 31 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.ValidationMessageFor(x => x.BirthDate, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.LabelFor(x => x.Email, null, new { @class = "col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 36 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Email, null, new { @class = "col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.ValidationMessageFor(x => x.Email, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.LabelFor(x => x.Gender, null, new { @class = "col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 42 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.DropDownListFor(x => x.Gender, (SelectListItem[])ViewBag.GenderList, new { @class = "col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 43 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.ValidationMessageFor(x => x.Gender, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.LabelFor(x => x.GitHubAccountUrl, null, new { @class = "col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 48 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.TextBoxFor(x => x.GitHubAccountUrl, null, new { @class = "col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 49 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
       Write(Html.ValidationMessageFor(x => x.GitHubAccountUrl, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div><button class=\"btn btn-primary\" type=\"submit\">Ekle</button></div>\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Users\Oğuz KÖSE\source\repos\UserApp\UserApp\Views\User\Add.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
