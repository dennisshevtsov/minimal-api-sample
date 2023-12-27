// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample;

public interface IDeliveryRepository
{
  public Task<DeliveryEntity?> GetDeliveryAsync(Guid id, CancellationToken cancellationToken);

  public Task AddDeliveryAsync(DeliveryEntity delivery, CancellationToken cancellationToken);
}
