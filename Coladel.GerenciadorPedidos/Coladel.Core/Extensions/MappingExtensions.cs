using System;
using System.Reflection;

namespace A4S.Core.Extensions
{
    public static class MappingExtensions
    {
        public static void MappingProperties(this Object fromObjeto, object toObjeto)
        {
            ForeachProperties(Comparator, fromObjeto, toObjeto);
        }
        public static void MappingDifferenceProperties(this Object fromObjeto, object toObjeto)
        {
            ForeachProperties(DifferenceComparator, fromObjeto, toObjeto);
        }
        private static void ForeachProperties(Action<Object, PropertyInfo, Object> action, Object fromObjeto, object toObjeto)
        {
            foreach (var properties in fromObjeto.GetType().GetProperties())
            {
                action.Invoke(fromObjeto, properties, toObjeto);
            }
        }
        private static void Comparator(Object fromObjeto, PropertyInfo propertyInfo, object toObjeto)
        {
            var found = toObjeto.GetType().GetProperty(propertyInfo.Name);

            if (found != null)
            {
                var pName = found.PropertyType.Name;

                if (pName == propertyInfo.PropertyType.Name)
                    found.SetValue(toObjeto, propertyInfo.GetValue(fromObjeto));
                else
                    propertyInfo.GetValue(fromObjeto).MappingProperties(found.GetValue(toObjeto));

            }
        }
        private static void DifferenceComparator(Object fromObjeto, PropertyInfo propertyInfo, object toObjeto)
        {
            var found = toObjeto.GetType().GetProperty(propertyInfo.Name);

            if (propertyInfo.GetValue(fromObjeto) is null) return;

            if (found.GetValue(toObjeto) != propertyInfo.GetValue(fromObjeto)) found.SetValue(toObjeto, propertyInfo.GetValue(fromObjeto));
        }
    }
}
