using System.ComponentModel.DataAnnotations;

namespace SwingQuestBackEnd.Models
{
    public class Users
    {
        [Key]
        public int userId { get; set; }

        [Required]
        public String name { get; set; } = "";

        [Required]
        public String answer { get; set; } = "";
    }
}
