using SoftwareShopping.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddJsonOptions(config =>
{
    config.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
});

builder.Services.AddAuthentication(opts =>
{
    opts.DefaultScheme = "Cookies";
    opts.DefaultChallengeScheme = "oidc";
})
    .AddCookie("Cookies", opts =>
    {
        opts.ExpireTimeSpan = TimeSpan.FromMinutes(15);
    })
    .AddOpenIdConnect("oidc", opts =>
    {
        opts.Authority = "https://localhost:5001";
        opts.ClientId = "softwareshopping_web";
        opts.ClientSecret = "49C1A7E1-0C79-4A89-A3D6-A37998FB86B0";
        opts.ResponseType = "code";
        opts.SaveTokens = true;
        opts.GetClaimsFromUserInfoEndpoint = true;
        opts.Scope.Add("software_shopping");
        opts.Scope.Add("offline_access");
    });

builder.Services.AddHttpClient<IProductService, ProductService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ServiceURLS:ProductsAPI"]);
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