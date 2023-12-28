// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace MinimalApiSample.Web;

public sealed class DeliveryAddressDto
{
  [Required]
  public required string Contact { get; init; }

  [Required]
  public required string Phone { get; init; }

  [Required]
  public required string Address { get; init; }

  public DeliveryAddressEntity ToEntity() => new
  (
    contact: Contact,
    phone  : Phone,
    address: Address
  );
}
