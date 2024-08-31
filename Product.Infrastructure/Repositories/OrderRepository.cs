using Microsoft.EntityFrameworkCore;
using Product.Core.Entities;
using Product.Core.IRepositories;
using Product.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext dbContext;

        public OrderRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Orders>> GetAllOrdersByUserIdAsync(int userId)
        {
            return await dbContext.Orders
                .Where(order => order.UserId == userId)
                .Include(order => order.User) 
                .ToListAsync();
        }
    }
}
