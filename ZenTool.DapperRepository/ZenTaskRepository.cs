using System;
using System.Collections.Generic;
using System.Text;
using ZenTool.Domain.Entity;
using ZenTool.Domain.IRepository;

namespace ZenTool.DapperRepository
{
    public class ZenTaskRepository : Repository<ZenTaskEntity>, IZenTaskRepository
    {
        protected override string TableName => "zt_task";
    }
}
