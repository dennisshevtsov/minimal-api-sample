// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample.Web.Test;

[TestClass]
public sealed class GetDeliveryResponseDtoTest
{
  [TestMethod]
  public void Constructor_DeliveryEntity_IdFilled()
  {
    // Arrange
    DeliveryEntity deliveryEntity = new
    (
      id: Guid.NewGuid(),
      items: [
        new DeliveryItemEntity
        (
          title       : "test title",
          description : "test description",
          units       : 2,
          gramsPerUnit: 1000
        ),
      ],
      pickupAt: new DeliveryAddressEntity
      (
        contact: "test pickup contact",
        phone  : "test pickup phone",
        address: "test pickup address"
      ),
      deliverTo: new DeliveryAddressEntity
      (
        contact: "test delivery contact",
        phone  : "test delivery phone",
        address: "test delivery address"
      ),
      status: DeliveryStatus.Processing
    );

    // Act
    GetDeliveryResponseDto getDeliveryResponseDto = new(deliveryEntity);

    // Assert
    Assert.AreEqual(getDeliveryResponseDto.Id, deliveryEntity.Id);
  }

  [TestMethod]
  public void Constructor_DeliveryEntity_ItemsFilled()
  {
    // Arrange
    DeliveryEntity deliveryEntity = new
    (
      id: Guid.NewGuid(),
      items: [
        new DeliveryItemEntity
        (
          title       : "test title",
          description : "test description",
          units       : 2,
          gramsPerUnit: 1000
        ),
      ],
      pickupAt: new DeliveryAddressEntity
      (
        contact: "test pickup contact",
        phone  : "test pickup phone",
        address: "test pickup address"
      ),
      deliverTo: new DeliveryAddressEntity
      (
        contact: "test delivery contact",
        phone  : "test delivery phone",
        address: "test delivery address"
      ),
      status: DeliveryStatus.Processing
    );

    // Act
    GetDeliveryResponseDto getDeliveryResponseDto = new(deliveryEntity);

    // Assert
    Assert.AreEqual(getDeliveryResponseDto.Items.Count, deliveryEntity.Items.Count);

    for (int i = 0; i < deliveryEntity.Items.Count; i++)
    {
      Assert.AreEqual(getDeliveryResponseDto.Items[i].Title       , deliveryEntity.Items[i].Title       );
      Assert.AreEqual(getDeliveryResponseDto.Items[i].Description , deliveryEntity.Items[i].Description );
      Assert.AreEqual(getDeliveryResponseDto.Items[i].Units       , deliveryEntity.Items[i].Units       );
      Assert.AreEqual(getDeliveryResponseDto.Items[i].GramsPerUnit, deliveryEntity.Items[i].GramsPerUnit);
    }
  }

  [TestMethod]
  public void Constructor_DeliveryEntity_PickupAtFilled()
  {
    // Arrange
    DeliveryEntity deliveryEntity = new
    (
      id: Guid.NewGuid(),
      items: [
        new DeliveryItemEntity
        (
          title       : "test title",
          description : "test description",
          units       : 2,
          gramsPerUnit: 1000
        ),
      ],
      pickupAt: new DeliveryAddressEntity
      (
        contact: "test pickup contact",
        phone  : "test pickup phone",
        address: "test pickup address"
      ),
      deliverTo: new DeliveryAddressEntity
      (
        contact: "test delivery contact",
        phone  : "test delivery phone",
        address: "test delivery address"
      ),
      status: DeliveryStatus.Processing
    );

    // Act
    GetDeliveryResponseDto getDeliveryResponseDto = new(deliveryEntity);

    // Assert
    Assert.IsNotNull(deliveryEntity.PickupAt);
    Assert.AreEqual(getDeliveryResponseDto.PickupAt.Contact, deliveryEntity.PickupAt.Contact);
    Assert.AreEqual(getDeliveryResponseDto.PickupAt.Phone  , deliveryEntity.PickupAt.Phone  );
    Assert.AreEqual(getDeliveryResponseDto.PickupAt.Address, deliveryEntity.PickupAt.Address);
  }

  [TestMethod]
  public void Constructor_DeliveryEntity_DeliverToFilled()
  {
    // Arrange
    DeliveryEntity deliveryEntity = new
    (
      id: Guid.NewGuid(),
      items: [
        new DeliveryItemEntity
        (
          title       : "test title",
          description : "test description",
          units       : 2,
          gramsPerUnit: 1000
        ),
      ],
      pickupAt: new DeliveryAddressEntity
      (
        contact: "test pickup contact",
        phone  : "test pickup phone",
        address: "test pickup address"
      ),
      deliverTo: new DeliveryAddressEntity
      (
        contact: "test delivery contact",
        phone  : "test delivery phone",
        address: "test delivery address"
      ),
      status: DeliveryStatus.Processing
    );

    // Act
    GetDeliveryResponseDto getDeliveryResponseDto = new(deliveryEntity);

    // Assert
    Assert.IsNotNull(deliveryEntity.DeliverTo);
    Assert.AreEqual(getDeliveryResponseDto.DeliverTo.Contact, deliveryEntity.DeliverTo.Contact);
    Assert.AreEqual(getDeliveryResponseDto.DeliverTo.Phone  , deliveryEntity.DeliverTo.Phone);
    Assert.AreEqual(getDeliveryResponseDto.DeliverTo.Address, deliveryEntity.DeliverTo.Address);
  }
}
