using A4S.Core;
using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Reflection;

namespace A4S.ERP.Infra.Data
{
    public class UserRepository<TEntidade> : IRepository<TEntidade> where TEntidade : Entity
    {
        protected DbSet<TEntidade> Set { get; private set; }

        protected UserDbContext context;

        public UserRepository(UserDbContext dbContext)
        {
            context = dbContext;
            Type tipo = typeof(TEntidade);
            MappingProperties(dbContext, tipo);
        }
        public short Alterar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public TEntidade BuscarPorGuid(Guid guid)
        {
            throw new NotImplementedException();
        }

        public TEntidade Criar(TEntidade entidade)
        {
            var result = Set.Add(entidade);
            context.SaveChanges();

            return result.Entity;
        }

        public bool Remover(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        private void Comparator(Object fromObjeto, PropertyInfo propertyInfo, Type toObjeto)
        {
            var toObjetoName = toObjeto.Name;
            var found = toObjetoName == propertyInfo.Name ? propertyInfo : null;

            if (found != null)
                Set = propertyInfo.GetValue(fromObjeto) as DbSet<TEntidade>;
        }

        private void MappingProperties(Object fromObjeto, Type toObjeto)
        {
            foreach (var properties in fromObjeto.GetType().GetProperties())
            {
                Comparator(fromObjeto, properties, toObjeto);
            }
        }

        public void Importar(Stream arq)
        {
            throw new NotImplementedException();
        }

        public void Importar(Func<string[], TEntidade> func, Stream csv)
        {
            throw new NotImplementedException();
        }
    }
}
