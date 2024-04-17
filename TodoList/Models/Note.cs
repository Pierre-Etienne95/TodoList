namespace TodoList.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contenu { get; set; }
        public bool Priorite { get; set; } = false;
    }
}
