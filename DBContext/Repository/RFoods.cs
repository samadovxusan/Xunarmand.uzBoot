using DBContexts.Data;
using DBContexts.Generic;
using System;

namespace DBContexts.Repository
{
    }
    public class RFoods : Repository<RFoods, AppDbContext> 
    {
    public RFoods(AppDbContext appDbcontext) : base(appDbcontext) { }
}
