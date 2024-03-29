﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Traversal.DataAccess.EntityFramework.Repository
{
    public class GenericRepository<T, TContext> : IGenericDal<T> where T : class, new() where TContext : DbContext, new()
    {
        public async Task Delete(T entity)
        {
            using (var context = new TContext())
            {
                context.Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetList()
        {
            using (var context = new TContext())
            {
                var datas = await context.Set<T>().ToListAsync();
                return datas;
            }
        }

        public async Task Insert(T entity)
        {
            using (var context = new TContext())
            {
                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }

        }

        public void Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }

        public async Task<T> GetById(int id)
        {
            using (var context = new TContext())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }

        public async Task<List<T>> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using (var context = new TContext())
            {
                return await context.Set<T>().Where(filter).ToListAsync();
            }
        }
    }
}