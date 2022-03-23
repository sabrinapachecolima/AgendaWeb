using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaWeb.Infra.Data.Entities;
using AgendaWeb.Infra.Data.Interfaces;
using Dapper;

namespace AgendaWeb.Infra.Data.Repositories
{
    public  class TarefaRepositories : ITarefaRepositories
    {

        private string connectionString;

        // contrutor para receber o valor da connectionString
        public TarefaRepositories(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Alterar(Tarefa entity)
        {
            var query = @"
                UPDATE TAREFA
                SET
                   NOME = @Nome,
                   DATA = @Data,
                   DESCRICAO = @Descricao,
                   PRIORIDADE = @Prioridade
                WHERE
                  IDTAREFA = @IdTarefa
               ";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }
        }

        public List<Tarefa> Consultar()
        {
            var query = @"
            SELECT* FROM TAREFA
           ORDER BY DATA
              ";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection
                .Query<Tarefa> (query)
                      .ToList();
            }
        }

        public void Excluir(Tarefa entity)
        {
            var query = @"
            DELETE FROM TAREFA
            WHERE IDTAREFA = @IdTarefa
             ";
            
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }
        }

        public void Inserir(Tarefa entity)
        {
            var query = @"
               INSERT INTO TAREFA(
               IDTAREFA,
               NOME,
               DATA,
               HORA,
               DESCRICAO,
               PRIORIDADE)
               VALUES(
                @IdTarefa,
                @Nome,
                @Data,
                @Hora,
                @Descricao,
                @Prioridade)
              ";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }
        }

        public Tarefa ObterPorId(Guid id)
        {
            var query = @"
            SELECT* FROM TAREFA
           WHERE IDTAREFA = @id
            ";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection
                .Query<Tarefa> (query, new { id })
                      .FirstOrDefault();
            }
        }

        public List<Tarefa> ConsultaPorData(DateTime dataMin, DateTime dataMax)
        {
            var query = @"
            SELECT* FROM TAREFA
           WHERE DATA BETWEEN @dataMin AND @dataMax
           ORDER BY DATA
             ";
            using (var connection = new SqlConnection(connectionString))
            {
                return connection
                .Query<Tarefa>(query, new { dataMin, dataMax })
                      .ToList();
            }
        }
    }
}
