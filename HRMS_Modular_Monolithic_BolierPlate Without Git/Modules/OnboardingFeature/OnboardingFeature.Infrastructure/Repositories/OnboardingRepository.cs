using HRMS.Core.Postgres.Data;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using OnboardingFeature.Application.Interfaces;

namespace OnboardingFeature.Infrastructure.Repositories
{
    public class OnboardingRepository : IOnboardingRepository
    {
        private readonly PostgresDbContext _context;

        public OnboardingRepository(PostgresDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OnboardingTask>> GetByEmployeeIdAsync(Guid employeeId)
        {
            return await _context.Set<OnboardingTask>()
                .Where(t => t.EmployeeId == employeeId)
                .OrderBy(t => t.Order)
                .ToListAsync();
        }

        public async Task<OnboardingTask?> GetByIdAsync(Guid id)
        {
            return await _context.Set<OnboardingTask>().FindAsync(id);
        }

        public async Task<OnboardingTask> AddAsync(OnboardingTask task)
        {
            _context.Set<OnboardingTask>().Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<OnboardingTask> UpdateAsync(OnboardingTask task)
        {
            _context.Set<OnboardingTask>().Update(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var task = await GetByIdAsync(id);
            if (task == null) return false;
            
            _context.Set<OnboardingTask>().Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
