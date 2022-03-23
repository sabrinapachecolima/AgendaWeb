namespace AgendaWeb.Presentation.Controllers
{
    internal class Terefa
    {
        public Terefa()
        {
        }

        public Guid IdTarefa { get; internal set; }
        public string Nome { get; internal set; }
        public DateTime Data { get; internal set; }
        public TimeSpan Hora { get; internal set; }
        public string Descricao { get; internal set; }
        public int Prioridade { get; internal set; }
    }
}