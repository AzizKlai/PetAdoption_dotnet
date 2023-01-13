using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
            })
            .AddCookie()
            .AddGoogle(GoogleDefaults.AuthenticationScheme, options =>
             {
                 options.ClientId = "117816318096-2kfe494b00oau71ouv1epifefohnfm5p.apps.googleusercontent.com";
                   options.ClientSecret = "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";;
                 options.ClaimActions.MapJsonKey("urn:google:picture", "picture", "url");
             });
builder.Services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);*/

builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
                .AddCookie(options =>
                {
                    options.LoginPath = "/account/google-login";
                })
                .AddGoogle(options =>
                {
                    options.ClientId = "117816318096-2kfe494b00oau71ouv1epifefohnfm5p.apps.googleusercontent.com";
                    options.ClientSecret = "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";
                });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();           


app.UseRouting();

 
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();