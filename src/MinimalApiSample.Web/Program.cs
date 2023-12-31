// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using MinimalApiSample;
using MinimalApiSample.Web;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInMemoryData();

WebApplication app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/api/delivery/{id:guid}", async (Guid id, IDeliveryRepository repo, CancellationToken ct) =>
   {
     ArgumentNullException.ThrowIfNull(repo);
     DeliveryEntity? entity = await repo.GetAsync(id, ct);
     return entity is null ? Results.NotFound() : Results.Ok(new GetDeliveryResponseDto(entity));
   })
   .WithOpenApi()
   .WithName("GetDelivery")
   .Produces(StatusCodes.Status404NotFound)
   .Produces<GetDeliveryResponseDto>(StatusCodes.Status200OK);

app.MapPost("/api/delivery", async (AddDeliveryRequestDto req, IDeliveryRepository repo, CancellationToken ct) =>
   {
     ArgumentNullException.ThrowIfNull(req);
     ArgumentNullException.ThrowIfNull(repo);

     DeliveryEntity entity = req.ToEntity();
     await repo.AddAsync(entity, ct);

     return Results.Created
     (
       uri  : default(Uri),
       value: new GetDeliveryResponseDto(entity)
     );
   })
   .WithOpenApi()
   .WithName("AddDelivery")
   .Produces<GetDeliveryResponseDto>(StatusCodes.Status201Created)
   .Accepts<AddDeliveryRequestDto>("application/json");

app.MapPost("/api/delivery/{id:guid}/start", async (Guid id, IDeliveryRepository repo, CancellationToken ct) =>
   {
     ArgumentNullException.ThrowIfNull(repo);

     DeliveryEntity? entity = await repo.GetAsync(id, ct);
     if (entity is null)
     {
       return Results.NotFound();
     }

     entity.Start();
     await repo.UpdateAsync(entity, ct);

     return Results.NoContent();
   })
   .WithOpenApi()
   .WithName("StartDelivery")
   .Produces(StatusCodes.Status404NotFound)
   .Produces(StatusCodes.Status204NoContent);

app.MapPost("/api/delivery/{id:guid}/complete", async (Guid id, IDeliveryRepository repo, CancellationToken ct) =>
   {
     ArgumentNullException.ThrowIfNull(repo);

     DeliveryEntity? entity = await repo.GetAsync(id, ct);
     if (entity is null)
     {
       return Results.NotFound();
     }

     entity.Complete();
     await repo.UpdateAsync(entity, ct);

     return Results.NoContent();
   })
   .WithOpenApi()
   .WithName("CompleteDelivery")
   .Produces(StatusCodes.Status404NotFound)
   .Produces(StatusCodes.Status204NoContent);

app.MapPost("/api/delivery/{id:guid}/cancel", async (Guid id, IDeliveryRepository repo, CancellationToken ct) =>
   {
     ArgumentNullException.ThrowIfNull(repo);

     DeliveryEntity? entity = await repo.GetAsync(id, ct);
     if (entity is null)
     {
       return Results.NotFound();
     }

     entity.Cancel();
     await repo.UpdateAsync(entity, ct);

     return Results.NoContent();
   })
   .WithOpenApi()
   .WithName("CancelDelivery")
   .Produces(StatusCodes.Status404NotFound)
   .Produces(StatusCodes.Status204NoContent);

app.Run();
