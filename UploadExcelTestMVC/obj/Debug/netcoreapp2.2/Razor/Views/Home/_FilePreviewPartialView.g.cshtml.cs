#pragma checksum "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3418c844666dbe0ab5bde29ef1b9b2c4201cc54c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__FilePreviewPartialView), @"mvc.1.0.view", @"/Views/Home/_FilePreviewPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_FilePreviewPartialView.cshtml", typeof(AspNetCore.Views_Home__FilePreviewPartialView))]
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
#line 1 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\_ViewImports.cshtml"
using UploadExcelTestMVC;

#line default
#line hidden
#line 1 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
using UploadExcelTestMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3418c844666dbe0ab5bde29ef1b9b2c4201cc54c", @"/Views/Home/_FilePreviewPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c548c1fd0d2864d163668e30df02baa194a5aed5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__FilePreviewPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HoursLogTableTemp>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
 if (@Model != null)
{

#line default
#line hidden
            BeginContext(93, 286, true);
            WriteLiteral(@"    <table class=""table table-responsive table-bordered ks-table"" id=""table"" style=""width:100%; border:0; border-spacing:0; border-color:red;"" cellpadding=""0"" cellspacing=""0"">
        <thead class=""container"">
            <tr id=""tableHeader"" class=""handle"" style=""cursor:pointer;"">
");
            EndContext();
            BeginContext(875, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 24 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                 for (var col = 1; col <= @GetColCount(Model); col++)
                {

#line default
#line hidden
            BeginContext(965, 56, true);
            WriteLiteral("                    <th style=\"background:transparent;\">");
            EndContext();
            BeginContext(1022, 3, false);
#line 26 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                                                   Write(col);

#line default
#line hidden
            EndContext();
            BeginContext(1025, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 27 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                }

#line default
#line hidden
            BeginContext(1051, 67, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody id=\"divData\">\r\n");
            EndContext();
#line 31 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
             foreach (var row in Model)
            {
                if (row.RowID > 5)
                {

#line default
#line hidden
            BeginContext(1229, 23, true);
            WriteLiteral("                    <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1252, "\"", 1267, 1);
#line 35 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
WriteAttributeValue("", 1257, row.RowID, 1257, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1268, 25, true);
            WriteLiteral(" style=\"display:none;\">\r\n");
            EndContext();
#line 36 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                         foreach (var col in row.RowData)
                        {

#line default
#line hidden
            BeginContext(1379, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1412, 3, false);
#line 38 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                           Write(col);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 39 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                        }

#line default
#line hidden
            BeginContext(1449, 27, true);
            WriteLiteral("                    </tr>\r\n");
            EndContext();
#line 41 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1536, 23, true);
            WriteLiteral("                    <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1559, "\"", 1574, 1);
#line 44 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
WriteAttributeValue("", 1564, row.RowID, 1564, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1575, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(1943, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 60 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                         for (var i = 0; i < GetColCount(Model); i++)
                        {
                            var currentRowColCount = row.RowData.Count();

                            if (i < currentRowColCount)
                            {

#line default
#line hidden
            BeginContext(2208, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(2245, 14, false);
#line 66 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                               Write(row.RowData[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2259, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 67 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2362, 43, true);
            WriteLiteral("                                <td></td>\r\n");
            EndContext();
#line 71 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(2463, 27, true);
            WriteLiteral("                    </tr>\r\n");
            EndContext();
#line 74 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2524, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 78 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
}

#line default
#line hidden
            BeginContext(2559, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
#line 9 "C:\Users\Aca\source\repos\uploadtester\UploadExcelTestMVC\Views\Home\_FilePreviewPartialView.cshtml"
                           
                    int GetColCount(List<HoursLogTableTemp> Model)
                    {
                        var max = 0;

                        foreach (var row in Model)
                        {
                            var temp = row.RowData.Count;
                            if (temp > max)
                                max = temp;
                        }

                        return max;
                    }
                

#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HoursLogTableTemp>> Html { get; private set; }
    }
}
#pragma warning restore 1591
