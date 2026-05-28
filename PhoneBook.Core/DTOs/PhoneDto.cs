namespace PhoneBook.Core.DTOs;

public record PhoneDto
{
    public required long PersonId { get; init; }
    public required long PhoneTypeId { get; init; }
    public required string CountryArea { get; init; }
    public required string AreaCode { get; init; }
    public required string Number { get; init; }
}