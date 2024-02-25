using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Category: IEntity
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }

    //Relational properties

    public virtual List<Course> Courses { get; set; }
}
