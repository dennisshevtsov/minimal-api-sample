// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample.Test;

[TestClass]
public sealed class DeliveryEntityTest
{
  [TestMethod]
  public void Constructor_NullItems_InvalidDataExceptionThrown()
  {
    // Arrange
    IReadOnlyList<DeliveryItemEntity> items = null!;

    // Act
    Action act = () => new DeliveryEntity
    (
      id: Guid.NewGuid(),
      items: items,
      pickupAt: new DeliveryAddressEntity
      (
        contact: "test",
        phone: "test",
        address: "test"
      ),
      deliverTo: new DeliveryAddressEntity
      (
        contact: "test",
        phone: "test",
        address: "test"
      )
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_EmptyItems_InvalidDataExceptionThrown()
  {
    // Arrange
    IReadOnlyList<DeliveryItemEntity> items = [];

    // Act
    Action act = () => new DeliveryEntity
    (
      id: Guid.NewGuid(),
      items: items,
      pickupAt: new DeliveryAddressEntity
      (
        contact: "test",
        phone: "test",
        address: "test"
      ),
      deliverTo: new DeliveryAddressEntity
      (
        contact: "test",
        phone: "test",
        address: "test"
      )
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_NullPickupAt_InvalidDataExceptionThrown()
  {
    // Arrange
    DeliveryAddressEntity pickupAt = null!;

    // Act
    Action act = () => new DeliveryEntity
    (
      id: Guid.NewGuid(),
      items: [
        new DeliveryItemEntity
        (
          title: "test",
          description: null,
          units: 1,
          gramsPerUnit: 1000
        )
      ],
      pickupAt: pickupAt,
      deliverTo: new DeliveryAddressEntity
      (
        contact: "test",
        phone: "test",
        address: "test"
      )
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_NullDeliverTo_InvalidDataExceptionThrown()
  {
    // Arrange
    DeliveryAddressEntity deliverTo = null!;

    // Act
    Action act = () => new DeliveryEntity
    (
      id: Guid.NewGuid(),
      items: [
        new DeliveryItemEntity
        (
          title: "test",
          description: null,
          units: 1,
          gramsPerUnit: 1000
        )
      ],
      pickupAt: new DeliveryAddressEntity
      (
        contact: "test",
        phone: "test",
        address: "test"
      ),
      deliverTo: deliverTo
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }
}
