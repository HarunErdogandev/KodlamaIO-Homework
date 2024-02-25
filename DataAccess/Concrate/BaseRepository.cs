using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    //Kullanılacak
    public class BaseRepository<TEntity> : IGenericRepository<TEntity>
    {
        public void Add(TEntity entity)
        {
            Console.WriteLine(" Eklendi");
        }

        public void Delete(TEntity entity)
        {
            Console.WriteLine(" Silindi");

        }

        public void Update(TEntity entity)
        {
            Console.WriteLine(" Güncellendi");

        }
    }
}
