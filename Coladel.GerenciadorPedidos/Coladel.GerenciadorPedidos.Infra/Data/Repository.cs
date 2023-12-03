using A4S.Core;
using A4S.ERP.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace A4S.ERP.Infra.Data
{
    public class Repository<TEntidade> : IRepository<TEntidade> where TEntidade : Entity
    {
        protected DbSet<TEntidade> Set { get; private set; }
        protected AppDbContext context;

        public Repository(AppDbContext dbContext)
        {
            context = dbContext;
            Type tipo = typeof(TEntidade);
            MappingProperties(dbContext, tipo);
        }

        public virtual TEntidade BuscarPorGuid(Guid guid)
        {
            var result = Set.First(p => p.Guid == guid);
            return result;
        }
        public TEntidade Criar(TEntidade entidade)
        {
            var result = Set.Add(entidade);
            context.SaveChanges();
            return result.Entity;
        }
        public short Alterar(TEntidade entidade)
        {
            var result = Set.Update(entidade);
            context.SaveChanges();
            return result.Entity.Id;
        }
        public bool Remover(TEntidade entidade)
        {
            var result = Set.Remove(entidade);

            if (result is null) return false;
            context.SaveChanges();

            return true;
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

        public void Importar(Func<string[], TEntidade> func, Stream csv)
        {
            StreamReader sr = new StreamReader(csv);

            while (sr.Peek() >= 0)
            {
                string[] campos = sr.ReadLine().Split(';');

                var entidade = func.Invoke(campos);

                Set.Add(entidade);

                context.SaveChanges();
            }
        }

        public void Importar(Stream arq)
        {
            StreamReader sr = new StreamReader(arq);

            var json = sr.ReadToEnd();

            List<TEntidade> items = JsonConvert.DeserializeObject<List<TEntidade>>(json);

            items.ForEach(entidade => Criar(entidade));
        }
    }

    public class RepositoryBase<TEntidade> : IRepositoryBase<TEntidade> where TEntidade : EntityBase
    {
        protected DbSet<TEntidade> Set { get; private set; }
        protected AppDbContext context;

        public RepositoryBase(AppDbContext dbContext)
        {
            context = dbContext;
            Type tipo = typeof(TEntidade);
            MappingProperties(dbContext, tipo);
        }

        public TEntidade Criar(TEntidade entidade)
        {
            var result = Set.Add(entidade);
            context.SaveChanges();
            return result.Entity;
        }
        public short Alterar(TEntidade entidade)
        {
            var result = Set.Update(entidade);
            context.SaveChanges();
            return result.Entity.Id;
        }

        public bool Remover(TEntidade entidade)
        {
            var result = Set.Remove(entidade);

            if (result is null) return false;
            context.SaveChanges();

            return true;
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

        public void Importar(Func<string[], TEntidade> func, Stream csv)
        {
            StreamReader sr = new StreamReader(csv);

            while (sr.Peek() >= 0)
            {
                string[] campos = sr.ReadLine().Split(';');

                var entidade = func.Invoke(campos);

                Set.Add(entidade);

                context.SaveChanges();
            }
        }

        public void Importar(Stream arq)
        {
            StreamReader sr = new StreamReader(arq);

            var json = sr.ReadToEnd();

            List<TEntidade> items = JsonConvert.DeserializeObject<List<TEntidade>>(json);

            items.ForEach(entidade => Criar(entidade));
        }
    }
}
