using Microsoft.EntityFrameworkCore;
using WorkTrack.Application.Interfaces;
using WorkTrack.Domain.Entities;
using WorkTrack.Infrastructure.Persistence;

namespace WorkTrack.Infrastructure.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly WorkTrackDbContext _context;

    public TaskRepository(WorkTrackDbContext context)
    {
        _context = context;
    }

    public async Task<List<WorkTask>> GetAllAsync()
    {
        return await _context.WorkTasks
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<WorkTask?> GetByIdAsync(int id)
    {
        return await _context.WorkTasks
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(WorkTask task)
    {
        await _context.WorkTasks.AddAsync(task);
    }

    public Task DeleteAsync(WorkTask task)
    {
        _context.WorkTasks.Remove(task);
        return Task.CompletedTask;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    
}