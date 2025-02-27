﻿using CRM_for_English_School.Validation;
using System.ComponentModel.DataAnnotations;

namespace CRM_for_English_School.Models
{
    public class PersonModel
    {
        [Required(ErrorMessage = "Isn't specified")]
        [StringLength(maximumLength:30,ErrorMessage = "The field's length must be less than 30 symbols!")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Isn't specified")]
        [StringLength(maximumLength: 30, ErrorMessage = "The field's length must be less than 30 symbols!")]
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}