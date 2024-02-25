// See https://aka.ms/new-console-template for more information
using Business.Concrate;
using DataAccess.Concrate;
using Entities.Concrete;

Console.WriteLine("Hello, World!");



//Nornalde UI Yani Sunum Katmanı Direk DataAcces Layer katmanına erişemez Test Amaçlı Kulllanılmıştır

CategoryManager categoryManager =new CategoryManager(new CategoryDal(),new CourseManager(new CourseDal()));

Console.WriteLine(categoryManager.CourseCategoryCount(1));

