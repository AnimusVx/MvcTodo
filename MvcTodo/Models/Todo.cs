using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcTodo.Models
{
    public class Todo
    {
        public enum PriortyText
        {
            Relax,
            Secondary,
            Immediate
        }

        public enum IsCompleteText
        {
            [Description("Cheers!!")]
            Cheers,
            [Display(Name = "Continued")]
            Continued,
            [Display(Name = "Initial")]
            Initial
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string TodoText { get; set; }
        [Required]
        public DateTime Deadline { get; set; } = DateTime.Now;
        [Required]
        public IsCompleteText IsComplete { get; set; } = IsCompleteText.Initial;
        [Required]
        // [Range(1, 3, ErrorMessage = "Select prioraty correct")]
        // public byte Priority { get; set; } = 1;
        public PriortyText Priorty { get; set; } = PriortyText.Relax;

        //[NotMapped]
        //public string PrioratyText { get { if (Priority == 1) return "Relax"; else if (Priority == 2) return "Secondary"; return "Immediate"; }}

        //[NotMapped]
        //public string CompleteText { get { if (IsComplete) return "Cheers!";  return "Not Coplete Yet!!"; } }
    }
}
