namespace A4S.ERP.Domain.Entidades
{
    public class TransporteNf : EntityBase
    {
        public int ModFrete { get; set; }
        public int Volumes { get; set; }
        public short? TransportadoraId { get; set; }
        public string Marca { get; set; }

        public virtual Transportadora Transportadora { get; set; }
        public virtual NotaFiscal NotaFiscal { get; set; }
    }
}
