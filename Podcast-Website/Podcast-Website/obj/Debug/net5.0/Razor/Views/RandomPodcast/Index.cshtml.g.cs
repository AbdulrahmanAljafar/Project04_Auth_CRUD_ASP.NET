#pragma checksum "C:\Users\abdul\OneDrive\سطح المكتب\C#2\Project04_Auth_CRUD_ASP.NET\Podcast-Website\Podcast-Website\Views\RandomPodcast\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "578f0f3d8929a4d0bd77cf9a82c69d20a20b8d11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RandomPodcast_Index), @"mvc.1.0.view", @"/Views/RandomPodcast/Index.cshtml")]
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
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\C#2\Project04_Auth_CRUD_ASP.NET\Podcast-Website\Podcast-Website\Views\_ViewImports.cshtml"
using Podcast_Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\OneDrive\سطح المكتب\C#2\Project04_Auth_CRUD_ASP.NET\Podcast-Website\Podcast-Website\Views\_ViewImports.cshtml"
using Podcast_Website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578f0f3d8929a4d0bd77cf9a82c69d20a20b8d11", @"/Views/RandomPodcast/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7334eb8152466ae1176bf868be320ee1c3511f38", @"/Views/_ViewImports.cshtml")]
    public class Views_RandomPodcast_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\C#2\Project04_Auth_CRUD_ASP.NET\Podcast-Website\Podcast-Website\Views\RandomPodcast\Index.cshtml"
   
    var dataString = (string)ViewData["dataString"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function type3(){
        console.log(""cdjndjskn"");
        var p = document.getElementById(""dataString"");
        var data = document.getElementById(""dataString"").innerHTML;

        let jsonData = JSON.parse(data);
        console.log(jsonData);

        document.getElementById(""mainRandomPodcasr"").removeAttribute(""hidden"");
        document.getElementById(""mainpageRandom"").style.display = ""none"";
        document.getElementById(""buttonRandom"").innerHTML = ""Another Random Podcast <i class=\""fas fa - random\""></i>"";
        document.getElementById(""buttonRandom"").style.width = """";
        document.getElementById(""buttonRandom"").style.marginLeft = ""0"";
        document.getElementById(""buttondiv"").style.left = ""6px"";
        document.getElementById(""buttondiv"").style.top = ""100px"";

        var randomIndex = Math.floor(Math.random() * jsonData.items.length)

        document.getElementById(""imgRandom"").src = jsonData.items[randomIndex].image

        document.getElementById(");
            WriteLiteral(@"""headerR"").innerHTML = jsonData.items[randomIndex].title

        document.getElementById(""aud"").src = jsonData.items[randomIndex].enclosureUrl
        console.log(document.getElementById(""imgRandom"").src)
        

        

        function htmlDecode(input) {
            var e = document.createElement('div');
            e.innerHTML = input;
            return e.childNodes[0].nodeValue;
        }

        document.getElementById(""pR"").innerHTML = htmlDecode(jsonData.items[randomIndex].description)

    }
</script>

<p id=""dataString"" onclick=""aaa()"" style=""display:none"">");
#nullable restore
#line 45 "C:\Users\abdul\OneDrive\سطح المكتب\C#2\Project04_Auth_CRUD_ASP.NET\Podcast-Website\Podcast-Website\Views\RandomPodcast\Index.cshtml"
                                                   Write(dataString);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>



<div class=""container"" id=""mainpageRandom"">
    <div class=""row"">
        <div class=""col"" >
            <img src=""https://pcfeatures.wpengine.com/wp-content/uploads/2021/02/computer@2x.png"" width=""550"" id=""imgR"" alt=""Not Found"" />
        </div>
        <div class=""col"">
            <h1 style=""margin-top:100px"">Random <span style=""color: #ffce61"">Podcast</span>  Generator</h1>
            <h6 style="" opacity: 0.7; color: #93939f; margin-top: 50px;"">To get a random podcast simply click the red generate button </h6>
            
        </div>
    </div>
 </div>
<div id=""buttondiv"" style=""position: fixed;left:63%; top:50%;background: white; "">
    <button style=""width:300px;margin-left:-100px"" id=""buttonRandom"" onclick=""type3()"" type=""button"" class=""btn btn-outline-warning"">Generate <i class=""fas fa-random""></i></button>
</div>

    <div id=""mainRandomPodcasr"" class=""container overflow-hidden"" hidden>
        <div class=""row gx-5"">
            <div class=""col"">
                <d");
            WriteLiteral("iv class=\"p-3  \">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2763, "\"", 2769, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""max-width:500px"" id=""imgRandom"" alt=""Not Found"" />
                </div>
            </div>
            <div class=""col"">
                <div class=""p-3 "" style=""margin-top:50px"">
                    <h2 style=""color: #ffce61;opacity: 0.85"" id=""headerR""></h2>


                    <audio controls style="" width: 450px;margin-top:20px"" id=""aud"">

                       
                    </audio>
                    <br /><br />

                    <br />
                    <h5>Description : </h5>
                    <div id=""pR""></div>


                </div>
            </div>
        </div>
    </div>



");
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
