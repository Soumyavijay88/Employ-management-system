using HotChocolate;
using HotChocolate.Types;
using HRMS.Shared.Domain.Entity;
using OnboardingFeature.Application.Interfaces;

namespace OnboardingFeature.GraphQL.Mutations
{
    public class OnboardingMutations
    {
        public async Task<OnboardingTask> CreateOnboardingTask(
            Guid employeeId,
            string title,
            string description,
            int order,
            string category,
            [Service] IOnboardingRepository repository)
        {
            var task = new OnboardingTask
            {
                Id = Guid.NewGuid(),
                EmployeeId = employeeId,
                Title = title,
                Description = description,
                Order = order,
                Category = category,
                IsCompleted = false,
                CreatedOn = DateTime.UtcNow
            };
            
            return await repository.AddAsync(task);
        }

        public async Task<OnboardingTask> UpdateOnboardingTask(
            Guid id,
            bool isCompleted,
            [Service] IOnboardingRepository repository)
        {
            var task = await repository.GetByIdAsync(id);
            if (task == null) throw new Exception("Task not found");
            
            task.IsCompleted = isCompleted;
            task.CompletedOn = isCompleted ? DateTime.UtcNow : null;
            task.ModifiedOn = DateTime.UtcNow;
            
            return await repository.UpdateAsync(task);
        }

        public async Task<bool> DeleteOnboardingTask(
            Guid id,
            [Service] IOnboardingRepository repository)
        {
            return await repository.DeleteAsync(id);
        }
    }
}
