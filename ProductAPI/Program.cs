using BookingLib;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IHostedService, InitService>();

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

MapProductEndpoints(app, "Bookings");

app.Run();

void MapProductEndpoints(WebApplication app, string tag)
{
    app.MapGet("api/Bookings", () => { return (new BookingService()).ReadAll(); }).WithTags(tag);
    app.MapGet("api/Bookings/{key}", (string key) => { return (new BookingService()).Read(key); }).WithTags(tag);
    app.MapPost("api/Bookings", (BookingCreateReq req) => { return new BookingService().Create(req); }).WithTags(tag);
    app.MapPut("api/Bookings", (BookingUpdateReq req) => { return new BookingService().Update(req); }).WithTags(tag);
    app.MapDelete("api/Bookings/{key}", (string key) => { return (new BookingService()).Delete(key); }).WithTags(tag);
}

