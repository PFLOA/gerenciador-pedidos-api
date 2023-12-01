<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;
using A4S.Core;
using A4S.ERP.Domain.Enum;

namespace A4S.ERP.Domain.Interface
=======
﻿using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.Core;
using Coladel.GerenciadorAulas.Domain.Enum;

namespace Coladel.GerenciadorAulas.Domain.Interface
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
{
    public interface IEnvioEmailRepository : IRepository<EnvioEmail>
    {
        EnvioEmail BuscarPorTipoEmail(TipoEmail tipoEmail);
    }
}
