#pragma checksum "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c26f391bad1598190a550f9c1b0d76c99a407025"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.Webchart.Pages_Webchart_Index), @"mvc.1.0.razor-page", @"/Pages/Webchart/Index.cshtml")]
namespace RazorPagesMovie.Pages.Webchart
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\_ViewImports.cshtml"
using RazorPagesMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c26f391bad1598190a550f9c1b0d76c99a407025", @"/Pages/Webchart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bffd98f02597e6a09295a2131188dc64093be78", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Webchart_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
    
    var XLabelsmer = Newtonsoft.Json.JsonConvert.SerializeObject( Model.lstModelmerchat.Select( x => x.DimensionOne ).ToList() );  
    var YValuesmer = Newtonsoft.Json.JsonConvert.SerializeObject( Model.lstModelmerchat.Select( x => x.Quantity ).ToList() );  
    
     var XLabelsgeo = Newtonsoft.Json.JsonConvert.SerializeObject( Model.lstModelgeopagos.Select( x => x.DimensionOne ).ToList() );  
    var YValuesgeo = Newtonsoft.Json.JsonConvert.SerializeObject( Model.lstModelgeopagos.Select( x => x.Quantity ).ToList() );  
    
     var XLabelslog = Newtonsoft.Json.JsonConvert.SerializeObject( Model.lstModellogope.Select( x => x.Operacion ).ToList() );  
    var YValueslog = Newtonsoft.Json.JsonConvert.SerializeObject( Model.lstModellogope.Select( x => x.Cant_trx ).ToList() );  
    
    
    ViewData["Title"] = "Bar Chart"; 
   


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>



  <div class=""box-body"">    
        <div class=""chart-container"">  
            <canvas id=""chartmer"" style=""width:50%; height:500px""></canvas>  
        </div>  
  </div>  

   <div class=""box-body"">    
        <div class=""chart-container"">  
            <canvas id=""chartgeo"" style=""width:50%; height:500px""></canvas>  
        </div>  
  </div>  

   <div class=""box-body"">    
        <div class=""chart-container"">  
            <canvas id=""chartlog"" style=""width:50%; height:500px""></canvas>  
        </div>  
  </div>  





  <div class=""row"">
    <div class=""col"">
      Dimensiones
    </div>
     <div class=""col"">
      Cantidad
    </div>
  </div>

");
#nullable restore
#line 56 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
  foreach (var item in Model.lstModellogope) 
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <div class=\"row\">   \r\n          <div class=\"col\">\r\n              ");
#nullable restore
#line 60 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
         Write(Html.DisplayFor(modelItem => item.Operacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </div>\r\n          <div class=\"col\">\r\n              ");
#nullable restore
#line 63 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
         Write(Html.DisplayFor(modelItem => item.Cant_trx));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </div>       \r\n      </div>\r\n");
#nullable restore
#line 66 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
 }  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>



<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.bundle.min.js""></script>  
<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>  



<script type=""text/javascript"">  

  

$(function () {  
        var chartName = ""chartmer"";  
        var ctx = document.getElementById(chartName).getContext('2d');  
        var data = {  
                labels: ");
#nullable restore
#line 85 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
                   Write(Html.Raw(XLabelsmer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",  
                datasets: [{  
                    label: ""Transacciones de Merchant"",  
                    backgroundColor: [  
                        'rgba(255, 99, 132, 0.2)',  
                        'rgba(54, 162, 235, 0.2)',  
                        'rgba(255, 206, 86, 0.2)',  
                        'rgba(75, 192, 192, 0.2)',  
                        'rgba(153, 102, 255, 0.2)',  
                        'rgba(255, 159, 64, 0.2)',  
                        'rgba(255, 0, 0)',  
                        'rgba(0, 255, 0)',  
                        'rgba(0, 0, 255)',  
                        'rgba(192, 192, 192)',  
                        'rgba(255, 255, 0)',  
                        'rgba(255, 0, 255)'  
                    ],  
                    borderColor: [  
                        'rgba(255,99,132,1)',  
                        'rgba(54, 162, 235, 1)',  
                        'rgba(255, 206, 86, 1)',  
                        'rgba(75, 192, 192, 1)',  
         ");
            WriteLiteral(@"               'rgba(153, 102, 255, 1)',  
                        'rgba(255, 159, 64, 1)',  
                        'rgba(255, 0, 0)',  
                        'rgba(0, 255, 0)',  
                        'rgba(0, 0, 255)',  
                        'rgba(192, 192, 192)',  
                        'rgba(255, 255, 0)',  
                        'rgba(255, 0, 255)'  
                    ],  
                    borderWidth: 1,  
                    data: ");
#nullable restore
#line 117 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
                     Write(Html.Raw(YValuesmer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
                            }]  
            };  
  
var options = {  
                maintainAspectRatio: false,  
                scales: {  
                    yAxes: [{  
                        ticks: {  
                            min: 0,  
                            beginAtZero: true  
                        },  
                        gridLines: {  
                            display: true,  
                            color: ""rgba(255,99,164,0.2)""  
                        }  
                            }],  
                    xAxes: [{  
                        ticks: {  
                            min: 0,  
                            beginAtZero: true  
                        },  
                        gridLines: {  
                            display: false  
                        }  
                    }]  
                }  
            };  
  
       var myChart = new  Chart(ctx, {  
                options: options,  
                data:");
            WriteLiteral(" data,  \r\n                type:\'bar\'  \r\n  \r\n            });  \r\n      \r\n\r\n\r\n\r\n\r\n\r\n        var chartName = \"chartgeo\";  \r\n        var ctx = document.getElementById(chartName).getContext(\'2d\');  \r\n        var data = {  \r\n                labels: ");
#nullable restore
#line 161 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
                   Write(Html.Raw(XLabelsgeo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",  
                datasets: [{  
                    label: ""Transacciones de Geopagos"",  
                    backgroundColor: [  
                        'rgba(255, 99, 132, 0.2)',  
                        'rgba(54, 162, 235, 0.2)',  
                        'rgba(255, 206, 86, 0.2)',  
                        'rgba(75, 192, 192, 0.2)',  
                        'rgba(153, 102, 255, 0.2)',  
                        'rgba(255, 159, 64, 0.2)',  
                        'rgba(255, 0, 0)',  
                        'rgba(0, 255, 0)',  
                        'rgba(0, 0, 255)',  
                        'rgba(192, 192, 192)',  
                        'rgba(255, 255, 0)',  
                        'rgba(255, 0, 255)'  
                    ],  
                    borderColor: [  
                        'rgba(255,99,132,1)',  
                        'rgba(54, 162, 235, 1)',  
                        'rgba(255, 206, 86, 1)',  
                        'rgba(75, 192, 192, 1)',  
         ");
            WriteLiteral(@"               'rgba(153, 102, 255, 1)',  
                        'rgba(255, 159, 64, 1)',  
                        'rgba(255, 0, 0)',  
                        'rgba(0, 255, 0)',  
                        'rgba(0, 0, 255)',  
                        'rgba(192, 192, 192)',  
                        'rgba(255, 255, 0)',  
                        'rgba(255, 0, 255)'  
                    ],  
                    borderWidth: 1,  
                    data: ");
#nullable restore
#line 193 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
                     Write(Html.Raw(YValuesgeo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
    }]  
            };  
  
var options = {  
                maintainAspectRatio: false,  
                scales: {  
                    yAxes: [{  
                        ticks: {  
                            min: 0,  
                            beginAtZero: true  
                        },  
                        gridLines: {  
                            display: true,  
                            color: ""rgba(255,99,164,0.2)""  
                        }  
                            }],  
                    xAxes: [{  
                        ticks: {  
                            min: 0,  
                            beginAtZero: true  
                        },  
                        gridLines: {  
                            display: false  
                        }  
                    }]  
                }  
            };  
  
       var myChart = new  Chart(ctx, {  
                options: options,  
                data: data,  
              ");
            WriteLiteral("  type:\'bar\'  \r\n  \r\n            });  \r\n\r\n\r\n\r\n\r\n\r\n              var chartName = \"chartlog\";  \r\n        var ctx = document.getElementById(chartName).getContext(\'2d\');  \r\n        var data = {  \r\n                labels: ");
#nullable restore
#line 236 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
                   Write(Html.Raw(XLabelslog));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",  
                datasets: [{  
                    label: ""Log Operaciones Flow"",  
                    backgroundColor: [  
                        'rgba(255, 99, 132, 0.2)',  
                        'rgba(54, 162, 235, 0.2)',  
                        'rgba(255, 206, 86, 0.2)',  
                        'rgba(75, 192, 192, 0.2)',  
                        'rgba(153, 102, 255, 0.2)',  
                        'rgba(255, 159, 64, 0.2)',  
                        'rgba(255, 0, 0)',  
                        'rgba(0, 255, 0)',  
                        'rgba(0, 0, 255)',  
                        'rgba(192, 192, 192)',  
                        'rgba(255, 255, 0)',  
                        'rgba(255, 0, 255)'  
                    ],  
                    borderColor: [  
                        'rgba(255,99,132,1)',  
                        'rgba(54, 162, 235, 1)',  
                        'rgba(255, 206, 86, 1)',  
                        'rgba(75, 192, 192, 1)',  
              ");
            WriteLiteral(@"          'rgba(153, 102, 255, 1)',  
                        'rgba(255, 159, 64, 1)',  
                        'rgba(255, 0, 0)',  
                        'rgba(0, 255, 0)',  
                        'rgba(0, 0, 255)',  
                        'rgba(192, 192, 192)',  
                        'rgba(255, 255, 0)',  
                        'rgba(255, 0, 255)'  
                    ],  
                    borderWidth: 1,  
                    data: ");
#nullable restore
#line 268 "E:\_Karlos\pruebas\RazorPagesMovie\Pages\Webchart\Index.cshtml"
                     Write(Html.Raw(YValueslog));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
    }]  
            };  
  
var options = {  
                maintainAspectRatio: false,  
                scales: {  
                    yAxes: [{  
                        ticks: {  
                            min: 0,  
                            beginAtZero: true  
                        },  
                        gridLines: {  
                            display: true,  
                            color: ""rgba(255,99,164,0.2)""  
                        }  
                            }],  
                    xAxes: [{  
                        ticks: {  
                            min: 0,  
                            beginAtZero: true  
                        },  
                        gridLines: {  
                            display: false  
                        }  
                    }]  
                }  
            };  
  
       var myChart = new  Chart(ctx, {  
                options: options,  
                data: data,  
              ");
            WriteLiteral("  type:\'bar\'  \r\n  \r\n            }); \r\n\r\n\r\n\r\n       \r\n});\r\n</script>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.Webchart.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.Webchart.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.Webchart.IndexModel>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.Webchart.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
