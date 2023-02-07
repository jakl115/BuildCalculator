using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BuildCalculator.DataAccess;
using System.Security.Claims;
using Microsoft.AspNetCore.Components;

namespace BuildCalculator.Data
{
    public class ItemService
    {

        private readonly ItemContext _context;
        private NavigationManager _navigationManager;

        public ItemService(ItemContext context, NavigationManager navigation)
        {
            _context = context;
            _navigationManager = navigation;
        }

        public async Task<ICollection<Item>> GetAllItems()
        {
            return await _context.items.ToListAsync();
        }

        // POST: Items/Create
        public async Task Create(Item item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("items");
        }

        // POST: Items/Delete/5
        public async Task Delete(int id)
        {
            if (_context.items == null)
            {
                _navigationManager.NavigateTo("items");
            }
            var item = await _context.items.FindAsync(id);
            if (item != null)
            {
                _context.items.Remove(item);
                await _context.SaveChangesAsync();
            }

            _navigationManager.NavigateTo("items");
        }
    }
}
