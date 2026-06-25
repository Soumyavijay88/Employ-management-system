using HRMS.Shared.Domain.Entity;

namespace OnboardingFeature.Application.Interfaces
{
    public interface IOnboardingRepository
    {
        Task<IEnumerable<OnboardingTask>> GetByEmployeeIdAsync(Guid employeeId);
        Task<OnboardingTask?> GetByIdAsync(Guid id);
        Task<OnboardingTask> AddAsync(OnboardingTask task);
        Task<OnboardingTask> UpdateAsync(OnboardingTask task);
        Task<bool> DeleteAsync(Guid id);
    }
}
