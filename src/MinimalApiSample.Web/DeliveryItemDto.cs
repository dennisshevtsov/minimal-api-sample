// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace MinimalApiSample.Web;

public sealed class DeliveryItemDto
{
  [Required]
  public required string Title { get; init; }

  public string? Description { get; init; }

  [Required]
  public required int Units { get; init; }

  [Required]
  public required int GramsPerUnit { get; init; }
}
