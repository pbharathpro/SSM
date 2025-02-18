using SSM.Models.ViewModel;

namespace SSM.Services.Interface
{
    public interface IUserService
    {
        Task<List<UserModel>> GetAll();
        Task<UserModel> GetById(Guid userId);
        Task<UserModel> CreateUser(UserModel userModel);
        Task<bool> DeleteUserById(Guid userId);
    }
}
