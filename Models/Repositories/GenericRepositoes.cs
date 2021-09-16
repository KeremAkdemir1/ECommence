using E_Commence.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace E_Commence.Models.Repositories
{
    public class GenericRepositoes<T> where T : class, new()
    {
        Context cnt = new Context();
        public List<T> TList()
        {
            return cnt.Set<T>().ToList();
        }

        public void TAdd(T c)
        {
            cnt.Set<T>().Add(c);
            cnt.SaveChanges();
        }

        public void TDelete(T c)
        {
            cnt.Set<T>().Remove(c);
            cnt.SaveChanges();
        }

        public void TUpdate(T c)
        {
            cnt.Set<T>().Update(c);
            cnt.SaveChanges();
        }
        public T TGetById(int id)
        {
            return cnt.Set<T>().Find(id);
        }

        public List<T> TList(string p)
        {
            return cnt.Set<T>().Include(p).ToList();
        }
        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return cnt.Set<T>().Where(filter).ToList();
        }
    }
}
