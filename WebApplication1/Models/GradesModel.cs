using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class GradesModel
    {
        [Range(0.00, 100.00,
            ErrorMessage = "Price must be between 0.00 and 100.00")]
        [Required]
        public int Assignments{ get; set; }
        [Range(0.00, 100.00,
            ErrorMessage = "Price must be between 0.00 and 100.00")]
        [Required]
        public int Group { get; set; }
        [Range(0.00, 100.00,
            ErrorMessage = "Price must be between 0.00 and 100.00")]
        [Required]
        public int Quizzes { get; set; }
        [Range(0.00, 100.00,
            ErrorMessage = "Price must be between 0.00 and 100.00")]
        [Required]

        public int Exams { get; set; }
        [Range(0.00, 100.00,
            ErrorMessage = "Price must be between 0.00 and 100.00")]
        [Required]
        public int Intex { get; set; }


    }
}
