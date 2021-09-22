using System;
using System.Collections.Generic;
using UserManagement.Domain;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace UserManagement.Repository
{
    public class Repository<T> : IRepositorys<T> where T : BaseEntity
    {
        ApplicationContexts contexts;
        DbSet<T> entities;
        public Repository(ApplicationContexts _context)
        {
            contexts = _context;
            entities = contexts.Set<T>();
        }
        void IRepositorys<T>.Delete(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException();
            }
            contexts.Remove(entity);
            contexts.SaveChanges();
        }

        T IRepositorys<T>.Get(long id)
        {
            return entities.SingleOrDefault(t=> t.Id==id);
        }

        IEnumerable<T> IRepositorys<T>.GetAll()
        {
            return entities.AsEnumerable();
        }

        int IRepositorys<T>.Insert(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException();
            }
            contexts.Add(entity);
            return contexts.SaveChanges();
        }

        void IRepositorys<T>.Remove(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException();
            }
            contexts.Remove(entity);
            //contexts.SaveChanges();
        }

        void IRepositorys<T>.SaveChanges()
        {
            contexts.SaveChanges();
        }

        void IRepositorys<T>.Update(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException();
            }
            contexts.Update(entity);
            contexts.SaveChanges();
        }
    }
}