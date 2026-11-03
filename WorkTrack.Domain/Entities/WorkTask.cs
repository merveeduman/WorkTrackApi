using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTrack.Domain.Entities;

public class WorkTask
{
    public int Id { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public WorkTaskStatus Status { get; private set; }

    private WorkTask() { }

    public WorkTask(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Task title cannot be empty.");

        Title = title;
        Status = WorkTaskStatus.Pending;
    }

    public void Start()
    {
        if (Status != WorkTaskStatus.Pending)
            throw new InvalidOperationException("Only pending tasks can be started.");

        Status = WorkTaskStatus.InProgress;
    }

    public void Complete()
    {
        if (Status != WorkTaskStatus.InProgress)
            throw new InvalidOperationException("Only in-progress tasks can be completed.");

        Status = WorkTaskStatus.Completed;
    }
    public void UpdateTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Task title cannot be empty.");

        if (title.Length > 200)
            throw new ArgumentException("Task title cannot exceed 200 characters.");

        Title = title;
    }
}