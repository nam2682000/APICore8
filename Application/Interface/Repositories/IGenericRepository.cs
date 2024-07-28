﻿using Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Repositories
{
    public interface IGenericRepository<T,TKey> where T : class, IEntity<TKey>
    {
        Task Add(T obj, bool commit = true);

        Task<T?> Get(TKey id, string includeProperties = "");

        Task<T?> Get(Expression<Func<T, bool>> filter, string includeProperties = "");

        Task<List<T>> Get(string? includeProperties = "");

        Task Delete(T obj, bool commit = true);

        Task Update(T obj, bool commit = true);

        Task Commit();

        T FirstOrDefault(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, string includeProperties = "");

        bool Any(Expression<Func<T, bool>>? filter = null);

        Task<ICollection<T>> QueryAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, string includeProperties = "", int pageSize = 0,
                                int page = -1);


        Task<ICollection<TResult>> QueryAndSelectAsync<TResult>(Expression<Func<T, int, TResult>> selector, Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, string includeProperties = "",
                                int pageSize = 0, int page = -1) where TResult : class;


        Task TruncateTable(string tableName);
    }
}
