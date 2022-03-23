using AgendaWeb.Infra.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace AgendaWeb.Presentation.Models
{
    // classe de modelo de dados para conmsulta de tarefa
    public class TarefaConsultaModel
    {
        [Required(ErrorMessage = "Por favor, infomer a data de inicio")]
        public string  DateMin { get; set; }

        [Required(ErrorMessage = "Por favor, infomer a data de termino")]
        public string DateMax { get; set; }

        //lista para exibir as tarefas obtidas do banco de dados na pagina de consulta (dentro de um GRUID (table))

        public List<Tarefa>? Tarefa { get; set; }     

    }
}
