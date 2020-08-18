using System;
using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore
{
   public interface IBookAppService:ICrudAppService<
       BookDto,
       Guid,
       PagedAndSortedResultRequestDto,
       CreateUpdateBookDto,
       CreateUpdateBookDto
       >
    {

    }
}
