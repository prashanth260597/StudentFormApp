using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentFormApp.Models
{
    [Table("Students1")]   // <-- TABLE MAPPING GOES HERE
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime? Dob { get; set; }
    }
}