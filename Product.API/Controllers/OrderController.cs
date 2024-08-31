using Microsoft.AspNetCore.Mvc;
using Product.Core.IRepositories;

public class OrderController : ControllerBase
{
    private readonly IOrderRepository orderRepository;

    public OrderController(IOrderRepository orderRepository)
    {
        this.orderRepository = orderRepository;
    }

    [HttpGet("user/{userId}/orders")]
    public async Task<IActionResult> GetUserOrders(int userId)
    {
        var orders = await orderRepository.GetAllOrdersByUserIdAsync(userId);
        if (orders == null || !orders.Any())
        {
            return NotFound($"No orders found for user with ID {userId}");
        }

        return Ok(orders);
    }
}
