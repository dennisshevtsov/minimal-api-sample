// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample.Web.Test;

[TestClass]
public sealed class AddDeliveryRequestDtoTest
{
  [TestMethod]
  public void ToEntity_AddDeliveryRequestDto_IdNotDefault()
  {
    // Arrange
    AddDeliveryRequestDto addDeliveryRequestDto = new()
    {
      Items = [
        new DeliveryItemDto
        (
          title       : "test title",
          description : "test description",
          units       : 2,
          gramsPerUnit: 1000
        ),
      ],
      PickupAt = new DeliveryAddressDto
      (
        contact: "test pickup contact",
        phone  : "test pickup phone",
        address: "test pickup address"
      ),
      DeliverTo = new DeliveryAddressDto
      (
        contact: "test delivery contact",
        phone  : "test delivery phone",
        address: "test delivery address"
      )
    };

    // Act
    DeliveryEntity deliveryEntity = addDeliveryRequestDto.ToEntity();

    // Assert
    Assert.AreNotEqual(default, deliveryEntity.Id);
  }

  [TestMethod]
  public void ToEntity_AddDeliveryRequestDto_ItemsFilled()
  {
    // Arrange
    AddDeliveryRequestDto addDeliveryRequestDto = new()
    {
      Items = [
        new DeliveryItemDto
        (
          title       : "test title",
          description : "test description",
          units       : 2,
          gramsPerUnit: 1000
        ),
      ],
      PickupAt = new DeliveryAddressDto
      (
        contact: "test pickup contact",
        phone  : "test pickup phone",
        address: "test pickup address"
      ),
      DeliverTo = new DeliveryAddressDto
      (
        contact: "test delivery contact",
        phone  : "test delivery phone",
        address: "test delivery address"
      )
    };

    // Act
    DeliveryEntity deliveryEntity = addDeliveryRequestDto.ToEntity();

    // Assert
    Assert.AreEqual(addDeliveryRequestDto.Items.Count, deliveryEntity.Items.Count);

    for (int i = 0; i < deliveryEntity.Items.Count; i++)
    {
      Assert.AreEqual(addDeliveryRequestDto.Items[i].Title       , deliveryEntity.Items[i].Title       );
      Assert.AreEqual(addDeliveryRequestDto.Items[i].Description , deliveryEntity.Items[i].Description );
      Assert.AreEqual(addDeliveryRequestDto.Items[i].Units       , deliveryEntity.Items[i].Units       );
      Assert.AreEqual(addDeliveryRequestDto.Items[i].GramsPerUnit, deliveryEntity.Items[i].GramsPerUnit);
    }
  }

  [TestMethod]
  public void ToEntity_AddDeliveryRequestDto_PickupAtFilled()
  {
    // Arrange
    AddDeliveryRequestDto addDeliveryRequestDto = new()
    {
      Items = [
        new DeliveryItemDto
        (
          title       : "test title",
          description : "test description",
          units       : 2,
          gramsPerUnit: 1000
        ),
      ],
      PickupAt = new DeliveryAddressDto
      (
        contact: "test pickup contact",
        phone  : "test pickup phone",
        address: "test pickup address"
      ),
      DeliverTo = new DeliveryAddressDto
      (
        contact: "test delivery contact",
        phone  : "test delivery phone",
        address: "test delivery address"
      )
    };

    // Act
    DeliveryEntity deliveryEntity = addDeliveryRequestDto.ToEntity();

    // Assert
    Assert.IsNotNull(deliveryEntity.PickupAt);
    Assert.AreEqual(addDeliveryRequestDto.PickupAt.Contact, deliveryEntity.PickupAt.Contact);
    Assert.AreEqual(addDeliveryRequestDto.PickupAt.Phone  , deliveryEntity.PickupAt.Phone  );
    Assert.AreEqual(addDeliveryRequestDto.PickupAt.Address, deliveryEntity.PickupAt.Address);
  }

  [TestMethod]
  public void ToEntity_AddDeliveryRequestDto_DeliverToFilled()
  {
    // Arrange
    AddDeliveryRequestDto addDeliveryRequestDto = new()
    {
      Items = [
        new DeliveryItemDto
        (
          title       : "test title",
          description : "test description",
          units       : 2,
          gramsPerUnit: 1000
        ),
      ],
      PickupAt = new DeliveryAddressDto
      (
        contact: "test pickup contact",
        phone  : "test pickup phone",
        address: "test pickup address"
      ),
      DeliverTo = new DeliveryAddressDto
      (
        contact: "test delivery contact",
        phone  : "test delivery phone",
        address: "test delivery address"
      )
    };

    // Act
    DeliveryEntity deliveryEntity = addDeliveryRequestDto.ToEntity();

    // Assert
    Assert.IsNotNull(deliveryEntity.DeliverTo);
    Assert.AreEqual(addDeliveryRequestDto.DeliverTo.Contact, deliveryEntity.DeliverTo.Contact);
    Assert.AreEqual(addDeliveryRequestDto.DeliverTo.Phone  , deliveryEntity.DeliverTo.Phone  );
    Assert.AreEqual(addDeliveryRequestDto.DeliverTo.Address, deliveryEntity.DeliverTo.Address);
  }
}
