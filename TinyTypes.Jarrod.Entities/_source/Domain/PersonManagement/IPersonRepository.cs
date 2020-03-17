namespace TinyTypes.Jarrod.Entities.Domain.PersonManagement
{
    public interface IPersonRepository
    {
        Person Find(PersonId id);
    }
}