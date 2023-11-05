using Udemy.TodoAppNTier.Dto.Interfaces;

namespace Udemy.TodoAppNTier.Dto.WorkDtos
{
    public class WorkListDto : IDto
    {
        public int Id { get; set; }

        public string Defination { get; set; }

        public bool IsCompleted { get; set; }
    }
}
