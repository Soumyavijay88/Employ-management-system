using HotChocolate;
using HotChocolate.Types;
using HRMS.Shared.Domain.Entity;
using OnboardingFeature.Application.Interfaces;

namespace OnboardingFeature.GraphQL.Queries
{
    public class OnboardingQueries
    {
        public async Task<IEnumerable<OnboardingTask>> GetOnboardingTasks(
            Guid employeeId,
            [Service] IOnboardingRepository repository)
        {
            return await repository.GetByEmployeeIdAsync(employeeId);
        }

        public async Task<OnboardingTask?> GetOnboardingTask(
            Guid id,
            [Service] IOnboardingRepository repository)
        {
            return await repository.GetByIdAsync(id);
        }
    }
}
