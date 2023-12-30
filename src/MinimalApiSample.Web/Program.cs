// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using MinimalApiSample;
using MinimalApiSample.Web;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddInMemoryData();

WebApplication app = builder.Build();

app.MapGet("/api/delivery/{id:guid}", async (Guid id, IDeliveryRepository repo, CancellationToken ct) =>
{
  ArgumentNullException.ThrowIfNull(repo);
  DeliveryEntity? entity = await repo.GetAsync(id, ct);
  return entity is null ? Results.NotFound() : Results.Ok(entity);
});

app.MapPost("/api/delivery", async (AddDeliveryRequestDto req, IDeliveryRepository repo, CancellationToken ct) =>
{
  ArgumentNullException.ThrowIfNull(req);
  ArgumentNullException.ThrowIfNull(repo);

  DeliveryEntity entity = req.ToEntity();
  await repo.AddAsync(entity, ct);

  return Results.Created
  (
    uri  : default(Uri),
    value: entity
  );
});

app.MapGet("/api/delivery/delivery/{id:guid}", async (Guid id, IDeliveryRepository repo, CancellationToken ct) =>
{
  ArgumentNullException.ThrowIfNull(repo);
  DeliveryEntity? entity = await repo.GetAsync(id, ct);
  return entity is null ? Results.NotFound() : Results.Ok(new GetDeliveryResponseDto(entity));
});

app.MapPost("/api/delivery/delivery/{id:guid}/start", async (Guid id, IDeliveryRepository repo, CancellationToken ct) =>
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
});

app.MapPost("/api/delivery/delivery/{id:guid}/complete", async (Guid id, IDeliveryRepository repo, CancellationToken ct) =>
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
});

app.MapPost("/api/delivery/delivery/{id:guid}/cancel", async (Guid id, IDeliveryRepository repo, CancellationToken ct) =>
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
});

app.Run();
