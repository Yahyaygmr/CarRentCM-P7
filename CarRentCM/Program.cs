using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Handlers.BodyTypeHandlers.Read;
using CarRentCM.Features.CQRS.Handlers.BodyTypeHandlers.Write;
using CarRentCM.Features.CQRS.Handlers.BrandHandlers.Read;
using CarRentCM.Features.CQRS.Handlers.BrandHandlers.Write;
using CarRentCM.Features.CQRS.Handlers.LocationHandlers.Read;
using CarRentCM.Features.CQRS.Handlers.LocationHandlers.Write;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CarRentContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<DeleteBrandCommandHandler>();


builder.Services.AddScoped<GetLocationQueryHandler>();
builder.Services.AddScoped<GetLocationByIdQueryHandler>();
builder.Services.AddScoped<CreateLocationCommandHandler>();
builder.Services.AddScoped<UpdateLocationCommandHandler>();
builder.Services.AddScoped<DeleteLocationCommandHandler>();

builder.Services.AddScoped<GetBodyTypeQueryHandler>();
builder.Services.AddScoped<GetBodyTypeByIdQueryHandler>();
builder.Services.AddScoped<CreateBodyTypeCommandHandler>();
builder.Services.AddScoped<UpdateBodyTypeCommandHandler>();
builder.Services.AddScoped<DeleteBodyTypeCommandHandler>();

builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
