using EasyReserve.API.Data;
using EasyReserve.API.Integration.Refit;
using EasyReserve.API.Interfaces;
using EasyReserve.API.Mappings;
using EasyReserve.API.Repositories;
using EasyReserve.API.Services.ClientService;
using EasyReserve.API.Services.HotelService;
using EasyReserve.API.Services.ReserveService;
using EasyReserve.API.Services.RoomService;
using EasyReserve.API.Services.ViaCepService;
using Microsoft.EntityFrameworkCore;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Dependency injection

// Hotel:
builder.Services.AddScoped<IHotelRepository, HotelRepository>();
builder.Services.AddScoped<IHotelService, HotelService>();

// Room:
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IRoomService, RoomService>();

// Client:
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IClientService, ClientService>();

// Reserve:
builder.Services.AddScoped<IReserveRepository, ReserveRepository>();
builder.Services.AddScoped<IReserveService, ReserveService>();

// Via cep:
builder.Services.AddScoped<IViaCepService, ViaCepService>(); 

// Refit:
builder.Services.AddRefitClient<IViaCepIntegrationRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://viacep.com.br");
});

// AutoMapper
builder.Services.AddAutoMapper(typeof(EntitiesToDTOMappingProfile));




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();