﻿using BookHubAPI.Domain.Common;

namespace BookHubAPI.Domain.Entities;

public class Genre : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }
}
