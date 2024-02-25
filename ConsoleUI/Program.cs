// See https://aka.ms/new-console-template for more information
using DataAccess.Concrate;
using Entities.Concrete;

Console.WriteLine("Hello, World!");



//Nornalde UI Yani Sunum Katmanı Direk DataAcces Layer katmanına erişemez Test Amaçlı Kulllanılmıştır

CategoryDal categoryDal = new();

foreach (var item in categoryDal.Categories)
{
    Console.WriteLine(item.CategoryName);
}
Category category = new();
category.CategoryId=1;
category.CategoryName = "Yeni Kurs";

categoryDal.Update(category);

foreach (var item in categoryDal.Categories)
{
    Console.WriteLine(item.CategoryName);
}

categoryDal.Delete(category);

foreach (var item in categoryDal.Categories)
{
    Console.WriteLine(item.CategoryName);
}