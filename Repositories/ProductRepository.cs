using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Data;

namespace RepositoryPatternDemo.Repositories
{
    public class ProductRepository : Repository<Product>, IRepository<Product>
    {
        public ProductRepository(AppDbContext context) : base(context) { }
    }
}