// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment_2_Web_Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\_Imports.razor"
using Assignment_2_Web_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\_Imports.razor"
using Assignment_2_Web_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\Pages\ListOfAdults.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\Pages\ListOfAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListOfAdults")]
    public partial class ListOfAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\Maggie\RiderProjects\Solution1\Assignment 2 Web Client\Pages\ListOfAdults.razor"
       
    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;

    private string? filterByName;

    private void FilterByName(ChangeEventArgs changeEventArgs)
    {
        filterByName = null;
        try
        {
            filterByName = changeEventArgs.Value.ToString();
        }
        catch (Exception e){
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        adultsToShow = allAdults.Where(t =>
            (filterByName != null && (t.FirstName.ToLower().Contains(filterByName.ToLower()) || t.LastName.ToLower().Contains(filterByName.ToLower())) ||filterByName == null)
            ).ToList();
    }
    
    protected override async Task OnInitializedAsync()
    {
        allAdults = await AdultData.GetAdultsAsync();
        adultsToShow = allAdults;
    }

    private async Task RemoveAdult(int adultId)
    {
        Adult adultToRemove = allAdults.First(t => t.Id == adultId);
        await AdultData.RemoveAdultAsync(adultId);
        allAdults.Remove(adultToRemove);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591
