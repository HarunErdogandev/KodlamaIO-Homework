using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal= courseDal;
    }
    public void Add(Course entity)
    {
        throw new NotImplementedException();
    }

    public int CategoryCauntFunc(int id)
    {
        return _courseDal.FunctionName(id);
    }

    public void Delete(Course entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Course entity)
    {
        throw new NotImplementedException();
    }
}
