using PhoneBook.Core.DTOs;
using PhoneBook.Core.Entities;

namespace PhoneBook.Core.Interfaces.Repositories;

public interface ICommandRepository<T>
{
    T Create(T dto);
    bool Update(long phoneId, T dto);
    bool Delete(long phoneId);
}