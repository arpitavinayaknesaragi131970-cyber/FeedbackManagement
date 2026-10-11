
using System.ComponentModel.DataAnnotations;

namespace FeedbackManagement.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5, ErrorMessage = "Select a rating from 1 to 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        [StringLength(500, MinimumLength = 5)]
        public string Comments { get; set; } = "";
    }
}
