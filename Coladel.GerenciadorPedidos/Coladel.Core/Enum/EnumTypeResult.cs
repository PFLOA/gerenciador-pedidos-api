using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Coladel.Core.Enum
{
    public enum EnumTypeResult
    {
        [Description("OK")]
        Ok,

        [Description("Criado")]
        Created,

        [Description("Aceito")]
        Accepted,

        [Description("Entrada Inválida")]
        InvalidInput,

        [Description("Não Encontrado")]
        NotFound,

        [Description("Proibido")]
        Forbidden,

        [Description("Erro Interno")]
        InternalError,

        [Description("Serviço Indisponível")]
        ServiceUnavaliable
    }
}
