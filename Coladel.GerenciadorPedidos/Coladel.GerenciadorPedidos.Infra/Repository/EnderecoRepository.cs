<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;

namespace A4S.ERP.Infra.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDbContext dbContext) : base(dbContext) { }
=======
﻿using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorAulas.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;

namespace Coladel.Infra.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(UserDbContext dbContext) : base(dbContext) { }
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
    }
}
