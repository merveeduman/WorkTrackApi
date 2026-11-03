using WorkTrack.Application.DTOs;
using WorkTrack.Application.Interfaces;
using WorkTrack.Domain.Entities;

namespace WorkTrack.Application.Services;

public class TaskService
{
    private readonly ITaskRepository _repository;

    public TaskService(ITaskRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<TaskDto>> GetAllAsync()
    {
        var tasks = await _repository.GetAllAsync();

        return tasks.Select(MapToDto).ToList();
    }

    public async Task<TaskDto?> GetByIdAsync(int id)
    {
        var task = await _repository.GetByIdAsync(id);

        return task is null ? null : MapToDto(task);
    }

    public async Task<TaskDto> CreateAsync(string title)
    {
        var task = new WorkTask(title);

        await _repository.AddAsync(task);
        await _repository.SaveChangesAsync();

        return MapToDto(task);
    }

    private static TaskDto MapToDto(WorkTask task)
    {
        return new TaskDto(
            task.Id,
            task.Title,
            task.Status.ToString()
        );
    }
    public async Task<bool> UpdateTitleAsync(int id, string title)
    {
        var task = await _repository.GetByIdAsync(id);

        if (task is null)
            return false;

        task.UpdateTitle(title);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var task = await _repository.GetByIdAsync(id);

        if (task is null)
            return false;

        await _repository.DeleteAsync(task);
        await _repository.SaveChangesAsync();

        return true;
    }
}