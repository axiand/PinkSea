using Microsoft.AspNetCore.HttpLogging;
using PinkSea.AtProto;
using PinkSea.AtProto.OAuth;
using PinkSea.AtProto.Providers.Storage;
using PinkSea.Models;
using PinkSea.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpLogging(o => { 
    o.LoggingFields = HttpLoggingFields.All;
    o.RequestBodyLogLimit = 10000000;
});

builder.Services.Configure<AppViewConfig>(
    builder.Configuration.GetSection("AppViewConfig"));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IOAuthStateStorageProvider, MemoryOAuthStateStorageProvider>();
builder.Services.AddTransient<IOAuthClientDataProvider, OAuthClientDataProvider>();
builder.Services.AddSingleton<SigningKeyService>();
builder.Services.AddAtProtoClientServices();

builder.Services.AddAuthentication("PinkSea")
    .AddCookie("PinkSea", options =>
    {
        options.LoginPath = "/";
        options.LogoutPath = "/oauth/invalidate";
        options.AccessDeniedPath = "/";
    });

var app = builder.Build();

app.UseHttpLogging();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllers();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.Run();