#pragma checksum "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\IndividualMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40544914a3c7c94f8e48e8c6d1c9f80bd6606ee0"
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
    public partial class IndividualMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "background-color:" + " " + (
#nullable restore
#line 2 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\IndividualMovie.razor"
                                Movie.KeyID % 2 == 0 ? "blue" : "red"

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, "Title: ");
#nullable restore
#line 3 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\IndividualMovie.razor"
__builder.AddContent(4, (MarkupString)Movie.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Release Date: ");
            __builder.OpenElement(8, "b");
#nullable restore
#line 4 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\IndividualMovie.razor"
__builder.AddContent(9, Movie.ReleaseDate.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 5 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\IndividualMovie.razor"
     if (DisplayButtons)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\IndividualMovie.razor"
                                () => DeleteMovie.InvokeAsync(Movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\IndividualMovie.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\shayr\GitHubRepos\BlazorMovies\Client\Shared\IndividualMovie.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public bool DisplayButtons { get; set; } = false;
    [Parameter] public EventCallback<Movie> DeleteMovie { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
