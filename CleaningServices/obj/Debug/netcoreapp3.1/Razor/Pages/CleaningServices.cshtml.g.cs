#pragma checksum "/home/codespace/workspace/CleanerService/CleaningServices/Pages/CleaningServices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "110cfc1208eac9bb4a7f0823f70ab9da384243c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CleaningServices.Pages.Pages_CleaningServices), @"mvc.1.0.razor-page", @"/Pages/CleaningServices.cshtml")]
namespace CleaningServices.Pages
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
#line 1 "/home/codespace/workspace/CleanerService/CleaningServices/Pages/_ViewImports.cshtml"
using CleaningServices;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"110cfc1208eac9bb4a7f0823f70ab9da384243c0", @"/Pages/CleaningServices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4fb52837122fdb14ce55d85fb55e2477fd9f94", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CleaningServices : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/codespace/workspace/CleanerService/CleaningServices/Pages/CleaningServices.cshtml"
  
    ViewData["Title"] = "Cleaning Services";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "/home/codespace/workspace/CleanerService/CleaningServices/Pages/CleaningServices.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p>Use this page to detail your site\'s Cleaning Services.</p>\n\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110cfc1208eac9bb4a7f0823f70ab9da384243c03565", async() => {
                WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<style>
* {
  box-sizing: border-box;
}

/* Create two equal columns that floats next to each other */
.column {
  float: left;
  width: 50%;
  padding: 10px;
}

/* Clear floats after the columns */
.row:after {
  content: """";
  display: table;
  clear: both;
}
/* Style the buttons */
.btn {
  border: none;
  outline: none;
  padding: 12px 16px;
  background-color: #f1f1f1;
  cursor: pointer;
}

.btn:hover {
  background-color: #ddd;
}

.btn.active {
  background-color: #666;
  color: white;
}
</style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110cfc1208eac9bb4a7f0823f70ab9da384243c05141", async() => {
                WriteLiteral(@"

<h2>List View or Grid View</h2>

<p>Click on a button to choose list view or grid view.</p>

<div id=""btnContainer"">
  <button class=""btn"" onclick=""listView()""><i class=""fa fa-bars""></i> List</button> 
  <button class=""btn active"" onclick=""gridView()""><i class=""fa fa-th-large""></i> Grid</button>
</div>
<br>

<div class=""row"">
  <div class=""column"" style=""background-color:#aaa;"">
    <h2>Column 1</h2>
    <p>Some text..</p>
  </div>
  <div class=""column"" style=""background-color:#bbb;"">
    <h2>Column 2</h2>
    <p>Some text..</p>
  </div>
  <div class=""column"" style=""background-color:red;"">
    <h2>Column 3</h2>
    <p>Some text..</p>
  </div>
  <div class=""column"" style=""background-color:red;"">
    <h2>Column 4</h2>
    <p>Some text..</p>
  </div>
</div>

<div class=""row"">
  <div class=""column"" style=""background-color:#ccc;"">
    <h2>Column 5</h2>
    <p>Some text..</p>
  </div>
  <div class=""column"" style=""background-color:#ddd;"">
    <h2>Column 6</h2>
    <p>Some text..</p>
  </div>
  <div class=""column"" ");
                WriteLiteral(@"style=""background-color:red;"">
    <h2>Column 7</h2>
    <p>Some text..</p>
  </div>
  <div class=""column"" style=""background-color:red;"">
    <h2>Column 8</h2>
    <p>Some text..</p>
  </div>
</div>

<script>
// Get the elements with class=""column""
var elements = document.getElementsByClassName(""column"");

// Declare a loop variable
var i;

// List View
function listView() {
  for (i = 0; i < elements.length; i++) {
    elements[i].style.width = ""100%"";
  }
}

// Grid View
function gridView() {
  for (i = 0; i < elements.length; i++) {
    elements[i].style.width = ""50%"";
  }
}

/* Optional: Add active class to the current button (highlight it) */
var container = document.getElementById(""btnContainer"");
var btns = container.getElementsByClassName(""btn"");
for (var i = 0; i < btns.length; i++) {
  btns[i].addEventListener(""click"", function() {
    var current = document.getElementsByClassName(""active"");
    current[0].className = current[0].className.replace("" active"", """");
    this.className += "" active"";
  })");
                WriteLiteral(";\n}\n</script>\n");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServicesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServicesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServicesModel>)PageContext?.ViewData;
        public ServicesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
