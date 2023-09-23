using Microsoft.EntityFrameworkCore;

namespace NWind.Models
{
    public class RepositoryCustomer
    {
        private NorthwindContext _context;
        public RepositoryCustomer(NorthwindContext context)
        {
            _context = context;
        }
        //(from o in _context.Orders select o.OrderId).ToList();
        public List<string> GetAllCustomerId()
        {
            List<string> custIds = new List<string>();
            foreach (var customer in _context.Customers)
            {
                custIds.Add(customer.CustomerId);
            }
            return custIds;
        }
        public Customer FindCustomerById(String id)
        {
            Customer customer = _context.Customers.Find(id);
            return customer;
        }
        public List<Order> GetCustomerOrders(String id)
        {
            List<Customer> ordersWithOrderDetails = _context.Customers.Include(d => d.Orders).ToList();
            Customer customer = ordersWithOrderDetails.FirstOrDefault(x => x.CustomerId == id);
            return customer.Orders.ToList();
        }
    }
}
