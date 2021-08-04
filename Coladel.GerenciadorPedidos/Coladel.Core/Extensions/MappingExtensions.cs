using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Coladel.Core.Extensions
{
    public static class MappingExtensions
    {
        private static void Comparator(Object fromObjeto, PropertyInfo propertyInfo, object toObjeto)
        {
            var found = toObjeto.GetType().GetProperty(propertyInfo.Name);

            if (found != null)
                found.SetValue(toObjeto, propertyInfo.GetValue(fromObjeto));
        }

        public static void MappingProperties(this Object fromObjeto, object toObjeto)
        {
            foreach (var properties in fromObjeto.GetType().GetProperties())
            {
                Comparator(fromObjeto, properties, toObjeto);
            }
        }
    }
}
