using System;
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

        const string sql = """
                           SELECT
                               persons.id, persons.first_name, 
                               persons.patronymic, persons.last_name,
                               persons.is_deleted
                           FROM persons
                           """;

        var persons = connection.Query<Person>(sql);
        return persons;
    }

    public IEnumerable<Person> GetByLastName(string lastName)
    {
        using var connection = _databaseManager.CreateConnection();
        const string sql = """
                           SELECT 
                               persons.id, persons.first_name, 
                               persons.patronymic, persons.last_name,
                               persons.is_deleted
                           FROM persons
                           WHERE persons.last_name LIKE @LastName
                           """;
        var persons = connection.Query<Person>(sql, new { LastName = $"%{lastName}" });

        return persons;
    }

    public Person GetById(long id)
    {
        using var connection = _databaseManager.CreateConnection();

        const string sql = """
                           SELECT
                               persons.id, persons.first_name, 
                               persons.patronymic, persons.last_name,
                               persons.is_deleted
                           FROM persons
                           WHERE persons.id = @id
                           """;

        var person = connection.QueryFirstOrDefault<Person>(sql, new { id });

        return person ?? throw new InvalidOperationException($"Пользователь с таким {id} не найден.");
    }
}