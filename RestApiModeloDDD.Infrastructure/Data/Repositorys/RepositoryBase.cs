using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        protected readonly DDDSqlContext _context;
        protected readonly DbSet<T> _entities;

        protected RepositoryBase(DDDSqlContext context)

        {
            _context = context;
            _entities = context.Set<T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
            SaveChanges();
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
            SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetByID(Guid id)
        {
           return _entities.Find(id);
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }
        public int SaveChanges() => _context.SaveChanges();

        public void Dispose() => _context?.Dispose();
    }
}
