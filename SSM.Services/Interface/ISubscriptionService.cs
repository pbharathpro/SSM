using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSM.Models.ViewModel;

namespace SSM.Services.Interface
{
    public interface ISubscriptionService
    {
        Task<List<SubscriberDetailsModel>> GetAllSubscriptions();
        Task<SubscriberDetailsModel> GetSubscriptionById(Guid id);
        Task<SubscriptionModel> AddSubscription(SubscriptionModel subscription);
        Task<bool> DeleteSubscription(Guid id);
    }

}
