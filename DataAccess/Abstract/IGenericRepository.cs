﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericRepository<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
