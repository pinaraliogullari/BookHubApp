﻿using BookHubAPI.Application.Repositories;
using BookHubAPI.Domain.Entities;
using BookHubAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHubAPI.Persistence.Repository;

public class AuthorImageFileWriteRepository : WriteRepository<AuthorImageFile>, IAuthorImageFileWriteRepository
{
    public AuthorImageFileWriteRepository(BookHubDbContext context) : base(context)
    {
    }
}
