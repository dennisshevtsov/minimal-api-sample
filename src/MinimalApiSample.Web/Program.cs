// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using MinimalApiSample;
using MinimalApiSample.Web;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

WebApplication app = builder.Build();
app.MapPost("/api/delivery", async (AddDeliveryRequestDto requestDto, IDeliveryRepository deliveryRepository, CancellationToken cancellationToken) =>
{
  ArgumentNullException.ThrowIfNull(requestDto);
  await deliveryRepository.AddDeliveryAsync(requestDto.ToEntity(), cancellationToken);
  return Results.Created();
});
app.Run();
