using DBContexts.Data;
using DBContexts.Generic;

namespace DBContexts.Repository
{
    public class RIce_Cream : Repository<RIce_Cream, AppDbContext>
    {
        public RIce_Cream(AppDbContext appDbcontext) : base(appDbcontext) { }
    }
}