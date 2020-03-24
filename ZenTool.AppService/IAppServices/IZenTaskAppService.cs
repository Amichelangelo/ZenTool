using System;
using ZenTool.AppService.Dtos.ZenTask;

namespace ZenTool.AppService.IAppServices
{
    public interface IZenTaskAppService
    {
        DtoTaskReponse GetById(long id);
    }
}
