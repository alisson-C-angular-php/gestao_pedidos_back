using gestaopedidos.Models;
using gestaopedidos.RepositoryImpl;
using gestaopedidos.Service;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading.Tasks;

namespace gestaopedidos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrdersRepositoryImpl ordersRepository;
       private readonly AzureServiceBusSender _serviceBusSender;

        public OrdersController(OrdersRepositoryImpl orders  /*, AzureServiceBusSender serviceBusSender */)
        {
            ordersRepository = orders;/*
            _serviceBusSender = serviceBusSender;*/
        }

        [HttpPost("orders")]
        public async Task<IActionResult> InsertOrders([FromBody] OrdersModel orders)
        {
            try
            {
                await ordersRepository.AddAsync(orders);

             /*   string messageBody = JsonSerializer.Serialize(orders);
                await _serviceBusSender.SendMessageAsync(messageBody);
             */
                return Ok(new
                {
                    status = 200,
                    message = "Pedido criado com sucesso"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    status = 500,
                    error = ex.Message
                });
            }
        }

        [HttpGet("orders")]
        public async Task<IActionResult> GetOrders()
        {
            try
            {
                var orders = await ordersRepository.GetAllAsync();
                return Ok(new
                {
                    status = 200,
                    data = orders,
                    message = "Todos os pedidos registrados"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    status = 500,
                    error = ex.Message
                });
            }
        }

        [HttpGet("orders/{id}")]
        public async Task<IActionResult> GetOrders(int id)
        {
            try
            {
                var orders = await ordersRepository.GetByIdAsync(id);
                if (orders == null)
                {
                    return NotFound(new { status = 404, message = "Pedido não encontrado" });
                }

                return Ok(new
                {
                    status = 200,
                    data = orders,
                    message = "Pedido encontrado com sucesso"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    status = 500,
                    error = ex.Message
                });
            }
        }
    }
}
