using ClaimManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimManagement.Core.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ClaimManagementContext _context;
        protected DbSet<T> _table = null;

        public BaseRepository()
        {
            _context = new ClaimManagementContext();
            _table = _context.Set<T>();
        }

        public bool Delete(object id)
        {
            try
            {
                T obj = _table.Find(id);
                _table.Remove(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(T obj)
        {
            try
            {
                if (_context.Entry(obj).State == EntityState.Detached)
                {
                    _table.Attach(obj);
                }
                _table.Remove(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetById(object id)
        {
            try
            {
                return _table.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public T Insert(T obj)
        {
            try
            {
                _table.Add(obj);
                return obj;
            }
            catch
            {
                return null;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(T obj)
        {
            try
            {
                _table.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}