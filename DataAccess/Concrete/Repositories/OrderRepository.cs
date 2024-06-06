using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
namespace DataAccess.Concrete.EntityFramework
{
    public class OrderRepository : EfEntityRepositoryBase<Order, AppDbContext>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }
    }
}
