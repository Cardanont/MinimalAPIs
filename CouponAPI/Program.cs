using CouponAPI.Data;
using CouponAPI.Models;
using CouponAPI.Models.DTO;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("/api/coupon", (ILogger<Program> _logger) =>
{
    _logger.LogInformation("Getting all Coupons!");
    Results.Ok(CouponStore.couponList);
}).WithName("GetCoupons").Produces<IEnumerable<Coupon>>(200);

app.MapGet("/api/coupon/{id:int}", (int id) =>
{
    var coupon = CouponStore.couponList.FirstOrDefault(c => c.Id == id);
    if (coupon == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(coupon);

}).WithName("GetCoupon").Produces<Coupon>(200);

app.MapPost("/api/coupon", ([FromBody]CouponCreateDTO coupon_C_DTO) =>
{
    if(string.IsNullOrEmpty(coupon_C_DTO.Name))
    {
        return Results.BadRequest("Invalid Id or coupon Name");
    }
    if(CouponStore.couponList.FirstOrDefault(c => c.Name.ToLower() == coupon_C_DTO.Name.ToLower()) != null)
    {
        return Results.BadRequest("Coupon Name already exists");
    }

    Coupon coupon = new()
    {
        IsActive = coupon_C_DTO.IsActive,
        Name = coupon_C_DTO.Name,
        Percent = coupon_C_DTO.Percent
    };

    coupon.Id = CouponStore.couponList.Max(c => c.Id) + 1;
    CouponStore.couponList.Add(coupon);
    CouponDTO couponDTO = new()
    {
        Id = coupon.Id,
        IsActive = coupon.IsActive,
        Name = coupon.Name,
        Percent = coupon.Percent,
        Created = coupon.Created
    };
    return Results.CreatedAtRoute("GetCoupon",new { id = coupon.Id }, couponDTO);
}).WithName("CreateCoupon").Accepts<CouponCreateDTO>("application/json").Produces<CouponDTO>(200).Produces(400);

app.MapPut("/api/coupon/{id:int}", (int id) =>
{

});

app.MapDelete("/api/coupon/{id:int}", (int id) =>
{

});

app.UseHttpsRedirection();

app.Run();