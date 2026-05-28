namespace PhoneBook.Core.Entities;

public sealed class Person
{
    public long Id { get; }
    public string FirstName { get; }
    public string? Patronymic { get; }
    public bool IsDeleted { get; }

    public Person(long id, string firstName, string? patronymic, bool isDeleted)
    {
        Id = id;
        FirstName = firstName;
        Patronymic = patronymic;
        IsDeleted = isDeleted;
    }
    
}