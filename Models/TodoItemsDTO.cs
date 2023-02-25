namespace TodoApi.Models
{
    public class TodoItemsDTO
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public bool IsCompleted { get; set; }
    }
}
