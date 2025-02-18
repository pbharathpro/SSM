using AutoMapper;
using SSM.Models.ViewModel;
using SSM.Repositories.Entity;

namespace SSM.Services
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Subscription, SubscriptionModel>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();

            CreateMap<Subscription, SubscriberDetailsModel>().ReverseMap();

        }
    }

}
