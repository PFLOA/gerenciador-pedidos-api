using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace A4S.ERP.Domain.Entidades
{
    public class ControleBoletos : EntityBase
    {
        public int NossoNumero { get; set; }

        [NotMapped]
        public string NumeroDocumento { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();

        [NotMapped]
        public string NossoNumeroFormatado
        {
            get
            {
                var length = NossoNumero.ToString().Length;
                string formatado = "";

                for (int i = 0; i < (12 - length); i++)
                {
                    formatado += "0";
                }

                return formatado + NossoNumero.ToString();
            }
        }
    }
}
