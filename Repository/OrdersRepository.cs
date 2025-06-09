using System.Collections.Generic;
using System.Threading.Tasks;
using gestaopedidos.Models;


namespace gestaopedidos.Repository
{
   

    public interface IOrdersRepository
    {
        Task<IEnumerable<OrdersModel>> GetAllAsync();
        Task<OrdersModel> GetByIdAsync(int id);
        Task AddAsync(OrdersModel orders);
    
    }

}
