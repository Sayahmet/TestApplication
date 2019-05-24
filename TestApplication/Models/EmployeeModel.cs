using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class EmployeeModel
    {
        public long Id { get; set; }

        [Required]
        [Display(Name = "Имя")]
        [StringLength(255, ErrorMessage = "Имя не может быть длиннее 255 символов")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        [StringLength(255, ErrorMessage = "Фамилия не может быть длиннее 255 символов")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Отчество")]
        [StringLength(255, ErrorMessage = "Отчество не может быть длиннее 255 символов")]
        public string Patronomyc { get; set; }

        [Required]
        [Display(Name = "Год рождения")]
        public int Birthday { get; set; }

        [Required]
        [Display(Name = "Должность")]
        [StringLength(255, ErrorMessage = "Должность не может быть длиннее 255 символов")]
        public string Position { get; set; }
    }
}