using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSM.Repositories.Entity;
using SSM.Repositories.Interface;

namespace SSM.Repositories.Implementation
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly AppDbContext _context;

        public SubscriptionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Subscription>> GetAllSubscriptions()
        {
            return await _context.Subscriptions.ToListAsync();
        }

        public async Task<Subscription> GetSubscriptionById(Guid subscriptionId)
        {
            return await _context.Subscriptions.FirstOrDefaultAsync(s => s.Id == subscriptionId);
        }

        public async Task<Subscription>AddSubscription(Subscription subscription)
        {
            await _context.Subscriptions.AddAsync(subscription);
            await _context.SaveChangesAsync();
            return subscription;
        }


        public async Task<bool> DeleteSubscription(Guid id)
        {
            var subscription = await _context.Subscriptions.FindAsync(id);
            if (subscription != null)
            {
                _context.Subscriptions.Remove(subscription);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}