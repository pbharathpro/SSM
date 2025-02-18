using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SSM.Models.ViewModel;
using SSM.Repositories.Entity;
using SSM.Repositories.Interface;
using SSM.Services.Interface;

namespace SSM.Services.Implementation
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository _subscriptionRepository;
        private readonly IMapper _mapper;
        private readonly IPricingService _pricingService;


        public SubscriptionService(ISubscriptionRepository subscriptionRepository,IMapper mapper, IPricingService pricingService)
        {
            _subscriptionRepository = subscriptionRepository;
            _mapper = mapper;
            _pricingService = pricingService;
        }

        public async Task<List<SubscriberDetailsModel>> GetAllSubscriptions()
        {
            List<Subscription> subscriptions = await _subscriptionRepository.GetAllSubscriptions();
            List<SubscriberDetailsModel> subscriptionModel = _mapper.Map<List<SubscriberDetailsModel>>(subscriptions);
            return subscriptionModel;
        }

        public async Task<SubscriberDetailsModel> GetSubscriptionById(Guid id)
        {
            Subscription subscription = await _subscriptionRepository.GetSubscriptionById(id);
            SubscriberDetailsModel subscriptionModel = _mapper.Map<SubscriberDetailsModel>(subscription);
            return subscriptionModel;
        }

        public async Task<SubscriptionModel> AddSubscription(SubscriptionModel subscriptionModel)
        {
            Subscription subs = _mapper.Map<Subscription>(subscriptionModel);
            subs.Id = Guid.NewGuid();
            subs.StartDate = DateTime.Now;
            subs.EndDate = subs.StartDate.AddMonths(subscriptionModel.DurationMonths); 
            subs.RenewalDate = subs.EndDate.AddMonths(-1); 
            subs.Cost = _pricingService.CalculatePrice(subscriptionModel.DurationMonths);
            //subs.UserId = subscriptionModel.UserId; 
            Subscription subscribed = await _subscriptionRepository.AddSubscription(subs);
            return _mapper.Map<SubscriptionModel>(subscribed);
        }

        public async Task<bool> DeleteSubscription(Guid id)
        {
           return await _subscriptionRepository.DeleteSubscription(id);
        }
       
    }

}
