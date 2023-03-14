using MiskStartupSchool.DTO;

namespace MiskStartupSchool.Services
{
    public interface IApplicationRepo
    {
        Task<ApplicationDto> Get();
        Task<bool> Update(ApplicationDto application);
        Task<string> Add(ApplicationDto application);
        Task<bool> Remove(string Id);
    }
}
