// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\Summary.razor"
using BlazorApp2.Shared;

#line default
#line hidden
#nullable disable
    public partial class Summary : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\LENOVO\source\repos\BlazorApp2\BlazorApp2\Client\Pages\Summary.razor"
       
    
    private string summary;
    [Parameter] public int id { get; set; }
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        summary = forecasts.Where(x => x.Id == id).First().Summary;

    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
