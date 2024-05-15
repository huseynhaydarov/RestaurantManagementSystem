using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;

namespace RMS.Application.Services
{
    public class OrderItemService(IBaseRepository<OrderItem> orderItemRepository)
    {
        private readonly IBaseRepository<OrderItem> _orderItemRepository = orderItemRepository;

        public async Task<OrderItem> CreateAsync(OrderItem orderItem, CancellationToken token = default)
        {
            return await _orderItemRepository.CreateAsync(orderItem, token);
        }

        
        public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
        {
            var menuItem = await _orderItemRepository.GetAsync(id);
            if (menuItem == null)
            {
                return false;
            }
            return await _orderItemRepository.DeleteAsync(menuItem, token);
        }


        public async Task<bool> UpdateAsync(OrderItem orderItem, CancellationToken token = default)
        {
            var isOrderItemExist = await _orderItemRepository.GetAsync(orderItem.Id, token);

            if (isOrderItemExist == null)
            {
                return false;
            }
            return await _orderItemRepository.UpdateAsync(orderItem, token); ;
        }

       public async Task<IEnumerable<OrderItem>> GetAllAsync(CancellationToken token)
        {
            return await _orderItemRepository.GetAllAsync(token);
        }

        public async Task<OrderItem> GetAsync(int id, CancellationToken token)
        {
            return await _orderItemRepository.GetAsync(id, token);
        }
    }
}
