// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace MinimalApiSample.Web;

public sealed class AddDeliveryRequestDto
{
  [Required]
  public required IReadOnlyList<DeliveryItemDto> Items { get; init; }

  [Required]
  public required DeliveryAddressDto PickupAt { get; init; }

  [Required]
  public required DeliveryAddressDto DeliverTo { get; init; }

  public DeliveryEntity ToEntity() => new
  (
    id       : Guid.NewGuid(),
    items    : DeliveryItemDto.ToEntities(Items),
    pickupAt : PickupAt?.ToEntity(),
    deliverTo: DeliverTo?.ToEntity()
  );
}
