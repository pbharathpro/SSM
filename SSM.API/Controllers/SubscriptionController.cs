using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSM.Models.ViewModel;
using SSM.Repositories.Entity;
using SSM.Services.Interface;

namespace SSM.API.Controllers
{
    [ApiController]
    [Route("api/subscriptions")]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;

        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllSubscriptions()
        {
            List<SubscriberDetailsModel> subscriptions = await _subscriptionService.GetAllSubscriptions();
            return Ok(subscriptions);
        }
        [HttpGet("getById{{id}}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            SubscriberDetailsModel subscription = await _subscriptionService.GetSubscriptionById(id);
            if (subscription == null)
            {
                return NotFound();
            }
            return Ok(subscription);
        }

        [HttpPost("addSubscription")]
        public async Task<IActionResult> AddSubscription([FromBody] SubscriptionModel subscriptionModel)
        {
            SubscriptionModel subscribed = await _subscriptionService.AddSubscription(subscriptionModel);
            return Ok(subscribed);
        }


        [HttpDelete("deleteSubscription{{id}}")]
        public async Task<IActionResult> DeleteSubscription(Guid id)
        {
            bool isDeleted = await _subscriptionService.DeleteSubscription(id);
            if (!isDeleted)
                return NotFound(new { message = "User not found" });

            return Ok(new { message = "User deleted successfully" });

        }
    }


}
