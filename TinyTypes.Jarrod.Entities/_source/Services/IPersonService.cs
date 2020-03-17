using TinyTypes.Jarrod.Entities.Domain;

namespace TinyTypes.Jarrod.Entities.Services
{
    public interface IPersonService
    {
        void AssignAddress(PersonId personId, AddressId addressId);
    }
}
