// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample;

public sealed class DeliveryItemEntity(string title, string? description, int units, int weightPerUnit)
{
  public string Title { get; set; } = title;

  public string? Description { get; set; } = description;

  public int Unit { get; set; } = units;

  public int WeightPerUnit { get; set; } = weightPerUnit;
}
