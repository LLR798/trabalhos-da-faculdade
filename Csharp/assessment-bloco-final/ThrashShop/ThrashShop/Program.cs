using NToastNotify;
using ThrashShop.Data;
using ThrashShop.Services;
using ThrashShop.Services.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container:
builder.Services.AddRazorPages();
builder.Services.AddScoped<ISkateService, SkateService>();
builder.Services.AddDbContext<AppDbContext>();

// Add services ToastNotify:
builder.Services.AddRazorPages().AddNToastNotifyToastr( new ToastrOptions()
{
    ProgressBar = true,
    PositionClass = ToastPositions.TopCenter,
    PreventDuplicates = true,
    CloseButton = true,
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();