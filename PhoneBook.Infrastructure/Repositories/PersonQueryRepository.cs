using System.Collections.Generic;
using Dapper;
using PhoneBook.Core.Entities;
using PhoneBook.Core.Interfaces.Repositories;
using PhoneBook.Infrastructure.Managers;

namespace PhoneBook.Infrastructure.Repositories;

public class PersonQueryRepository : IQueryRepository<Person>
{
    private readonly DatabaseManager _databaseManager;

    public PersonQueryRepository(DatabaseManager databaseManager)
    {
        _databaseManager = databaseManager;
    }


    public IEnumerable<Person> GetAll()
    {
        using var connection = _databaseManager.CreateConnection();

        const string sql = "SELECT * FROM persons";

        var persons = connection.Query<Person>(sql);
        return persons;
    }

    public IEnumerable<Person> GetByLastName(string lastName)
    {
        using var connection = _databaseManager.CreateConnection(); 
        const string sql = """
                           SELECT *
                           FROM persons
                           WHERE persons.last_name LIKE (lastName)
                           """;
        var persons = connection.Query<Person>(sql);

        return persons; 
    }

    public Person GetById(long id)
    {
        throw new System.NotImplementedException();
    }
}