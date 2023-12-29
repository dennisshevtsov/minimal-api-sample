// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MinimalApiSample.Web;

public sealed class DeliveryAddressDto
{
  public DeliveryAddressDto() { }

  [SetsRequiredMembers]
  public DeliveryAddressDto(string contact, string phone, string address)
  {
    Contact = contact;
    Phone   = phone;
    Address = address;
  }

  [SetsRequiredMembers]
  public DeliveryAddressDto(DeliveryAddressEntity deliveryAddressEntity)
  : this
  (
      contact: deliveryAddressEntity.Contact,
      phone  : deliveryAddressEntity.Phone,
      address: deliveryAddressEntity.Address
  )
  { }

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
