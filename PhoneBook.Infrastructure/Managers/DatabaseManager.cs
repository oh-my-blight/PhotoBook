using Npgsql;
using PhoneBook.Infrastructure.Options;

namespace PhoneBook.Infrastructure.Managers;

public class DatabaseManager
{
    private readonly DatabaseOptions _databaseOptions;


    public DatabaseManager(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }


    public NpgsqlConnection CreateConnection() => new NpgsqlConnection(_databaseOptions._connectionString);
}