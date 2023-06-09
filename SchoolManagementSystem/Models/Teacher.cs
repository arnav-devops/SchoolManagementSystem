﻿using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Hobbies { get; set; }
    }
}
