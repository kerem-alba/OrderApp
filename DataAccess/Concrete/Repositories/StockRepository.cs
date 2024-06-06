using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
namespace DataAccess.Concrete.EntityFramework
{
    public class StockRepository : EfEntityRepositoryBase<Stock, AppDbContext>, IStockRepository
    {
        public StockRepository(AppDbContext context) : base(context)
        {
        }
    }
}
