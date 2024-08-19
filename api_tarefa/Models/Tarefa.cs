namespace APITarefas.Model
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }
        public bool Feito { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;


    }
}