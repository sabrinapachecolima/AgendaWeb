﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.Interfaces
{
    public interface IBaseRepositories<TEntity>
        where TEntity : class
    {

        void Inserir(TEntity entity);
        void Alterar(TEntity entity);
        void Excluir(TEntity entity);

        List<TEntity> Consultar();
        TEntity ObterPorId(Guid id);
    }
}
