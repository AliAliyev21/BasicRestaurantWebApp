using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication3.Entities;

namespace WebApplication3.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync(); 
        Task<Product> GetProductByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task<bool> DeleteAsync(int id);
    }
}
