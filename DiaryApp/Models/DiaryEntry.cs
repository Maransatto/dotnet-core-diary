namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        // the name of the unique identifier needs to be Id or we could add
        // a notation [Key] at the top (similar to decorators in NestJS)
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

    }
}