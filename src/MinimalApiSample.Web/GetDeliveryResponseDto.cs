// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample.Web;

public sealed class GetDeliveryResponseDto(Guid id, IReadOnlyList<DeliveryItemDto> items, DeliveryAddressDto pickupAt, DeliveryAddressDto deliverTo, DeliveryStatus status)
{
  public GetDeliveryResponseDto(DeliveryEntity deliveryEntity)
  : this
  (
      id       : deliveryEntity.Id,
      items    : DeliveryItemDto.FromEntities(deliveryEntity.Items),
      pickupAt : new DeliveryAddressDto(deliveryEntity.PickupAt),
      deliverTo: new DeliveryAddressDto(deliveryEntity.DeliverTo),
      status   : deliveryEntity.Status
  )
  { }

  public Guid Id { get; set; } = id;

  public IReadOnlyList<DeliveryItemDto> Items { get; } = items;

  public DeliveryAddressDto PickupAt { get; } = pickupAt;

  public DeliveryAddressDto DeliverTo { get; } = deliverTo;

  public DeliveryStatus Status { get; } = status;
}
