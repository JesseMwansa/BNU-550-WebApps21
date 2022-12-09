﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Razor_Contoso.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
