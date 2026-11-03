using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTrack.Application.DTOs;

public record TaskDto(
    int Id,
    string Title,
    string Status
);