using System.Collections.Generic;

namespace HelloWorldRepository.Repository
{
    public interface IRepository<T>
    {
        int Create(T obj);

        List<T> Retrieve();

        T Retrieve(int id);

        bool Update(T obj);

        bool Delete(int id);
    }
}