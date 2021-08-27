using System;

namespace Coladel.GerenciadorPedidos.Domain.Entidades
{
    public class Entity
    {
        public short Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
