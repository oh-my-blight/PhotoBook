namespace PhoneBook.Core.DTOs;

public record PersonDto
{
    public required string FirstName { get; init; }
    public string? Patronymic { get; init; }
    public required string LastName { get; init; }
}