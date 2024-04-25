using RMS.Application.Common.Interfaces;
using RMS.Application.Common.Interfaces.Repositories;
using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services
{
    public class MenuItemService(IBaseRepository<MenuItem> menuItemRepository) : IBaseService<MenuItem>
    {
        private readonly IBaseRepository<MenuItem> _menuItemRepository = menuItemRepository;

        public async Task<MenuItem> CreateAsync(MenuItem menuItem, CancellationToken token = default)
        {
            return await _menuItemRepository.CreateAsync(menuItem, token);

        }

        public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
        {
            var menuItem = await _menuItemRepository.GetAsync(id);
            if (menuItem == null)
            {
                return false;
            }
            return await _menuItemRepository.DeleteAsync(menuItem, token);
        }

        public async Task<IEnumerable<MenuItem>> GetAllAsync(CancellationToken token = default)
        {
            return await _menuItemRepository.GetAllAsync(token);
        }

        public async Task<MenuItem> GetAsync(int id, CancellationToken token = default)
        {
            return await _menuItemRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(MenuItem menuItem, CancellationToken token = default)
        {
            var IsMenuItemExist = await _menuItemRepository.GetAsync(menuItem.Id, token);

            if (IsMenuItemExist == null)
            {
                return false;
            }
            return await _menuItemRepository.UpdateAsync(menuItem, token);
        }
    }
}
