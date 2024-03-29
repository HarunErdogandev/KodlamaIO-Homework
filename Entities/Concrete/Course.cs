﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Course : IEntity
{
    public int CourseId { get; set; }
    public int? CategoryId { get; set; }
    public int? InstructorId { get; set; }
    public string? CourseName { get; set; }
    public string? CourseDecription { get; set; }
    public string? CourseImage { get; set; }
    public string? InstructorImage { get; set; }

    //Relational properties

    public Instructor Instructor { get; set; }
    public Category Category { get; set; }



}
