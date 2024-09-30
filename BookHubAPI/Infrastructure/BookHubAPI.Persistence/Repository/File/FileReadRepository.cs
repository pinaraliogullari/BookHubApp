using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHubAPI.Persistence.Repository;

public class FileReadRepository : ReadRepository<BookHubAPI.Domain.Entities.File>, IFileReadRepository
{
    public FileReadRepository(BookHubDbContext context) : base(context)
    {
    }
}
