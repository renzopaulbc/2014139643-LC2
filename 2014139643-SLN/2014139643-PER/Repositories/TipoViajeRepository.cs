﻿using _2014139643_ENT;
using _2014139643_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139643_PER.Repositories
{
    public class TipoViajeRepository : Repository<TipoViaje>, ITipoViajeRepository
    {
        public TipoViajeRepository(DbContext context) : base(context)
        {
        }
    }
}
