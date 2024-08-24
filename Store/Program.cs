using Microsoft.EntityFrameworkCore;
using Store.Application.Services;
using Store.DataAccess;
using Store.DataAccess.Repository;
using Store.Domain.Abstractions;
using Store.Api.Ñontracts;
using Store.Domain.Models;
using Store.Domain.Errors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StoreDbContext>(
    options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(StoreDbContext)));
    });
builder.Services.AddScoped<IItemsRepository, ItemsRepository>();
builder.Services.AddScoped<IItemSevice, ItemSevice>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

//app.MapGet("/items", async (IItemSevice itemService) =>
//{
//    var items = await itemService.GetAllItems();
//    return items != null ? Results.Ok(items) : Results.NotFound();
//});

//app.MapGet("/items/{id}", async (IItemSevice itemService, Guid id) =>
//{
//    var item = await itemService.GetItem(id);
//    return item != null ? Results.Ok(item) : Results.NotFound();
//});

//app.MapPost("/items", async (IItemSevice itemService, ItemRequest request) =>
//{
//    try
//    {
//        var item = new StoreItem(Guid.NewGuid(), request.Name, request.Discription, request.Price);
//        var id = await itemService.CreateItem(item);
//        return Results.Ok(id);
//    }
//    catch (WrongItemData error)
//    {
//        return Results.BadRequest(error.Message);
//    }
//});

//app.MapPut("/items/{id}", async (IItemSevice itemService, Guid id, ItemRequest request) =>
//{
//    try
//    {
//        var item = new StoreItem(id, request.Name, request.Discription, request.Price);
//        var res = await itemService.UpdateItem(id, item);
//        return Results.Ok(res);
//    }
//    catch (WrongItemData error)
//    {
//        return Results.BadRequest(error.Message);
//    }
//});

app.Run();
