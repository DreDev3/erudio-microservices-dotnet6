using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);

        List<Person> FindAll();

        Person FindByID(long id);
        void Delete(long id);

    }
}
