namespace PhoneBook.Infrastructure.Options;

public record DatabaseOptions
{
    public required string _connectionString { get; init; }
}