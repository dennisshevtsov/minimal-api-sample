// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample;

public sealed class DeliveryItemEntity(string title, string? description, int units, int weightPerUnit)
{
  public string Title { get; set; } = string.IsNullOrWhiteSpace(title) ? throw new Exception("No delivery item title.") : title;

  public string? Description { get; set; } = description;

  public int Units { get; set; } = units <= 0 ? throw new Exception("Invalid delivery item unit count.") : units;

  public int WeightPerUnit { get; set; } = weightPerUnit <= 0 ? throw new Exception("Invalid delivery item weight per unit.") : weightPerUnit;
}
