var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();


//强类型配置
builder.Configuration.Get<AppSettings>();






var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

await app.RunAsync();
