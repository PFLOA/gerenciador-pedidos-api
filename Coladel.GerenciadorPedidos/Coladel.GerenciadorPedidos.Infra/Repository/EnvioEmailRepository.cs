<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    internal class EnvioEmailRepository : Repository<EnvioEmail>, IEnvioEmailRepository
    {
        public EnvioEmailRepository(AppDbContext dbContext) : base(dbContext) { }
=======
﻿using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorAulas.Domain.Enum;
using Coladel.GerenciadorAulas.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using System.Linq;

namespace Coladel.Infra.Repository
{
    internal class EnvioEmailRepository : Repository<EnvioEmail>, IEnvioEmailRepository
    {
        public EnvioEmailRepository(UserDbContext dbContext) : base(dbContext) { }
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6

        public EnvioEmail BuscarPorTipoEmail(TipoEmail tipoEmail) => Set.FirstOrDefault(p => p.TipoEmail == tipoEmail);
    }
}
