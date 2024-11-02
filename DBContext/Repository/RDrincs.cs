
using DBContexts.Data;
using DBContexts.Generic;
using System.Security.Principal;

namespace DBContexts.Repository
{
    public class RDrincs : Repository<RDrincs,AppDbContext>
    {
        public RDrincs(AppDbContext appDbcontext) : base(appDbcontext) { }
    }
}
