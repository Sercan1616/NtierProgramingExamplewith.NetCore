using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.Dto.Interfaces;

namespace Udemy.TodoAppNTier.Dto.WorkDtos
{
    public class WorkCreateDto : IDto
    {
        public string Defination { get; set; }

        public bool IsCompleted { get; set; }
    }
}
