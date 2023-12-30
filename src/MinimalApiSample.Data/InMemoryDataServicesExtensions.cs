// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using MinimalApiSample;
using MinimalApiSample.Data;

namespace Microsoft.Extensions.DependencyInjection;

public static class InMemoryDataServicesExtensions
{
  public static IServiceCollection AddInMemoryData(this IServiceCollection services)
  {
    ArgumentNullException.ThrowIfNull(services);
    services.AddSingleton<IDeliveryRepository, InMemoryDeliveryRepository>();
    return services;
  }
}
