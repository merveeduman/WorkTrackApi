
namespace WorkTrack.Api.Models
{
    public class WorkTask
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
    }
}
