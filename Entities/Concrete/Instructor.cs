using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Instructor: IEntity
{
    public int InstructorId { get; set; }
    public string? InstructorName { get; set; }

    //Relational Prop
    public virtual List<Course> Courses { get; set; }


}
