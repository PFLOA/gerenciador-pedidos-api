using System;
using System.Runtime.Serialization;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class Entity
    {
        [IgnoreDataMember]
        public short Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
