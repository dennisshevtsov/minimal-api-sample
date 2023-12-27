// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample;

public sealed class DeliveryAddressEntity(string contact, string phone, string address)
{
  public string Contact { get; set; } = string.IsNullOrWhiteSpace(contact) ? throw new InvalidDataException("No delivery address contact.") : contact;

  public string Phone { get; set; } = string.IsNullOrWhiteSpace(phone) ? throw new InvalidDataException("No delivery address phone.") : phone;

  public string Address { get; set; } = string.IsNullOrWhiteSpace(address) ? throw new InvalidDataException("No delivery address.") : address;
}
