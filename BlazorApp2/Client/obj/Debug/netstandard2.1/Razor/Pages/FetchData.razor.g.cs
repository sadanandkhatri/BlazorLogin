#pragma checksum "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0592c1c12c1989cfc78aaab3b7a3adfa3d4e595c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp2.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using BlazorApp2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using BlazorApp2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
using BlazorApp2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(2, "<p>This component demonstrates fetching data from the server.</p>\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-inline");
            __builder.AddMarkupContent(5, "<label class=\"sr-only\" for=\"filter-name\">Search</label>\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control mb-2 mr-sm-2");
            __builder.AddAttribute(9, "placeholder", "Search");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                                                     searchfilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchfilter = __value, searchfilter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "btn btn-primary mr-sm-2 mb-2");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                                         Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "class", "btn btn-danger mb-2");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                                Clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Clear");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.AddMarkupContent(25, @"<style>
    .sort-th {
        cursor: pointer;
    }

    .fa {
        float: right;
    }
    .blazored-modal {
        height: auto;
        border: solid;
        border-color: black;
    }
    .blazored-modal-header{
        align-content:center;
    }
    .blazored-modal-title {
        align-content: center;
        text-align: center
    }
</style>");
#nullable restore
#line 43 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<p><em>Loading...</em></p>");
#nullable restore
#line 46 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "class", "table table-bordered table-hover");
            __builder.OpenElement(29, "thead");
            __builder.OpenElement(30, "tr");
            __builder.OpenElement(31, "th");
            __builder.AddAttribute(32, "class", "sort-th");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                () => SortTable("Date")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Date");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "th");
            __builder.AddAttribute(37, "class", "sort-th");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                () => SortTable("TemperatureC")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Temp. (C)");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "th");
            __builder.AddAttribute(42, "class", "sort-th");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                () => SortTable("TemperatureF")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Temp. (F)");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "th");
            __builder.AddAttribute(47, "class", "sort-th");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                () => SortTable("Summary")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Summary");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "tbody");
#nullable restore
#line 59 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
             foreach (var forecast in filterdata)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "tr");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 62 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 63 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 64 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "td");
#nullable restore
#line 67 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                         if (forecast.Summary.Length > 10)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                             for (int i = 0; i <= 10; i++)
                            {
                                

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, 
#nullable restore
#line 71 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                 forecast.Summary[i]

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 71 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                    ;
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "small");
            __builder.AddAttribute(66, "style", "font:100");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                ()=>showSummary(forecast.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "\r\n                                more\r\n                            ");
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, 
#nullable restore
#line 80 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                             forecast.Summary

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 80 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                             
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "pagination");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "class", "btn btn-custom");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                   ()=> NavigateToPage("previous")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "Prev");
            __builder.CloseElement();
#nullable restore
#line 90 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
         for (int i = startPage; i <= endPage; i++)
        {
            var currentPage = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "class", "btn" + " btn-custom" + " pagebutton" + " " + (
#nullable restore
#line 93 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                       currentPage==curPage?"btn-danger":""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                                                                          () => refreshRecords(currentPage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(80, 
#nullable restore
#line 94 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                 currentPage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 96 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "class", "btn btn-custom");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
                                                   ()=> NavigateToPage("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, "Next");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 99 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;
    private string searchfilter = string.Empty;
    private List<WeatherForecast> filterdata;
    private bool isSortedAscending;
    private string activeSortColumn;
    int totalPages;
    int totalRecords;
    int curPage;
    int pagerSize;
    int pageSize;
    int startPage;
    int endPage;
    

    void showSummary(int id)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(Summary.id), id);
        modal.Show<Summary>("Summary", parameters);
    }

    private void SortTable(string ColumnName)
    {
        if (ColumnName != activeSortColumn)
        {
            filterdata = filterdata.OrderBy(x =>
        x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList();
            isSortedAscending = true;
            activeSortColumn = ColumnName;
        }
        else
        {
            if (isSortedAscending)
            {
                filterdata = filterdata.OrderByDescending(x =>
        x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList();
            }
            else
            {
                filterdata = filterdata.OrderBy(x =>
        x.GetType().GetProperty(ColumnName).GetValue(x, null)).ToList();
            }
            isSortedAscending = !isSortedAscending;
        }


    }

    private string SetSortIcon(string columnName)
    {
        if (activeSortColumn != columnName)
        {
            return string.Empty;
        }
        if (isSortedAscending)
        {
            return "fa-sort-up";
        }
        else
        {
            return "fa-sort-down";
        }
    }

    protected override async Task OnInitializedAsync()
    {
        pagerSize = 4;
        pageSize = 5;
        curPage = 1;
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        this.filterdata = forecasts//.ToList();
           .Skip((curPage - 1) * pageSize).Take(pageSize).ToList();
        totalRecords =  forecasts.Count();
        totalPages = (int)Math.Ceiling(totalRecords / (decimal)pageSize);
        SetPagerSize("forward");
    }



    private void Clear()
    {
        this.searchfilter = string.Empty;
        this.filterdata = forecasts//.ToList();
           .Skip((curPage - 1) * pageSize).Take(pageSize).ToList();
        //Console.WriteLine(filterdata);
    }

    private void Filter()
    {
        toastService.ShowSuccess("Filtering Stared");
        //this.filterdata = forecasts.Where(x => x.Summary.Contains(searchfilter) || x.Date.ToString().Contains(searchfilter)
        //  || x.TemperatureC.ToString().Contains(searchfilter) || x.TemperatureF.ToString().Contains(searchfilter)).ToList();
        this.filterdata = Array.FindAll(forecasts, element => element.Summary.ToLower().Contains(searchfilter.ToLower())
        || element.TemperatureF.ToString().ToLower().Contains(searchfilter.ToLower())
        || element.TemperatureC.ToString().ToLower().Contains(searchfilter.ToLower())
        || element.Date.ToString().ToLower().Contains(searchfilter.ToLower())).ToList();

    }

    public  void refreshRecords(int currentPage)
    {
        filterdata = forecasts.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        curPage = currentPage;
        this.StateHasChanged();
    }

    public void SetPagerSize(string direction)
    {
        if (direction == "forward" && endPage < totalPages)
        {
            startPage = endPage + 1;
            if (endPage + pagerSize < totalPages)
            {
                endPage = startPage + pagerSize - 1;
            }
            else
            {
                endPage = totalPages;
            }
            this.StateHasChanged();
        }
        else if (direction == "back" && startPage > 1)
        {
            endPage = startPage - 1;
            startPage = startPage - pagerSize;
        }
    }

    public void NavigateToPage(string direction)
    {
        if (direction == "next")
        {
            if (curPage < totalPages)
            {
                if (curPage == endPage)
                {
                    SetPagerSize("forward");
                }
                curPage += 1;
            }
        }
        else if (direction == "previous")
        {
            if (curPage > 1)
            {
                if (curPage == startPage)
                {
                    SetPagerSize("back");
                }
                curPage -= 1;
            }
        }
        refreshRecords(curPage);
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591