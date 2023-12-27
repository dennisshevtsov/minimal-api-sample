// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample;

public sealed class DeliveryEntity(
  Guid id, IReadOnlyList<DeliveryItemEntity> items, DeliveryAddressEntity pickupAt, DeliveryAddressEntity deliverTo)
{
  public Guid Id { get; set; } = id;

  public IReadOnlyList<DeliveryItemEntity> Items { get; set; } = items;

  public DeliveryAddressEntity PickupAt { get; set; } = pickupAt;

  public DeliveryAddressEntity DeliverTo { get; set; } = deliverTo;
}
