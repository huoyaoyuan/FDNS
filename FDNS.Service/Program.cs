using System.ServiceProcess;

namespace FDNS.Service
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        private static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new FDNSService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
