using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        // [Key] implicit covered if the property name is Id or DiaryEntryId (in this case)
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

    }
}