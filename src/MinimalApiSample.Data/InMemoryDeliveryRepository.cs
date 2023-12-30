// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample.Data;

public sealed class InMemoryDeliveryRepository : IDeliveryRepository
{
  private readonly Dictionary<Guid, DeliveryEntity> _deliveries = new();

  public Task<DeliveryEntity?> GetAsync(Guid id, CancellationToken cancellationToken) =>
    Task.FromResult(_deliveries.TryGetValue(id, out DeliveryEntity? delivery) ? delivery : null);

  public Task AddAsync(DeliveryEntity delivery, CancellationToken cancellationToken)
  {
    ArgumentNullException.ThrowIfNull(nameof(delivery));
    _deliveries[delivery.Id] = delivery;
    return Task.CompletedTask;
  }

  public Task UpdateAsync(DeliveryEntity delivery, CancellationToken cancellationToken)
  {
    ArgumentNullException.ThrowIfNull(nameof(delivery));
    _deliveries[delivery.Id] = delivery;
    return Task.CompletedTask;
  }
}
