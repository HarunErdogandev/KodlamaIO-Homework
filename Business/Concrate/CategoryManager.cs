using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;
    private readonly ICourseService _courseService;
    public CategoryManager(ICategoryDal categoryDal, ICourseService courseService)
    {
        _categoryDal = categoryDal;
        _courseService = courseService;

    }
    public void Add(Category entity)
    {
        //İş kuralları yazılır
        _categoryDal.Add(entity);
    }

    public void Delete(Category entity)
    {
        _categoryDal.Delete(entity);
    }

    public void Update(Category entity)
    {
        _categoryDal.Update(entity);
    }

    public int CourseCategoryCount(int id)
    {
       return _courseService.CategoryCauntFunc(id);
    }
}
