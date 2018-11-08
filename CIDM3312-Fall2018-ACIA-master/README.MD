# Basic Steps for an ASP.NET MVC Core 2.x Web Application

We'll need to follow along with some of what Freeman, Lock, and Smith show.  You can also just use what is found in Microsoft's tutorials: [ASP.NET MVC Core 2.x tutorials]( https://docs.microsoft.com/en-us/aspnet/core/index?view=aspnetcore-2.1).

## Make ASP.NET MVC Core App from template

```dotnet new mvc```

This command is run relative to the folder where you want your app to reside.

You'll want to open the `.csproj` file and change this entry:

```xml
  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.App"/>
  </ItemGroup>
```

```xml
  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.All" Version="2.1.4" />
  </ItemGroup>
```

This actually includes the EF Core stuff mentioned below.  However, the habits below are good, so do both. 


## Models

You'll notice a models folder, this is where your entity models are stored. Otherwise you create your entity classes as normal.

For example, I could create a class for a student:

```csharp
public class Student
{
    public int StudentID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Major { get; set; }
}
```
## Entity Framework Core

We'll invariably be connecting to a database, so we'll want to place our EFCore stuff here in Models.  We could argue whether these need to go to a more specialized folder, but we won't for now.

We also need to decide on a database provider.  For personalized learning applications, we'll want to use SQLite.  So, we need to go to Nuget.org and obtain the needed packages.

* Get EF Core: `dotnet add package Microsoft.EntityFrameworkCore --version 2.1.4` 
* Get EF Core SQLite: `dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 2.1.4`
* Get EF Core Design: `dotnet add package Microsoft.EntityFrameworkCore.Design --version 2.1.4`
* Get EF Core Tools: `dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet --version 2.0.3`

We'll have to add some other items manuall (note: it is very likely that you'll have to update these versions in the future).

```xml
  <ItemGroup>
    <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="2.0.4" />
    <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.3" />
  </ItemGroup>
```

## DbContext

Since we're using EF Core, we'll need to build a DbContext in order to connect to data.

Let's start with this one (place it into your models folder):

```csharp
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Student> Students { get; set; }
}
```

## Register the DbContext

Okay, so now that we have an ASP.NET MVC Core app, the process by which we register the database is a bit more complex.

To do this, we'll have to work with the Startup.cs file that kicks off the Kestrel web server built in to the dotnet tooling.  Your initial Startup.cs file will look like this:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ch2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
```

Of course, that's quite a lot.

We want to insert some new code into the `ConfigureServices` method:

