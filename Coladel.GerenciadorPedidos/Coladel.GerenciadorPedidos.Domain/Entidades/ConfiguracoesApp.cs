using A4S.ERP.Domain.Entidades;

namespace A4S.ERP.Domain.Entidades
{
    public class ConfiguracoesApp : Entity
    {
        public bool NomeConfig { get; set; }
        public int Valor { get; set; }
    }
}
