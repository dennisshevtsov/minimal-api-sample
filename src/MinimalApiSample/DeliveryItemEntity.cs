// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample;

public sealed class DeliveryItemEntity(string title, string? description, int units, int gramsPerUnit)
{
  public string Title { get; set; } = string.IsNullOrEmpty(title) ? throw new InvalidDataException("No delivery item title.") : title;

  public string? Description { get; set; } = description;

  public int Units { get; set; } = units <= 0 ? throw new InvalidDataException("Invalid delivery item unit count.") : units;

  public int GramsPerUnit { get; set; } = gramsPerUnit <= 0 ? throw new InvalidDataException("Invalid delivery item unit weight.") : gramsPerUnit;
}
