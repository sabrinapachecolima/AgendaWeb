using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaWeb.Infra.Data.Interfaces;
using AgendaWeb.Infra.Data.Entities;

namespace AgendaWeb.Infra.Data.Interfaces
{
   public  interface ITarefaRepositories : IBaseRepositories<Tarefa>
    {

        List<Tarefa>ConsultaPorData(DateTime dataMin, DateTime dataMax);

    }
}
