using System.ComponentModel.DataAnnotations;

namespace MinimalApiSample.Web;

public sealed class DeliveryAddressDto
{
  [Required]
  public required string Contact { get; init; }

  [Required]
  public required string Phone { get; init; }

  [Required]
  public required string Address { get; init; }

  public DeliveryAddressEntity ToEntity() => new
  (
    contact: Contact,
    phone  : Phone,
    address: Address
  );
}
