using System;
using System.Linq;
using AutoMapper;

namespace ZenTool.Infrastructure.Helpers
{
    public static class AutoMapperHelper
    {
        public static TTarget Map<TSource, TTarget>(TSource source, TTarget targetInstance = null)
            where TSource : class
            where TTarget : class, new()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TSource, TTarget>());
            var mapper = config.CreateMapper();
            TTarget info = mapper.Map<TSource, TTarget>(source);
            return info;
        }
    }
}
