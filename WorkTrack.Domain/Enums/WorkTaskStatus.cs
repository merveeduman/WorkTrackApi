using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTrack.Domain.Entities;

public enum WorkTaskStatus
{
    Pending,
    InProgress,
    Completed,
    Cancelled
}