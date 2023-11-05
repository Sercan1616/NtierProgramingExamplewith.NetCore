using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.Dto.Interfaces;
using Udemy.TodoAppNTier.Dto.WorkDtos;

namespace Udemy.TodoAppNTier.Business.Interfaces
{
    public interface IWorkService
    {
        Task<List<WorkListDto>> GetAll();

        Task Create(WorkCreateDto dto);

        Task<IDto> GetById<IDto>(int id);

        Task Remove(int id);

        Task Update(WorkUpdateDto dto);
    }
}
