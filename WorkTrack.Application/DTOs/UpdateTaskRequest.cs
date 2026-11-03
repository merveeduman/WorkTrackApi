using System.ComponentModel.DataAnnotations;

namespace WorkTrack.Application.DTOs;

public record UpdateTaskRequest(
    [Required]
    [StringLength(200, MinimumLength = 1)]
    string Title
);