﻿using ProniaMVCProject.Core.Models;
using ProniaMVCProject.Core.RepositoryAbstracts;
using ProniaMVCProject.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaMVCProject.Data.RepositoryConcretes
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext) { }

    }
}
