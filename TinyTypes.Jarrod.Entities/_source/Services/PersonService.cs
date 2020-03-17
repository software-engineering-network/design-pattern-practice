using TinyTypes.Jarrod.Entities.Domain;

namespace TinyTypes.Jarrod.Entities.Services
{
    public class PersonService : IPersonService
    {
        #region IPersonService

        public void AssignAddress(PersonId personId, AddressId addressId)
        {
            /*
             * var person = _unitOfWork.PersonRepository.Find(personId);
             * var address = _unitOfWork.AddressRepository.Find(addressId);
             *
             * person.Add(address);
             *
             * _unitOfWork.PersonRepository.Update(person);
             * _unitOfWork.Commit();
             */
        }

        #endregion
    }
}
