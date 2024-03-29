﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample;

public interface IDeliveryRepository
{
  public Task<DeliveryEntity?> GetAsync(Guid id, CancellationToken cancellationToken);

  public Task AddAsync(DeliveryEntity delivery, CancellationToken cancellationToken);

  public Task UpdateAsync(DeliveryEntity delivery, CancellationToken cancellationToken);
}
