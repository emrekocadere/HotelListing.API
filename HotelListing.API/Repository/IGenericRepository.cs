﻿namespace HotelListing.API.Repository
{
    public interface IGenericRepository<T>where T : class {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T Entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T Entity);
    

    }
}
