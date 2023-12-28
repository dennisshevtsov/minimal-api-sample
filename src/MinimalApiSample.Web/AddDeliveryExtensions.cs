// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using MinimalApiSample;
using MinimalApiSample.Web;

namespace Microsoft.AspNetCore.Builder;

public static class AddDeliveryExtensions
{
  public static IEndpointRouteBuilder MapAddDeliveryHandler(this IEndpointRouteBuilder builder)
  {
    ArgumentNullException.ThrowIfNull(builder);

    builder.MapPost("/api/delivery", async (
      AddDeliveryRequestDto requestDto, IDeliveryRepository deliveryRepository, CancellationToken cancellationToken) =>
    {
      ArgumentNullException.ThrowIfNull(requestDto);
      ArgumentNullException.ThrowIfNull(deliveryRepository);

      DeliveryEntity deliveryEntity = requestDto.ToEntity();
      await deliveryRepository.AddDeliveryAsync(deliveryEntity, cancellationToken);

      return Results.Created
      (
        uri  : default(Uri),
        value: deliveryEntity
      );
    });

    return builder;
  }
}
