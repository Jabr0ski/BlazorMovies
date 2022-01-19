#pragma checksum "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\MoviesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0d0733ee5781028e921d31115648d55b65ef826"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
    public partial class MoviesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\MoviesList.razor"
 if (Movies == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<img src=\"https://c.tenor.com/tEBoZu1ISJ8AAAAC/spinning-loading.gif\">");
#nullable restore
#line 4 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\MoviesList.razor"

}
else if (Movies.Count == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "There are no records to show");
#nullable restore
#line 8 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\MoviesList.razor"
                                             
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "checkbox");
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\MoviesList.razor"
                                        () => displayButtons = !displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\MoviesList.razor"
     foreach (var movie in Movies)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorMovies.Client.Shared.IndividualMovie>(5);
            __builder.AddAttribute(6, "Movie", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovies.Shared.Entities.Movie>(
#nullable restore
#line 16 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\MoviesList.razor"
                                movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "DisplayButtons", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\MoviesList.razor"
                                                       displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\MoviesList.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\MoviesList.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\MoviesList.razor"
       
    [Parameter] public List<Movie> Movies { get; set; }
    bool displayButtons = false;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
