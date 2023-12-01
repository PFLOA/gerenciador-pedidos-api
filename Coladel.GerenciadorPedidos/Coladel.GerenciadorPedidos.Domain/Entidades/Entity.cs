using System;

namespace A4S.ERP.Domain.Entidades
{
    public class Entity : EntityBase
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
