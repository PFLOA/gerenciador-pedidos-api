namespace A4S.ERP.Domain.Enum
{
    public enum StatusPedido
    {
        TODOS = 12,
        EM_ANDAMENTO = 0,
        ENTREGUE = 1,
        CANCELAR = 2,
        ATRASO = 3,
        PROGRAMADO = 4,
        AGUARDANDO_PAGAMENTO = 5,
        AGUARDANDO_TRANSPORTADORA = 6,
        SOLICITAR_TRANSPORTE = 7,
        PEDIDO_RETIRADA = 8,
        PEDIDO_SEPARACAO = 9,
        AGUARDANDO_FORNECEDOR = 10
    }
}
