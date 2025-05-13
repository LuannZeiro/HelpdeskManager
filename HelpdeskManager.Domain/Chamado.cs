
namespace HelpdeskManager.Domain
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string Prioridade { get; set; }
        public string Setor { get; set; }
        public DateTime DataAbertura { get; set; }
        public string Responsavel { get; set; }
    }
}
