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
    public class TipoLugarRepository : Repository<TipoLugar>, ITipoLugarRepository
    {
        public TipoLugarRepository(DbContext context) : base(context)
        {
        }

    }
}
