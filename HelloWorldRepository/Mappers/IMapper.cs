using System;

namespace HelloWorldRepository.Mappers
{
    public interface IMapper<T, out T1>
    {
        T1 Map(T obj);

        T Map(Object m);
    }
}