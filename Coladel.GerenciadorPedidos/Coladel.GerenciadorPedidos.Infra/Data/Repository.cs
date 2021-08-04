using Coladel.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace Coladel.GerenciadorPedidos.Infra.Data
{
    public class Repository<TEntidade> : IRepository<TEntidade> where TEntidade : class
    {
        protected DbSet<TEntidade> Set { get; private set; }
        protected ApplicationDbContext context;
        public Repository(ApplicationDbContext dbContext)
        {
            context = dbContext;
            Type tipo = typeof(TEntidade);

            MappingProperties(dbContext, tipo);
        }

        private void Comparator(Object fromObjeto, PropertyInfo propertyInfo, Type toObjeto)
        {
            var toObjetoName = toObjeto.Name;
            var found = toObjetoName == propertyInfo.Name ? propertyInfo : null;

            if (found != null)
                Set = propertyInfo.GetValue(fromObjeto) as DbSet<TEntidade>;
        }

        public void MappingProperties(Object fromObjeto, Type toObjeto)
        {
            foreach (var properties in fromObjeto.GetType().GetProperties())
            {
                Comparator(fromObjeto, properties, toObjeto);
            }
        }
    }
}
