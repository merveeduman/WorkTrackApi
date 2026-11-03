using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace WorkTrack.Application.DTOs;

public record CreateTaskRequest(
    [Required]
    [StringLength(200, MinimumLength = 1)]
    string Title
);