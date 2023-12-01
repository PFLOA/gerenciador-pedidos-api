<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;

namespace A4S.ERP.Infra.Repository
{
    public class EmailRepository : Repository<Email>, IEmailRepository
    {
        public EmailRepository(AppDbContext dbContext) : base(dbContext) { }
=======
﻿using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorAulas.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;

namespace Coladel.Infra.Repository
{
    public class EmailRepository : Repository<Email>, IEmailRepository
    {
        public EmailRepository(UserDbContext dbContext) : base(dbContext) { }
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
    }
}
