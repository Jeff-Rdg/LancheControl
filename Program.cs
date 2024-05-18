using LancheControl.DataContext;
using LancheControl.DTO;
using LancheControl.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LancheContext>(opt => 
    opt.UseSqlServer(builder.Configuration.GetConnectionString("BaseConn")));

builder.Services.AddScoped<LancheContext>();  
builder.Services.AddTransient<EmployeeService>();  

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Handlers


app.MapPost("/v1/employee", (EmployeeService service, [FromBody] EmployeeCreateDto model) =>
{
    var employee = model.MapTo();
    if (!model.IsValid)
    {
        return Results.BadRequest(model.Notifications);
    }

    var response = service.Create(employee);
    return Results.Created($"/v1/employee/{response.Id}", response);
}).Produces<EmployeeResponseDto>().WithName("CreateEmployee");

app.MapGet("/v1/employee/{:id:long}", (EmployeeService service, long id) =>
{
    var result = service.GetById(id);
    return result is not null ? Results.Ok(result) : Results.NotFound();
}).WithName("GetEmployeeById");

app.MapGet("/v1/employee", (EmployeeService service, [FromQuery]int pageSize, [FromQuery]int  pageNumber ) =>
{
    var result = service.List(pageNumber, pageSize);
    return result is not null ? Results.Ok(result) : Results.NotFound();
}).WithName("GetEmployees");

app.Run();

