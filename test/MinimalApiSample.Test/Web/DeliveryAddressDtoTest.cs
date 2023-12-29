// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample.Web.Test;

[TestClass]
public sealed class DeliveryAddressDtoTest
{
  [TestMethod]
  public void Constructor_DeliveryAddressEntity_ContactFilled()
  {
    // Arrange
    DeliveryAddressEntity deliveryAddressEntity = new
    (
      contact: "test contact",
      phone  : "test phone",
      address: "test address"
    );

    // Act
    DeliveryAddressDto deliveryAddressDto = new(deliveryAddressEntity);

    // Assert
    Assert.AreEqual(deliveryAddressEntity.Contact, deliveryAddressDto.Contact);
  }

  [TestMethod]
  public void Constructor_DeliveryAddressEntity_PhoneFilled()
  {
    // Arrange
    DeliveryAddressEntity deliveryAddressEntity = new
    (
      contact: "test contact",
      phone  : "test phone",
      address: "test address"
    );

    // Act
    DeliveryAddressDto deliveryAddressDto = new(deliveryAddressEntity);

    // Assert
    Assert.AreEqual(deliveryAddressEntity.Phone, deliveryAddressDto.Phone);
  }

  [TestMethod]
  public void Constructor_DeliveryAddressEntity_AddressFilled()
  {
    // Arrange
    DeliveryAddressEntity deliveryAddressEntity = new
    (
      contact: "test contact",
      phone  : "test phone",
      address: "test address"
    );

    // Act
    DeliveryAddressDto deliveryAddressDto = new(deliveryAddressEntity);

    // Assert
    Assert.AreEqual(deliveryAddressEntity.Address, deliveryAddressDto.Address);
  }
}
