
using System.ComponentModel.DataAnnotations;
namespace AgendaWeb.Presentation.Models
{
    public class TarefaCadastroModel
    {
        // REQUIRED (campo obrigatorio) 
         [Required(ErrorMessage = "Por favor, informe o nome da tarefa.")]
        // atributos para a tela do sistema, com o mesma propriedades do Entities 
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data da tarefa.")]
        public string Data { get; set; }

        [Required(ErrorMessage = "Por favor, informe a hora da tarefa.")]
        public string Hora { get; set; }

        [Required(ErrorMessage = "Por favor, informe a descrição da tarefa.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Por favor, informe a prioridade da tarefa .")]
        public string Prioridade { get; set; }

    }
}
