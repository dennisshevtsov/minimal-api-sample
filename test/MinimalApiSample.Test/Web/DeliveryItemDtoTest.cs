// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample.Web.Test;

[TestClass]
public sealed class DeliveryItemDtoTest
{
  [TestMethod]
  public void Constructor_DeliveryItemEntity_TitleFilled()
  {
    // Arrange
    DeliveryItemEntity deliveryAddressEntity = new
    (
      title       : "test title",
      description : "test description",
      units       : 2,
      gramsPerUnit: 1000
    );

    // Act
    DeliveryItemDto deliveryItemDto = new(deliveryAddressEntity);

    // Assert
    Assert.AreEqual(deliveryAddressEntity.Title, deliveryItemDto.Title);
  }

  [TestMethod]
  public void Constructor_DeliveryItemEntity_DescriptionFilled()
  {
    // Arrange
    DeliveryItemEntity deliveryAddressEntity = new
    (
      title       : "test title",
      description : "test description",
      units       : 2,
      gramsPerUnit: 1000
    );

    // Act
    DeliveryItemDto deliveryItemDto = new(deliveryAddressEntity);

    // Assert
    Assert.AreEqual(deliveryAddressEntity.Description, deliveryItemDto.Description);
  }

  [TestMethod]
  public void Constructor_DeliveryItemEntity_UnitsFilled()
  {
    // Arrange
    DeliveryItemEntity deliveryAddressEntity = new
    (
      title       : "test title",
      description : "test description",
      units       : 2,
      gramsPerUnit: 1000
    );

    // Act
    DeliveryItemDto deliveryItemDto = new(deliveryAddressEntity);

    // Assert
    Assert.AreEqual(deliveryAddressEntity.Units, deliveryItemDto.Units);
  }

  [TestMethod]
  public void Constructor_DeliveryItemEntity_GramsPerUnitFilled()
  {
    // Arrange
    DeliveryItemEntity deliveryAddressEntity = new
    (
      title       : "test title",
      description : "test description",
      units       : 2,
      gramsPerUnit: 1000
    );

    // Act
    DeliveryItemDto deliveryItemDto = new(deliveryAddressEntity);

    // Assert
    Assert.AreEqual(deliveryAddressEntity.GramsPerUnit, deliveryItemDto.GramsPerUnit);
  }
}
