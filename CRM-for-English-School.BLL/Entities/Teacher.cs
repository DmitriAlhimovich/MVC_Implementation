﻿using CRM_for_English_School.BLL.Enums;
using System.Collections.Generic;

namespace CRM_for_English_School.BLL.Entities
{
    public class Teacher : Person
    {
        public int Id { get; set; }
        public string MainSpecialization { get; set; }
        public string GraduatedFrom { get; set; }
        public Degree Degree { get; set; }
        public List<StudentsGroup> Groups { get; set; }
    }
}
