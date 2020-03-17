namespace TinyTypes.Jarrod.Entities.Domain.PersonManagement
{
    public interface IAddressRepository
    {
        Address Find(AddressId id);
    }
}