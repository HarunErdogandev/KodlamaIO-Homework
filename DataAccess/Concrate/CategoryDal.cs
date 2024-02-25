using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class CategoryDal:ICategoryDal
    {
        public List<Category> Categories;
        public CategoryDal()
        {
            Categories = new List<Category>()
            {
                new Category(){CategoryId=1,CategoryName="Programlama"}
            };
        }

        public void Add(Category entity)
        {
            Categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            var categoryToDelete= Categories.FirstOrDefault(x => x.CategoryId == entity.CategoryId);
            if (categoryToDelete != null)
            {
                Categories.Remove(categoryToDelete);

            }
        }

        public void Update(Category entity)
        {
            var categoryToUpdate=Categories.FirstOrDefault(x=>x.CategoryId==entity.CategoryId);
            if (categoryToUpdate!=null)
            {
                categoryToUpdate.CategoryName = entity.CategoryName;
                
            }
        }
    }
}
