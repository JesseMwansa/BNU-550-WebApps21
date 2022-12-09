﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_Contoso.Models
{
    public enum Grades
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Nullable<Grades> Grade { get; set; }

        //Navigation properties
        public Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
