using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSM.Repositories.Entity;

namespace SSM.Repositories.Interface
{
    public interface ISubscriptionRepository
    {
        Task<List<Subscription>> GetAllSubscriptions();
        Task<Subscription> GetSubscriptionById(Guid id);
        Task<Subscription> AddSubscription(Subscription subscription);
        Task<bool> DeleteSubscription(Guid id);
    }

}
