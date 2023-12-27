// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample;

public sealed class DeliveryEntity(
  Guid id, IReadOnlyList<DeliveryItemEntity> items, DeliveryAddressEntity pickupAt, DeliveryAddressEntity deliverTo)
{
  public Guid Id { get; set; } = id;

  public IReadOnlyList<DeliveryItemEntity> Items { get; } = items is not { Count : > 0 } ? throw new InvalidDataException("No delivery items.") : items;

  public DeliveryAddressEntity PickupAt { get; } = pickupAt ?? throw new InvalidDataException("No pickup address.");

  public DeliveryAddressEntity DeliverTo { get; } = deliverTo ?? throw new InvalidDataException("No destination address.");
}
