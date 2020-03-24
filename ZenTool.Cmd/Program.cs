using System;
using System.Text;
using ZenTool.AppService.AppServices;
using ZenTool.AppService.IAppServices;
using Newtonsoft.Json;

namespace ZenTool.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!你好");
            string id = "10396"; // Console.ReadLine();

            IZenTaskAppService service = new ZenTaskAppService();

            var re = service.GetById(long.Parse(id));

            var x = JsonConvert.SerializeObject(re);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
