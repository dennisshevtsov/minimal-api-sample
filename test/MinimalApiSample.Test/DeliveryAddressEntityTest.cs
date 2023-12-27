// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample.Test;

[TestClass]
public sealed class DeliveryAddressEntityTest
{
  [TestMethod]
  public void Constructor_NullContact_InvalidDataExceptionThrown()
  {
    // Arrange
    string contact = null!;

    // Act
    Action act = () => new DeliveryAddressEntity
    (
      contact: contact,
      phone: "test",
      address: "test"
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_EmptyContact_InvalidDataExceptionThrown()
  {
    // Arrange
    string contact = "";

    // Act
    Action act = () => new DeliveryAddressEntity
    (
      contact: contact,
      phone: "test",
      address: "test"
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_NullPhone_InvalidDataExceptionThrown()
  {
    // Arrange
    string phone = null!;

    // Act
    Action act = () => new DeliveryAddressEntity
    (
      contact: "test",
      phone: phone,
      address: "test"
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_EmptyPhone_InvalidDataExceptionThrown()
  {
    // Arrange
    string phone = "";

    // Act
    Action act = () => new DeliveryAddressEntity
    (
      contact: "test",
      phone: phone,
      address: "test"
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_NullAddress_InvalidDataExceptionThrown()
  {
    // Arrange
    string address = null!;

    // Act
    Action act = () => new DeliveryAddressEntity
    (
      contact: "test",
      phone: "test",
      address: address
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }

  [TestMethod]
  public void Constructor_EmptyAddress_InvalidDataExceptionThrown()
  {
    // Arrange
    string address = "";

    // Act
    Action act = () => new DeliveryAddressEntity
    (
      contact: "test",
      phone: "test",
      address: address
    );

    // Assert
    Assert.ThrowsException<InvalidDataException>(act);
  }
}
