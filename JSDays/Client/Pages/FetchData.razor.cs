using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using JSDays.Client;
using JSDays.Client.Shared;
using JSDays.Shared;

namespace JSDays.Client.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[]? forecasts;
        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }

        private async Task HandleSaveClick()
        {
            Console.WriteLine("Saving...");
            await Task.Delay(500);
            Console.WriteLine("Saved.");
        }
    }
}