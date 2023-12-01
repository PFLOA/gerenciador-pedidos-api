﻿using A4S.Core;
using A4S.ERP.Domain.Entidades;

namespace A4S.ERP.Domain.Interface
{
    public interface IControleBoletosRepository : IRepositoryBase<ControleBoletos>
    {
        ControleBoletos BuscarControleBoletos();
    }
}
