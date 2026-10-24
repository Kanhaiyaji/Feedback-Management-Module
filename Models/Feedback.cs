using System;
using System.ComponentModel.DataAnnotations;

namespace FeedbackManagement.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [Required, StringLength(60, MinimumLength = 2)]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }
        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; }
        [Required, StringLength(80)]
        public string Subject { get; set; }
        [Required, Range(1, 5)]
        public int? Rating { get; set; }
        [Required, StringLength(500, MinimumLength = 10)]
        public string Comments { get; set; }
        public DateTime SubmittedAt { get; set; }
    }
}
