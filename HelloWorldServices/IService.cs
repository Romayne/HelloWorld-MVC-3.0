using System;
using System.Collections.Generic;

namespace HelloWorldServices
{
    public interface IService
    {
        int Create(Object o);

        List<Object> Retrieve();

        Object Retrieve(int id);

        bool Update(Object o);

        bool Delete(Object o);
    }
}