// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FrontEnd.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Escola\ISI\FrontEnd\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\Escola\ISI\FrontEnd\Shared\MainLayout.razor"
       
    bool _drawerOpen = true;
    bool _containerFixed = false;

    protected override void OnInitialized()
    {
        currentTheme = defaultTheme;
    }

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    void WidthToggle()
    {
        _containerFixed = !_containerFixed;
    }

    void DarkMode()
    {
        if (currentTheme == defaultTheme)
        {
            currentTheme = darkTheme;
        }
        else
        {
            currentTheme = defaultTheme;
        }
    }

    MudTheme currentTheme = new MudTheme();
    MudTheme defaultTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Black = "#272c34",
            AppbarBackground = "#594ae2ff"
        }
    };

    MudTheme darkTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Black = "#27272f",
            Background = "#32333d",
            BackgroundGrey = "#27272f",
            Surface = "#373740",
            DrawerBackground = "#27272f",
            DrawerText = "rgba(255,255,255, 0.50)",
            DrawerIcon = "rgba(255,255,255, 0.50)",
            AppbarBackground = "#27272f",
            AppbarText = "rgba(255,255,255, 0.70)",
            TextPrimary = "rgba(255,255,255, 0.70)",
            TextSecondary = "rgba(255,255,255, 0.50)",
            ActionDefault = "#adadb1",
            ActionDisabled = "rgba(255,255,255, 0.26)",
            ActionDisabledBackground = "rgba(255,255,255, 0.12)",
            Divider = "rgba(255,255,255, 0.12)",
            DividerLight = "rgba(255,255,255, 0.06)",
            TableLines = "rgba(255,255,255, 0.12)",
            LinesDefault = "rgba(255,255,255, 0.12)",
            LinesInputs = "rgba(255,255,255, 0.3)",
            TextDisabled = "rgba(255,255,255, 0.2)"
        }
    };

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
#pragma warning restore 1591