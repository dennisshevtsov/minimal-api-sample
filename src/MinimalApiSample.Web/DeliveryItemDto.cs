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

  public DeliveryItemEntity ToEntity() => new
  (
    title       : Title,
    description : Description,
    units       : Units,
    gramsPerUnit: GramsPerUnit
  );

  public static IReadOnlyList<DeliveryItemEntity> ToEntities(IReadOnlyList<DeliveryItemDto> dtos)
  {
    if (dtos is not { Count: > 0 })
    {
      return [];
    }

    DeliveryItemEntity[] entities = new DeliveryItemEntity[dtos.Count];

    for (int i = 0; i < dtos.Count; i++)
    {
      entities[i] = dtos[i].ToEntity();
    }

    return entities;
  }
}
