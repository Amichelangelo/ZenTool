using System;
using ZenTool.AppService.Dtos.ZenTask;
using ZenTool.AppService.IAppServices;
using ZenTool.DapperRepository;
using ZenTool.Domain.Entity;
using ZenTool.Domain.IRepository;
using ZenTool.Infrastructure.Helpers;

namespace ZenTool.AppService.AppServices
{
    public class ZenTaskAppService : IZenTaskAppService
    {
        private readonly IZenTaskRepository _taskRepository;
        public ZenTaskAppService()
        {
            _taskRepository = new ZenTaskRepository();
        }

        public DtoTaskReponse GetById(long id)
        {
            ZenTaskEntity entity = _taskRepository.Get(id);
            var re= AutoMapperHelper.Map<ZenTaskEntity, DtoTaskReponse>(entity);
            return re;
        }
    }
}
