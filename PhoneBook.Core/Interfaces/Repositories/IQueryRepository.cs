using System.Collections.Generic;
using PhoneBook.Core.DTOs;
using PhoneBook.Core.Entities;

namespace PhoneBook.Core.Interfaces.Repositories;

public interface IQueryRepository<T>
{
    IEnumerable<T> GetAll();
    IEnumerable<T> GetByLastName(string lastName);
    T GetById(long id);
}