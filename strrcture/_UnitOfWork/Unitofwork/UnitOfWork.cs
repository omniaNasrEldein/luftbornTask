﻿using AutoMapper;
using Product.Data.Infrastructure._Repository.IRepository;
using Product.Data.Infrastructure._Repository.Repository;
using Product.Data.Infrastructure._UniteOfWork;
using Product.Data.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Infrastructure._UnitOfWork.Unitofwork
{
    public partial class UnitOfWork : IUnitOfWork
    {
        public AppDbContext AppDbContext { get; }
        public IMapper Mapper { get; }

        public UnitOfWork(AppDbContext appContext, IMapper mapper)
        {
            AppDbContext = appContext;
            Mapper = mapper;
        }

        public Task<int> Commit()
        {
            return AppDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {

        }
    }
}
