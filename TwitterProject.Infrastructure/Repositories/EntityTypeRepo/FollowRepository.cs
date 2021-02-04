﻿using System;
using System.Collections.Generic;
using System.Text;
using TwitterProject.Domain.Entities.Concrete;
using TwitterProject.Domain.Repositories.EntityTypeRepo;
using TwitterProject.Infrastructure.Context;
using TwitterProject.Infrastructure.Repositories.BaseRepo;

namespace TwitterProject.Infrastructure.Repositories.EntityTypeRepo
{
    public class FollowRepository : BaseRepository<Follow>, IFollowRepository
    {
        public FollowRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }
    }
}
