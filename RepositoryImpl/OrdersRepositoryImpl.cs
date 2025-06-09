using gestaopedidos.Context;
using gestaopedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace gestaopedidos.RepositoryImpl
{
    public class OrdersRepositoryImpl
    {
        private readonly AppDbContext _context;

        public OrdersRepositoryImpl(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrdersModel>> GetAllAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<OrdersModel> GetByIdAsync(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task AddAsync(OrdersModel orders)
        {
            _context.Orders.Add(orders);
            await _context.SaveChangesAsync();
        }

      
    }
}
