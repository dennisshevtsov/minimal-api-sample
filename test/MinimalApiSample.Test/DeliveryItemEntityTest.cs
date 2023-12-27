// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample.Test;

[TestClass]
public sealed class DeliveryItemEntityTest
{
  [TestMethod]
  public void Constructor_NullTitle_InvalidDataExceptionThrown()
  {
    // Arrange
    string title = null!;

    // Act
    Action act = () => new DeliveryItemEntity
    (
      title: title,
      description: "test",
      units: 1,
      gramsPerUnit: 1000
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_EmptyTitle_InvalidDataExceptionThrown()
  {
    // Arrange
    string title = "";

    // Act
    Action act = () => new DeliveryItemEntity
    (
      title: title,
      description: "test",
      units: 1,
      gramsPerUnit: 1000
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_ZeroUnits_InvalidDataExceptionThrown()
  {
    // Arrange
    int units = 0;

    // Act
    Action act = () => new DeliveryItemEntity
    (
      title: "test",
      description: "test",
      units: units,
      gramsPerUnit: 1000
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_NegativeUnits_InvalidDataExceptionThrown()
  {
    // Arrange
    int units = -1;

    // Act
    Action act = () => new DeliveryItemEntity
    (
      title: "test",
      description: "test",
      units: units,
      gramsPerUnit: 1000
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_ZeroGramsPerUnit_InvalidDataExceptionThrown()
  {
    // Arrange
    int gramsPerUnit = 0;

    // Act
    Action act = () => new DeliveryItemEntity
    (
      title: "test",
      description: "test",
      units: 1,
      gramsPerUnit: gramsPerUnit
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_NegativeGramsPerUnit_InvalidDataExceptionThrown()
  {
    // Arrange
    int gramsPerUnit = -1;

    // Act
    Action act = () => new DeliveryItemEntity
    (
      title: "test",
      description: "test",
      units: 1,
      gramsPerUnit: gramsPerUnit
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }
}
