using System;
using ZenTool.AppService.AppServices;
using ZenTool.AppService.IAppServices;
using System.Text.Json;

namespace ZenTool.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            while(true)
            {
                string id = Console.ReadLine();
                
                IZenTaskAppService service = new ZenTaskAppService();

                var re= service.GetById(long.Parse( id));

                Console.WriteLine(JsonSerializer.Serialize(re));
            }
        }
    }
}
