using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HelloWorldMVC.Models.Helpers
{
    static class ModelHelper
    {
        public static void Map(Object o, Object providedObject)
        {
            if (o == null || providedObject == null) return;
            
            Type t = o.GetType();

            List<string> fields = t.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly).Select(x => x.Name).ToList();

            if (fields.Any())
                foreach (string field in fields)
                {
                    PropertyInfo propertyInfo = t.GetProperty(field);
                    propertyInfo.SetValue(o, providedObject.GetType().GetProperty(field).GetValue(providedObject, null), null);
                }
        }
    }
}