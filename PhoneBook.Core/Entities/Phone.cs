namespace PhoneBook.Core.Entities;

public sealed class Phone
{
    public long Id { get; }
    public long PersonId { get; }
    public long PhoneTypeId { get; }
    public string CountryCode { get; }
    public string AreaCode { get; }
    public string Number { get; }

    public Phone(long id, long personId, long phoneTypeId, string countryCode, string areaCode, string number)
    {
        Id = id;
        PersonId = personId;
        PhoneTypeId = phoneTypeId;
        CountryCode = countryCode;
        AreaCode = areaCode;
        Number = number;
    }
}