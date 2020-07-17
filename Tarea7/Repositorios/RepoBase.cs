using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Tarea7.Models;

namespace Tarea7.Repositorios
{
    public abstract class RepoBase<TEntity> : IRepoBase<TEntity> where TEntity : class
    {
        private readonly Contexto _repoContext;
        public RepoBase(Contexto repoContext)
        {
            _repoContext = repoContext;
        }

        public IQueryable<TEntity> BuscarPorCondicion(Expression<Func<TEntity, bool>> expression)
        {
            return _repoContext.Set<TEntity>().Where(expression).AsNoTracking();
        }

        public async Task<TEntity> BuscarPorId(int? id)
        {
            var obj = await _repoContext.Set<TEntity>().FindAsync(id);
            return obj;
        }

        public IQueryable<TEntity> BuscarTodo()
        {
            return _repoContext.Set<TEntity>().AsNoTracking();
        }

        public async Task Crear(TEntity entity)
        {
            try
            {
                await _repoContext.Set<TEntity>().AddAsync(entity);
                await _repoContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Eliminar(TEntity entity)
        {
            try
            {
                _repoContext.Set<TEntity>().Remove(entity);
                await _repoContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Modificar(TEntity entity)
        {
            try
            {
                _repoContext.Set<TEntity>().Update(entity);
                await _repoContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
