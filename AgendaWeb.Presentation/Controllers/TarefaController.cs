using AgendaWeb.Infra.Data.Entities;
using AgendaWeb.Infra.Data.Interfaces;
using AgendaWeb.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaWeb.Presentation.Controllers
{


    public class TarefaController : Controller
    {
        /// Método para abrir uma página (View)
        public IActionResult Cadastro()
        {
            return View();
        }
        // metodo para receber os dados para cadastro
        [HttpPost]
        public IActionResult Cadastro(TarefaCadastroModel model, [FromServices] ITarefaRepositories tarefaRepository)
        {
            // verifica se todos os campos preenchidos no formulario passaram nas regras de validação (se há erros de validação) 

            if (ModelState.IsValid)
            {
                try
                {
                    // criando um objeto da entidade tarefa
                    var tarefa = new Tarefa();

                    // capturandoi os dados preenchido no formulario
                    tarefa.IdTarefa = Guid.NewGuid();
                    tarefa.Nome = model.Nome;
                    tarefa.Data = DateTime.Parse(model.Data);
                    tarefa.Hora = TimeSpan.Parse(model.Hora);
                    tarefa.Descricao = model.Descricao;
                    tarefa.Prioridade = int.Parse(model.Prioridade);

                    // gravando no banco de dados   
                    tarefaRepository.Inserir(tarefa);
                    TempData["MensagemSucesso"] = $"A tarefa '{tarefa.Nome}' foi cadastrada com sucesso!";

                    // limpar os campos dos formularios 
                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    // mensagem de erro 
                    TempData["MensagemErro"] = $"Falha ao cadastra tarefa: {e.Message}";
                }
            }
            else
            {
                TempData["MensagemAlerta"] = $" Ocorreram erros de validação mo preechimento dos dados, por favor verifique o.";
            }
            return View();
        }
        /// Método para abrir uma página (View)
        public IActionResult Consulta()
        {
            return View();
        }
        // esse HTTPPOSTE e uma plaquinha do metodo para dizer que ele e está esperando o  submt
        [HttpPost] 
        public IActionResult Consulta(TarefaConsultaModel model) /// Método para receber o evento de SUBMIT do formulário
        {
            return View();
        }
    }
}
