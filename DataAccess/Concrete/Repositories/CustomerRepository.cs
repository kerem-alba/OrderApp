using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
namespace DataAccess.Concrete.EntityFramework
{
    public class CustomerRepository : EfEntityRepositoryBase<Customer, AppDbContext>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
