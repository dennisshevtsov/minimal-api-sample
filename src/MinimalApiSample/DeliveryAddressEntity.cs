// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample;

public sealed class DeliveryAddressEntity(string contact, string phone, string address)
{
  public string Contact { get; set; } = contact;

  public string Phone { get; set; } = phone;

  public string Address { get; set; } = address;
}
