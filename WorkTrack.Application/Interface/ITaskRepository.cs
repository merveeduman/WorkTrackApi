using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkTrack.Domain.Entities;

namespace WorkTrack.Application.Interfaces;

public interface ITaskRepository
{
    Task<List<WorkTask>> GetAllAsync();

    Task<WorkTask?> GetByIdAsync(int id);

    Task AddAsync(WorkTask task);
    Task DeleteAsync(WorkTask task);

    Task SaveChangesAsync();
}