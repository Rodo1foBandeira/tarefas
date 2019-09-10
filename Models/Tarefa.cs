using System;

namespace tarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DtAtividade { get; set; }
        public DateTime? DtEntrega { get; set; }
        public DateTime? DtLimiteEntrega { get; set; }
        public string Diagnostico { get; set; }
    }
}