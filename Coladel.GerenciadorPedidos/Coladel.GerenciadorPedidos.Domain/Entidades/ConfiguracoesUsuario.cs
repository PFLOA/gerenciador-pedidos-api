using Coladel.GerenciadorPedidos.Domain.Entidades;

namespace Coladel.GerenciadorAulas.Domain.Entidades
{
    public class ConfiguracoesUsuario : Entity
    {
        public bool NomeConfig { get; set; }
        public int Valor { get; set; }
    }
}
